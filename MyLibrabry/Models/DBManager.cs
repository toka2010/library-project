using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;


namespace MyLibrabry.Models
{
    public class DBManager
    {
        public static DataSet ExecuteQuery(string query)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=library_system;Integrated Security=True");
            SqlCommand command = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds;

        }


        public static int ExecuteNonQuery(string query)
        {
            //"update Books set b_title='EnglandMyEnglandx',b_author='MarkDery',b_publisher='ThoughtCatalog',pdate=2012,category='Business',edition=7,no_pages=25,no_shelf=1,no_copies=5,photo='england.jpg' where b_id=0"
            int affected;
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=library_system;Integrated Security=True");
            SqlCommand command = new SqlCommand(query, con);
            try
            {
                con.Open();
                
                affected = command.ExecuteNonQuery();
            }
            catch (Exception)
            {
               
                throw;
            }
            finally
            {
                con.Close();
            }

            return affected;
        }
    }

}
