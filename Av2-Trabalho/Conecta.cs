using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Data;

namespace Av2_Trabalho
{
    class Conecta
    {

            
       SqlConnection conn = null;

        public SqlConnection ConnectToDatabase()  
        {
            try
            {

                conn = new SqlConnection();
                var path = AppDomain.CurrentDomain.BaseDirectory?.Replace("bin\\Debug\\", "").Replace("bin\\Release\\", "");

                conn.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=" + path + "conexao.mdf;Integrated Security=True;Connect Timeout=30";
                conn.Open();
                return conn;

            }
            catch (Exception ex)
            {

                throw ex;
            }
        

    }
}
}
