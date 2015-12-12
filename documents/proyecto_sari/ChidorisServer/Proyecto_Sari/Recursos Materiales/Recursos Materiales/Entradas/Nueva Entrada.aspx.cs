using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Recursos_Materiales.Clases;
using System.Data;

namespace Recursos_Materiales.Entradas
{
    public partial class Nueva_Entrada : System.Web.UI.Page
    {
        private Conexion1 con = new Conexion1();
        public DataTable tab;
        public int total;
        public DataRow row;
        public DataTable prod = new DataTable();
        public int cont = 0;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                txtFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                txtHora.Text = DateTime.Now.ToString("hh:mm:ss");
                CargarCombo();
                prod.Columns.Add("Producto");
                prod.Columns.Add("Proveedor");
                prod.Columns.Add("Cantidad de productos");
                prod.Columns.Add("Total");
                Session.Add("Tabla", prod);
                Session.Add("Total", total);
            }
            else
            {
                prod.Rows.Clear();
            }
            txtTotal.Text = "0";
        }

        public void CargarCombo()
        {
            try
            {
                tab = new DataTable();
                tab = con.Consultas("SELECT * FROM proveedor");
                cmbProveedores.DataTextField = tab.Columns[1].ToString();
                cmbProveedores.DataValueField = tab.Columns[1].ToString();
                cmbProveedores.DataSource = tab;
                cmbProveedores.DataBind();
            }
            catch (Exception)
            {
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                tab = new DataTable();
                tab = con.Consultas("SELECT precio_compra FROM producto WHERE id_producto = " + txtProducto.Text + " or identificador ='" + txtProducto.Text + "';");
                double precio = Convert.ToDouble(tab.Rows[0][0].ToString());

                prod = (System.Data.DataTable)(Session["Tabla"]);
                total = (int)(Session["Total"]);
                row = prod.NewRow();

                row[0] = txtProducto.Text;
                row[1] = cmbProveedores.Text;
                row[2] = txtCantidad.Text;
                row[3] = Convert.ToDouble(Convert.ToInt32(txtCantidad.Text) * precio);

                txtTotal.Text = (Convert.ToDouble(txtTotal.Text) + Convert.ToDouble(row[3].ToString())).ToString();

                prod.Rows.Add(row);
                dgvDatos.DataSource = prod;
                dgvDatos.DataBind();


                dgvDatos.Visible = true;
                cont++;

            }

            catch (Exception ex)
            {
                Response.Write("<script>window.alert('Error: " + ex.Message + "');</script>");
            }
        }

        protected void btnRegistrar_Click(object sender, EventArgs e)
        {
           
                if (con.DML("INSERT INTO entradas VALUES('" + txtFecha.Text + "','" + txtHora.Text + "','" + txtDesc.Text + "'," + dgvDatos.Rows[0].Cells[3].Text + ");") == true)
                {
                    try
                    {
                     for (int i = 0; i <= dgvDatos.Rows.Count - 1; i++)
                     {
                        string prove = con.Consultas("SELECT id_proveedor FROM proveedor WHERE nombre ='" + dgvDatos.Rows[i].Cells[2].Text + "';").Rows[0][0].ToString();
                        string sumi = con.Consultas("SELECT id_suministro FROM suministra WHERE id_proveedor = " + prove + " and id_producto = " + dgvDatos.Rows[i].Cells[1].Text + ";").Rows[0][0].ToString();
                        string entr = con.Consultas("SELECT MAX(id_entrada) FROM entradas").Rows[0][0].ToString();
                        if (con.DML("INSERT INTO detalle_entradas VALUES(" + entr + "," + sumi + "," + txtCantidad.Text + ");") == true)
                        {
                            con.DML("UPDATE producto SET stock = stock + " + Convert.ToInt32(dgvDatos.Rows[i].Cells[4].Text) + " WHERE id_producto = " + dgvDatos.Rows[i].Cells[1].Text + " or identificador ='" + dgvDatos.Rows[i].Cells[1].Text + "';");
                            con.DML("UPDATE producto SET localizacion = '" + txtUbicación.Text + "';");
                            Response.Write("<script>window.alert('Entrada registrada correctamente');</script>");
                            txtCantidad.Text = "";
                            txtDesc.Text = "";
                            txtProducto.Text = "";
                            txtTotal.Text = "0";
                            txtUbicación.Text = "";
                        }
                     }
                    }

                    catch (Exception ex)
                    {
                        Response.Write("<script>window.alert(' Error: " + ex.Message + "');</script>");
                    }
                    txtDesc.Text = "";
                    dgvDatos.Visible = false;
                }
                else
                {
                    Response.Write("<script>window.alert('Error al ingresar verifique sus datos');</script>");
                }
            }
        }
    }
