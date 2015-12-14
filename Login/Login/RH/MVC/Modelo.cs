using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Collections;
using System.Data;
namespace SARI.MVC
{
    public class Modelo
    {
        public string cadConexion =System.Configuration.ConfigurationManager.ConnectionStrings[1].ToString();
        private SqlDataReader result;
        public int AlmacenaPersona(Persona p) 
        {
            SqlParameterOut r = new SqlParameterOut();
            new SQL(cadConexion).ProcedimientoAl("insertaPersona", new SqlParameter("@nombre", p.Nombre), new SqlParameter("@apaterno", p.ApPaterno), new SqlParameter("@amaterno", p.ApMaterno), new SqlParameter("@curp", p.Curp), new SqlParameter("@rfc", p.RFC), new SqlParameter("@fechaNac", p.FechaNac.ToShortDateString()), new SqlParameter("@sexo", p.Sexo), new SqlParameter("@estadocivil", p.EstCivil), new SqlParameter("@estatus", p.estatus), new SqlParameter("@fkdireccion", p.idDir), r.getSqlParameterOut("@return"));
            return (int)r.SqlParameterOutput.Value;
        }
        public int AlmacenaDireccion(Direccion d)
        {
            SqlParameterOut r = new SqlParameterOut();
            new SQL(cadConexion).ProcedimientoAl("insertarDireccion", new SqlParameter("@calle", d.calle), new SqlParameter("@numerointerior", d.ninterior), new SqlParameter("@numeroexterior", d.nexterior), new SqlParameter("@colonia", d.colonia), new SqlParameter("@codigopostal", d.cp), new SqlParameter("@estado", d.estado), new SqlParameter("@pais", d.pais), r.getSqlParameterOut("@return"));
            return (int)r.SqlParameterOutput.Value;
        }
        public int AlmacenaEmpleado(Empleado e)
        {
            SqlParameterOut r = new SqlParameterOut();
            new SQL(cadConexion).ProcedimientoAl("insertaEmpleado", new SqlParameter("@area", e.area), new SqlParameter("@puesto", e.puesto),new SqlParameter("@foto", e.foto), new SqlParameter("@fkpersona", e.fkpersona),  r.getSqlParameterOut("@return"));
            return (int)r.SqlParameterOutput.Value;
        }
        public int AlmacenaTelefono(Telefono t)
        {
            SqlParameterOut r = new SqlParameterOut();
            new SQL(cadConexion).ProcedimientoAl("insertaTelefono",
                new SqlParameter("@numero", t.NumeroTel),new SqlParameter("@tipo", t.TipoTel), r.getSqlParameterOut("@return"));
            return (int)r.SqlParameterOutput.Value;
        }
        public int AlmacenaJornada(Jornada e)
        {
            SqlParameterOut r = new SqlParameterOut();
            new SQL(cadConexion).ProcedimientoAl("insertaJornada", new SqlParameter("@tipo", e.tipo), new SqlParameter("@diasemana", e.DiasSemana), new SqlParameter("@turno", e.turno), new SqlParameter("@hrentrada", e.hrEntrada), new SqlParameter("@hrsalida", e.hrSalida), r.getSqlParameterOut("@return"));
            return (int)r.SqlParameterOutput.Value;
        }
        public int AlmacenaHabilidad(Habilidad h)
        {
            SqlParameterOut r = new SqlParameterOut();
            new SQL(cadConexion).ProcedimientoAl("insertaHabilidad", new SqlParameter("@tipo", h.Tipo), new SqlParameter("@descripcion", h.Descripcion), new SqlParameter("@fkempleado", h.idEmp), r.getSqlParameterOut("@return"));
            return (int)r.SqlParameterOutput.Value;
        }

