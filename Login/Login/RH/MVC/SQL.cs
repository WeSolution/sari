using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;
namespace SARI.MVC
{
    public class SQL
    {
        private SqlConnection c;
        public SQL(string s)
        {
            (c = new SqlConnection(s)).Open();
        }
        public int Query(string s)
        {
            return new SqlCommand(s, c).ExecuteNonQuery();
        }
        public SqlDataReader QueryReader(string s)
        {
            return new SqlCommand(s, c).ExecuteReader();
        }
        public DataTable QueryTable(string s)
        {
            DataTable t = new DataTable();
            new SqlDataAdapter(s, c).Fill(t);
            return t;
        }
        public int ProcedimientoAl(string s, params SqlParameter[] p)
        {
            SqlCommand com = new SqlCommand(s, c);
            com.CommandType = CommandType.StoredProcedure;
            for (int i = 0; i < p.Length; i++)
                com.Parameters.Add(p[i]);
            return com.ExecuteNonQuery();
        }
        public SqlDataReader ProcedimientoAl(string s, SqlParameter q, SqlCommand com = null)
        {
            (com = new SqlCommand(s, c)).CommandType = CommandType.StoredProcedure;
            com.Parameters.Add(q);
            return com.ExecuteReader();
        }
    }
    public class SqlParameterOut
    {
        public SqlParameter SqlParameterOutput;
        public SqlParameter getSqlParameterOut(string nombre)
        {
            SqlParameterOutput = new SqlParameter(nombre, System.Data.SqlDbType.Int);
            SqlParameterOutput.Direction = System.Data.ParameterDirection.Output;
            return SqlParameterOutput;
        }
    }
}