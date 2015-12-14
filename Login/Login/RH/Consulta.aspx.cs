using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SARI.MVC;
using Obout.Grid;

namespace SARI
{
    public partial class Consulta : System.Web.UI.Page
    {
        private Modelo m = new Modelo();
        public SqlDataSource SqlDataSource1 = new SqlDataSource();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //gvTabla.DataSourceID = null;
                //this.Page.Controls.Remove(SqlDataSource1);
                SqlDataSource1.ID = "SqlDataSource1";
                this.Page.Controls.Add(SqlDataSource1);
                cbMain.SelectedIndex = 0; 
            }
        }
      
        public void clearFilter() 
        {
            for (int i = 0; i < gvTabla.Columns.Count; i++)
            {
                gvTabla.Columns[i].AllowFilter = false;
            }
        }
        protected void btnSearch_Click(object sender, ImageClickEventArgs e)
        {
            clearFilter();  txtparametro.Visible = true;
            FilterCriteria criteria = new FilterCriteria();
            switch (cbOption.SelectedIndex) 
            {
                case 0:
                    criteria.Option.Type = FilterOptionType.EqualTo;
                    break;
                case 1:
                    criteria.Option.Type = FilterOptionType.NotEqualTo;
                    break;
                case 2:
                    criteria.Option.Type = FilterOptionType.GreaterThan;
                    break;
                case 3:
                    criteria.Option.Type = FilterOptionType.SmallerThan;
                    break;
                case 4:
                    criteria.Option.Type = FilterOptionType.SmallerThanOrEqualTo;
                    break;
                case 5:
                    criteria.Option.Type = FilterOptionType.GreaterThanOrEqualTo;
                    break;
                case 6:
                    criteria.Option.Type = FilterOptionType.StartsWith;
                    break;
                case 7:
                    criteria.Option.Type = FilterOptionType.EndsWith;
                    break;
                case 8:
                    criteria.Option.Type = FilterOptionType.Contains;
                    break;
                case 9:
                    criteria.Option.Type = FilterOptionType.DoesNotContain;
                    break;
                case 10:
                    criteria.Option.Type = FilterOptionType.IsEmpty;
                    txtparametro.Visible = false;txtparametro.Text = "";
                    break;
                case 11:
                    criteria.Option.Type = FilterOptionType.IsNotEmpty;
                    txtparametro.Visible = false;txtparametro.Text = "";

                    break;
            }
            criteria.Value = txtparametro.Text;
            gvTabla.Columns[cbFiltro.SelectedIndex - 1].AllowFilter = true;
            gvTabla.Columns[cbFiltro.SelectedIndex-1].FilterCriteria = criteria;
        }
        public void loadTabla(string query)
        {
            SqlDataSource1.ConnectionString = m.cadConexion;
            SqlDataSource1.SelectCommand = query;
            gvTabla.DataSource = SqlDataSource1;
            gvTabla.DataBind();
            cbFiltro.Items.Clear();
            cbFiltro.Items.Add("Sin Filtro");
            for (int i = 0; i < gvTabla.Columns.Count; i++) 
            {
                cbFiltro.Items.Add(gvTabla.Columns[i].HeaderText);
            }
        }


        private void ClearButons(bool x) 
        {
            
        }
        private void VisibleControls(bool x) { }

        protected void cbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            visibleOption(true);
            switch (cbMain.SelectedIndex)
            {
                case 1:
                    loadTabla("SELECT [idpersona] as 'Id Persona' ,[nombre] as 'Nombre',[apaterno] as 'Apellido Paterno',[amaterno] as'Apellido Materno' ,[curp] as 'CURP',[rfc],[fechanac] as 'Fecha de Nacimiento',[sexo] as 'Sexo',[estadocivil] as 'Estado Civil' FROM Persona");
                    break;
                case 2:
                    loadTabla("SELECT * FROM Direccion");
                    break;
                case 3:
                    loadTabla("SELECT * FROM Telefono");
                    break;
                case 4:
                    loadTabla("SELECT * FROM Idioma");
                    break;
                case 5:
                    loadTabla("SELECT * FROM Academico");
                    break;
                default:
                    visibleOption(false);
                    loadTabla("SELECT TOP 0 nombre as 'Busqueda S.A.R.I.' FROM Persona");
                    break;
            }
        }
        private void visibleOption(bool x) 
        {
            lbl1.Visible = cbFiltro.Visible = x;
        }
        private void visibleParam(bool x) 
        {
            btnSearch.Visible= txtparametro.Visible = cbOption.Visible = x;
        }

        protected void cbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbFiltro.SelectedIndex) 
            {
                case 0:
                    visibleParam(false);
                    break;
                default:
                    visibleParam(true);
                    break;
            }
            switch (cbOption.SelectedIndex) 
            {
                case 10:
                txtparametro.Visible = false;txtparametro.Text = "";
                break;
                case 11:
                    txtparametro.Visible = false;txtparametro.Text = "";
                break;

            }
        }
    }
}