        public int AlmacenaIdioma(Idioma i)
        {
            SqlParameterOut r = new SqlParameterOut();
            new SQL(cadConexion).ProcedimientoAl("insertaIdioma", new SqlParameter("@idioma", i.Nombre), new SqlParameter("@nivel", i.Nivel), new SqlParameter("@descripcion", i.Descripcion), new SqlParameter("@fkempleado", i.idEmp), r.getSqlParameterOut("@return"));
            return (int)r.SqlParameterOutput.Value;
        }
        public int AlmacenaAcademico(Academico A)
        {
            SqlParameterOut r = new SqlParameterOut();
            new SQL(cadConexion).ProcedimientoAl("insertaAcademico", new SqlParameter("@inicio", A.Fecha_Ini), new SqlParameter("@fin", A.Fecha_Ter), new SqlParameter("@titulobtenido", A.Titulo_Obt), new SqlParameter("@institucion", A.Institucion), new SqlParameter("@fkempleado", A.IdfkEmpleado), r.getSqlParameterOut("@return"));
            return (int)r.SqlParameterOutput.Value;
        }
        public ArrayList BuscarGrado(int Id)
        {
            ArrayList l = new ArrayList();
            result = new SQL(cadConexion).QueryReader("select * from Academico where fkempleado=" + Id);
            while (result.Read())
                l.Add(new Academico(Convert.ToDateTime(result[1].ToString()), Convert.ToDateTime(result[2].ToString()), result[3].ToString(), result[4].ToString(), Convert.ToInt32(result[5].ToString()), Convert.ToInt32(result[0].ToString())));
            return l;
            
        }
        public Direccion BuscarDireccion(int id) 
        {
            result= new SQL(cadConexion).QueryReader("select * from Direccion where iddireccion="+id);
            result.Read();
            return new Direccion(result[1].ToString(), result[2].ToString(), Convert.ToInt32(result[3].ToString()), result[4].ToString(), Convert.ToInt32(result[5].ToString()), result[6].ToString(), result[7].ToString(), Convert.ToInt32(result[0].ToString()));
        }
        public Persona BuscarPersona(int id)
        {
            result = new SQL(cadConexion).QueryReader("select * from Persona where idpersona=" + id);
            result.Read();
            return new Persona(result[1].ToString(), result[2].ToString(), result[3].ToString(), result[4].ToString(), result[5].ToString(), Convert.ToDateTime(result[6].ToString()), result[7].ToString(), result[8].ToString(), result[9].ToString(), Convert.ToInt32(result[10].ToString()), Convert.ToInt32(result[0].ToString()));
        }
        public Persona BuscarPersonaRFC(String rfc)
        {
            result = new SQL(cadConexion).QueryReader("select * from Persona where rfc= '" + rfc + "'");
            result.Read();
            return new Persona(result[1].ToString(), result[2].ToString(), result[3].ToString(),
                result[4].ToString(), result[5].ToString(), Convert.ToDateTime(result[6].ToString()),
                result[7].ToString(), result[8].ToString(), result[9].ToString(), Convert.ToInt32(result[10].ToString()),
                Convert.ToInt32(result[0].ToString()));
        }

        public Persona BuscarPersonaCURP(String curp)
        {
            result = new SQL(cadConexion).QueryReader("select * from Persona where curp= '" + curp + "'");
            result.Read();
            return new Persona(result[1].ToString(), result[2].ToString(), result[3].ToString(),
                result[4].ToString(), result[5].ToString(), Convert.ToDateTime(result[6].ToString()),
                result[7].ToString(), result[8].ToString(), result[9].ToString(), Convert.ToInt32(result[10].ToString()),
                Convert.ToInt32(result[0].ToString()));
        }
        public Empleado BuscarEmpleado(int id)
        {
            result = new SQL(cadConexion).QueryReader("select * from Empleado where fkpersona=" + id);
            result.Read();
            return new Empleado(result[2].ToString(), result[1].ToString(), result[3].ToString(),Convert.ToInt32(result[4].ToString()), Convert.ToInt32(result[0].ToString()));
        }
        public ArrayList BuscarTelefono(int id)
        {
            ArrayList l = new ArrayList();
            result = new SQL(cadConexion).QueryReader("select t.idtelefono,t.numero,t.tipo from Telefono as t,contacto as c where c.fkpersona="+id+" and c.fktelefono=t.idtelefono;");
            while (result.Read()) 
                l.Add(new Telefono(result[1].ToString(), result[2].ToString(), Convert.ToInt32(result[0].ToString())));
            return l;
            
        }
        public ArrayList BuscarJornada(int id)
        {
            ArrayList l = new ArrayList();
            result = new SQL(cadConexion).QueryReader("select idjornada,tipo,diasemana,turno,hrentrada,hrsalida from asiste as a, jornada as j  where fkempleado=" + id + " and fkjornada=idjornada");
            while (result.Read())
                l.Add(new Jornada(result[1].ToString(), Convert.ToInt32(result[2].ToString()), result[3].ToString(), result[4].ToString(), result[5].ToString(), Convert.ToInt32(result[0].ToString())));
            return l;
        }

