using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MyArticleApp
{
    class ConnectionBD
    {
        private static string connectionString = @"Data Source=CKA-SMART;Initial Catalog=TpKalti1;Integrated Security=True";

        private static SqlConnection con = new SqlConnection(connectionString);
        private SqlDataAdapter myAdapter;

         
        private bool OpenConnexion()
        {
            try
            {
                con.Open();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                con.Close();
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public void FunctionToWrite(SqlCommand cmd)
        {
             
                if (OpenConnexion() == true)
                {
                    cmd.Connection = con;
                    cmd.ExecuteNonQuery();
                }
            
            
                //fermeture de la connextion
                CloseConnection();
             
        }

        public DataTable FunctionToRead(SqlCommand cmd)
        {
            try
            {

                DataTable dt = new DataTable();
                cmd.Connection = con;
                if (OpenConnexion() == true)
                {


                    SqlDataReader dr = cmd.ExecuteReader();
                    dt.Load(dr);

                }
                return dt;
            }
            catch (Exception e)
            {
                 Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
                //fermeture de la connextion
                CloseConnection();
            }

        }

        public int FunctionToWriteScalar(SqlCommand cmd)
        {
            cmd.Connection = con;
            int NumberOfRows = 0;

            try
            {

                //ouverture de la connection
                if (OpenConnexion() == true)
                {
                    

                    //execution de la commande 
                    NumberOfRows = (Int32)cmd.ExecuteScalar();


                }

            }
            catch (Exception e)
            {
                 

                Console.WriteLine(e.Message); 
                Console.WriteLine("");
            }
            finally
            {
                //fermeture de la connextion
                CloseConnection();
            }
            return NumberOfRows;

        }

        public bool executeUpdateQuery(String _query, SqlParameter[] sqlParameter)
        {
            try
            {
                SqlCommand myCommand = new SqlCommand(_query, con);
                myAdapter.UpdateCommand = myCommand;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                //Console.Write("Error - Connection.executeUpdateQuery - Query:     " + _query + " \nException: " + e.StackTrace.ToString());
                return false;
            }
            finally
            {
                CloseConnection();
            }
            return true;
        }

        public DataTable FunctionToReadModeDisconnect(String _query, SqlParameter[] sqlParameter)
        {
            myAdapter = new SqlDataAdapter();
            SqlCommand myCommand = new SqlCommand();
            DataTable dataTable = new DataTable();
            dataTable = null;
            DataSet ds = new DataSet();
            try
            {
                myCommand.Connection = con;
                con.Open();
                myCommand.CommandText = _query;
                myCommand.Parameters.AddRange(sqlParameter);
                myCommand.ExecuteNonQuery();
                myAdapter.SelectCommand = myCommand;
                myAdapter.Fill(ds);
                dataTable = ds.Tables[0];
                con.Close();
            }
            catch (SqlException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
            finally
            {
            }
            return dataTable;
        }

    }
}



/*
 * private SqlConnection openConnection()
     {
         if (conn.State == ConnectionState.Closed || conn.State == ConnectionState.Broken)
         {
             conn.Open();
         }
         return conn;
     }

     public void CloseConnection()
     {
         if (this.conn != null)
         {
             if (this.conn.State != System.Data.ConnectionState.Closed)
             {
                 this.conn.Close();
             }
         }
     }

     public List<Article> executeSelectQuery(String _query, SqlParameter[] sqlParameter)
     {
         SqlCommand myCommand = new SqlCommand();
         DataTable dataTable = new DataTable();
         dataTable = null;
         DataSet ds = new DataSet();
         try
         {
             myCommand.Connection = openConnection();
             myCommand.CommandText = _query;
             myCommand.Parameters.AddRange(sqlParameter);
             myCommand.ExecuteNonQuery();
             myAdapter.SelectCommand = myCommand;
             myAdapter.Fill(ds);
             dataTable = ds.Tables[0];
         }
         catch (SqlException e)
         {
             Console.Write("Error - Connection.executeSelectQuery - Query:     " + _query + " \nException: " + e.StackTrace.ToString());
             return null;
         }
         finally
         {
             CloseConnection();
         }
         List<Article> ArticleList = new List<Article>();
         for (int i = 0; i < dataTable.Rows.Count; i++)
         {
             Article articles = new Article();
             articles.RefProp = dataTable.Rows[i]["Reference"].ToString();
             articles.DesiProp = dataTable.Rows[i]["Designation"].ToString();
             articles.PrixProp = (float)dataTable.Rows[i]["Prix"];
             articles.PromoProp = (Boolean)dataTable.Rows[i]["Promo"];
             articles.DatePromoProp = dataTable.Rows[i]["DateInPromo"].ToString();
             ArticleList.Add(articles);
         }

         return ArticleList;
     }


     public DataTable executeSelectAllQuery(String _query )
     {
         SqlCommand myCommand = new SqlCommand();
         DataTable dataTable = new DataTable();
         dataTable = null;
         DataSet ds = new DataSet();
         try
         {
             myCommand.Connection = openConnection();
             myCommand.CommandText = _query; 
             myCommand.ExecuteNonQuery();
             myAdapter.SelectCommand = myCommand;
             myAdapter.Fill(ds);
             dataTable = ds.Tables[0];
         }
         catch (SqlException e)
         {
             Console.Write("Error - Connection.executeSelectQuery - Query:     " + _query + " \nException: " + e.StackTrace.ToString());
             return null;
         }
         finally
         {
             CloseConnection();
         }
         return dataTable;
     }

     public bool executeInsertQuery(String _query, SqlParameter[] sqlParameter)
     {
         SqlCommand myCommand = new SqlCommand();
         try {
                 myCommand.Connection = openConnection();
                 myCommand.CommandText = _query;
                 myCommand.Parameters.AddRange(sqlParameter);
                 myAdapter.InsertCommand = myCommand;
                 myCommand.ExecuteNonQuery();
         }
         catch (SqlException e)
         {
             Console.Write("Error - Connection.executeInsertQuery - Query:     " + _query + " \nException: \n" + e.StackTrace.ToString());
             return false;
         }
         finally
         {
             CloseConnection();
         }
         return true;
     } 


      public bool executeUpdateOrDeleteQuery(String _query, SqlParameter[] sqlParameter)
     {
         try
         {
             SqlCommand myCommand = new SqlCommand( _query, openConnection());  
             myAdapter.UpdateCommand = myCommand;
             myCommand.Parameters.AddRange(sqlParameter);
             myCommand.ExecuteNonQuery();
         }
         catch (SqlException e)
         {
             Console.WriteLine(e.Message);
             //Console.Write("Error - Connection.executeUpdateQuery - Query:     " + _query + " \nException: " + e.StackTrace.ToString());
             return false;
         }
         finally
         {
             CloseConnection();
         }
         return true;
     }
     public bool executeDeleteQuery(String _query )
     {
         try
         {
             SqlCommand myCommand = new SqlCommand(_query, openConnection());
             myAdapter.UpdateCommand = myCommand;
             myCommand.ExecuteNonQuery();
         }
         catch (SqlException e)
         {
             Console.WriteLine(e.Message);
             //Console.Write("Error - Connection.executeUpdateQuery - Query:     " + _query + " \nException: " + e.StackTrace.ToString());
             return false;
         }
         finally
         {
             CloseConnection();
         }
         return true;
     }

 */
