using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
//using System.Data.SqlClient.SqlException ;

namespace project_labrary.DAL
{
    class CLS_DAL
    {
        SqlConnection con = new SqlConnection();
        public CLS_DAL()
        {
            con = new SqlConnection(@"Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\نادر محمد\Desktop\تطبيقات c#\project_labrary\project_labrary\DB_LABRARY.mdf;Integrated Security=True ");
        }

        //method to open sql con
        public void open()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
        }
        //method to close sql con
        public void close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();
        }
        //function to read data
        public DataTable read ( string Store , SqlParameter[]pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Store;
            if (pr != null)   //cmd.Parameters.Add(pr);
                
                cmd.Parameters.AddRange(pr);

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            return dt;
        }
        //functio to excute the  insert and edit and  delete 
        public void excute(string Store, SqlParameter[] pr)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = Store;
            if (pr != null)
            {
                cmd.Parameters.AddRange(pr);
            }
            cmd.ExecuteNonQuery();

        }


    }
}