        public ArrayList BuscarHabilidadID(int id)
        {
            ArrayList l = new ArrayList();
            result = new SQL(cadConexion).QueryReader("select * from Habilidad where fkempleado=" + id.ToString());
            while (result.Read())
            l.Add( new Habilidad(result[1].ToString(), result[2].ToString(), Convert.ToInt32(result[3].ToString()),Convert.ToInt32(result[0].ToString())));
            return l;
        }

        public ArrayList BuscarIdiomaID(int id)
        {
            ArrayList l = new ArrayList();
            result = new SQL(cadConexion).QueryReader("select * from Idioma where fkempleado= " + id.ToString());
            while (result.Read())
            l.Add( new Idioma(result[1].ToString(), result[2].ToString(), result[3].ToString(),Convert.ToInt32(result[4].ToString()), Convert.ToInt32(result[0].ToString())));
            return l;
        }
        
        public int AlmacenaIdiomas(ArrayList l,int fk=-1) 
        {
            for (int i = 0; i < l.Count; i++) 
            {
                Idioma x = (Idioma)(l[i]);
                if (x.id == -1)
                {
                    x.idEmp = fk;
                    AlmacenaIdioma(x);
                }
                else
                    EditaIdioma(x);
            }
            return fk;
        } 
        public int AlmacenaHabilidades(ArrayList l, int fk=-1) 
        {
            for (int i = 0; i < l.Count; i++) 
            {
                Habilidad x = (Habilidad)(l[i]);
                if (x.id == -1)
                {
                    x.idEmp = fk;
                    AlmacenaHabilidad(x);
                }
                else
                    EditaHabilidad(x);

            }
            return fk;
        }
        public int AlmacenaGradosAcademicos(ArrayList l, int fk=-1) 
        {
            for (int i = 0; i < l.Count; i++)
            {
                Academico x = (Academico)(l[i]);
                if (x.Id == -1)
                {
                    x.IdfkEmpleado = fk;
                    AlmacenaAcademico(x);
                }
                else
                    EditaAcademico(x);
            }
            return fk;
        }
        public int AlmacenaTelefonos(ArrayList l,int fk=-1) 
        {
            for (int i = 0; i < l.Count; i++)
            {
                Telefono x = (Telefono)(l[i]);
                if (x.ID == -1)
                {
                    SqlParameterOut r = new SqlParameterOut();
                    new SQL(cadConexion).ProcedimientoAl("insertacontacto", new SqlParameter("@fktelefono", AlmacenaTelefono(x)), new SqlParameter("@fkpersona", fk), r.getSqlParameterOut("@return"));
                }
                else
                    EditaTelefono(x);
            }
            return fk;
        }
        public int AlmacenaJornadas(ArrayList l, int fk=-1)
        {
            for (int i = 0; i < l.Count; i++)
            {
                Jornada x = (Jornada)(l[i]);
                if (x.idJornada == -1)
                {
                    SqlParameterOut r = new SqlParameterOut();
                    new SQL(cadConexion).ProcedimientoAl("insertasiste", new SqlParameter("@fkempleado", fk), new SqlParameter("@fkjornada", AlmacenaJornada(x)), r.getSqlParameterOut("@return"));
                }
                else
                    EditaJornada(x);
            }
            return fk;
        }
        public int EliminaenCascada(int id) 
        {
            return new SQL(cadConexion).Query("delete Direccion where iddireccion="+id);
        }
        public int EditaPersona(Persona p)
        {
            return new SQL(cadConexion).ProcedimientoAl("editaPersona",new SqlParameter("@id",p.id), new SqlParameter("@nombre", p.Nombre), new SqlParameter("@apaterno", p.ApPaterno), new SqlParameter("@amaterno", p.ApMaterno), new SqlParameter("@curp", p.Curp), new SqlParameter("@rfc", p.RFC), new SqlParameter("@fechaNac", p.FechaNac.ToShortDateString()), new SqlParameter("@sexo", p.Sexo), new SqlParameter("@estadocivil", p.EstCivil), new SqlParameter("@fkdireccion", p.idDir));
        }
        public int EditaDireccion(Direccion d)
        {
            return new SQL(cadConexion).ProcedimientoAl("editarDireccion", new SqlParameter("@id", d.id), new SqlParameter("@calle", d.calle), new SqlParameter("@numerointerior", d.ninterior), new SqlParameter("@numeroexterior", d.nexterior), new SqlParameter("@colonia", d.colonia), new SqlParameter("@codigopostal", d.cp), new SqlParameter("@estado", d.estado), new SqlParameter("@pais", d.pais));
        }
        public int EditaEmpleado(Empleado e)
        {
            return new SQL(cadConexion).ProcedimientoAl("editaEmpleado", new SqlParameter("@id", e.id), new SqlParameter("@area", e.area), new SqlParameter("@puesto", e.puesto), new SqlParameter("@foto", e.foto), new SqlParameter("@fkpersona", e.fkpersona));
        }
        public int EditaTelefono(Telefono t)
        {
            return new SQL(cadConexion).ProcedimientoAl("editaTelefono", new SqlParameter("@id", t.ID), new SqlParameter("@numero", t.NumeroTel), new SqlParameter("@tipo", t.TipoTel));
        }
        public int EditaJornada(Jornada e)
        {
            return new SQL(cadConexion).ProcedimientoAl("editaJornada", new SqlParameter("@id", e.idJornada), new SqlParameter("@tipo", e.tipo), new SqlParameter("@diasemana", e.DiasSemana), new SqlParameter("@turno", e.turno), new SqlParameter("@hrentrada", e.hrEntrada), new SqlParameter("@hrsalida", e.hrSalida));
        }
        public int EditaHabilidad(Habilidad h)
        {
            return new SQL(cadConexion).ProcedimientoAl("editaHabilidad", new SqlParameter("@id", h.id), new SqlParameter("@tipo", h.Tipo), new SqlParameter("@descripcion", h.Descripcion), new SqlParameter("@fkempleado", h.idEmp));
        }

        public int EditaIdioma(Idioma i)
        {
            return new SQL(cadConexion).ProcedimientoAl("editaIdioma", new SqlParameter("@id", i.id), new SqlParameter("@idioma", i.Nombre), new SqlParameter("@nivel", i.Nivel), new SqlParameter("@descripcion", i.Descripcion), new SqlParameter("@fkempleado", i.idEmp));
        }
        public int EditaAcademico(Academico A)
        {
            return new SQL(cadConexion).ProcedimientoAl("editaAcademico", new SqlParameter("@id", A.Id), new SqlParameter("@inicio", A.Fecha_Ini), new SqlParameter("@fin", A.Fecha_Ter), new SqlParameter("@titulobtenido", A.Titulo_Obt), new SqlParameter("@institucion", A.Institucion), new SqlParameter("@fkempleado", A.IdfkEmpleado));

        }
        public void eliminaAcademico(ArrayList l) 
        {
            for (int i = 0; i < l.Count; i++)
                new SQL(cadConexion).ProcedimientoAl("eliminaAcademico", new SqlParameter("@idElimA", l[i]));
        }
        public void eliminaHabilidad(ArrayList l)
        {
            for (int i = 0; i < l.Count; i++)
                new SQL(cadConexion).ProcedimientoAl("eliminaHabilidad", new SqlParameter("@idElimH", l[i]));
        }
        public void eliminaIdioma(ArrayList l)
        {
            for (int i = 0; i < l.Count; i++)
                new SQL(cadConexion).ProcedimientoAl("eliminaIdioma", new SqlParameter("@idElimI", l[i]));
        }
        public void eliminaJornada(ArrayList l)
        {
            for (int i = 0; i < l.Count; i++)
                new SQL(cadConexion).ProcedimientoAl("eliminaJornada", new SqlParameter("@idElimJ", l[i]));
        }
        public void eliminaTelefono(ArrayList l)
        {
            for (int i = 0; i < l.Count; i++)
                new SQL(cadConexion).ProcedimientoAl("eliminaTelefono", new SqlParameter("@idElimT", l[i]));
        }
        public DataTable obtTabla(string query) 
        {
            return new SQL(cadConexion).QueryTable(query);
        }
    }
    
}