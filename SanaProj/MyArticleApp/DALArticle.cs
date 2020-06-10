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
    class DALArticle
    {
        private ConnectionBD Connexion;
        private SqlCommand MySqlCommand;
        private DataTable dt = new DataTable();

        public DALArticle()
        {
            Connexion = new ConnectionBD();
        }

         
       public Article ConvertRowToArticle(DataRow row)
        {

            Article CurrentArticle = new Article();

            string Reference = (row["Référence"].ToString().Length != 0) ? row["Référence"].ToString() : "pas de reference";
            CurrentArticle.RefProp = Reference;

            string Designation = (row["Désignation"].ToString().Length != 0) ? row["Désignation"].ToString() : "pas de Designation";
            CurrentArticle.DesiProp = Designation;


            string Date = (row["Date en promo"].ToString().Length != 0) ? row["Date En promo"].ToString() : "pas de date";
            CurrentArticle.DatePromoProp = Date;

            bool promo = Boolean.Parse(row["En promo"].ToString());
            CurrentArticle.PromoProp = promo;

            int Quantite = Int32.Parse(row["Quantité"].ToString() );
            CurrentArticle.QuantProp = Quantite;

            int Prix = Int32.Parse(row["Prix unitaire"].ToString());
            CurrentArticle.PrixProp = Prix;



            return CurrentArticle;

        }


        public void Add(Article artic)
        {
             
            MySqlCommand = new SqlCommand("insert into [Article](Reference, Designation, Prix, Promo, DateInPromo, Quantite) values(@articles_ref, @articles_desi, @articles_prix, @articles_promo, @articles_datepro, @articles_quant)");


            MySqlCommand.Parameters.Add("@articles_ref", SqlDbType.VarChar).Value = Convert.ToString(artic.RefProp);
            MySqlCommand.Parameters.Add("@articles_desi", SqlDbType.VarChar).Value = Convert.ToString(artic.DesiProp);
            MySqlCommand.Parameters.Add("@articles_prix", SqlDbType.Float).Value = Convert.ToDouble(artic.PrixProp);
            MySqlCommand.Parameters.Add("@articles_promo", SqlDbType.Bit).Value = Convert.ToBoolean(artic.PromoProp);
            MySqlCommand.Parameters.Add("@articles_datepro", SqlDbType.Date).Value = Convert.ToDateTime(artic.DatePromoProp);
            MySqlCommand.Parameters.Add("@articles_quant", SqlDbType.Int).Value = Convert.ToInt32(artic.QuantProp);

            Connexion.FunctionToWrite(MySqlCommand);
        }
      

        public DataTable GetAllArticles()
        { 
                
            DataTable dt = new DataTable();
            MySqlCommand = new SqlCommand("SELECT * FROM[Article] ");

            dt = Connexion.FunctionToRead(MySqlCommand);

            return dt;

        }

        public DataTable GetArticles()
        {

            DataTable dt = new DataTable();
            MySqlCommand = new SqlCommand("SELECT [Designation],[Prix],[Promo],[Quantite] FROM[Article] ");

            dt = Connexion.FunctionToRead(MySqlCommand);

            return dt;

        }

        public List<Article> GetArticleList()
        {
            List<Article> AllArticles = new List<Article>();

            MySqlCommand = new SqlCommand("select * from [Article]");

            dt = Connexion.FunctionToRead(MySqlCommand);
            dt = MiseEnforme.AdaptDataTableArticle(dt);

            foreach (DataRow row in dt.Rows)
            {
                AllArticles.Add(ConvertRowToArticle(row));
            }

            return AllArticles;
        }

        public string GetReference(string designation)
        {

            DataTable dt = new DataTable();
            MySqlCommand = new SqlCommand("SELECT [Reference] FROM[Article] where Designation=@Desi");
            MySqlCommand.Parameters.Add("@Desi", SqlDbType.VarChar).Value = Convert.ToString(designation);

            dt = Connexion.FunctionToRead(MySqlCommand);

            return Convert.ToString(dt.Rows[0]["Reference"]);

        }
        /*
                public void Achat(string desi,int quant)
                {
                    DataTable dt = new DataTable();
                    MySqlCommand = new SqlCommand("SELECT [Reference] FROM[Article] where Designation=@Desi");
                    MySqlCommand.Parameters.Add("@Desi", SqlDbType.VarChar).Value = Convert.ToString(desi);

                    dt = Connexion.FunctionToRead(MySqlCommand);

                    MySqlCommand = new SqlCommand(" UPDATE [Article] SET  Quantite =Quantite- @articles_quant where Reference=@Ref");

                    MySqlCommand.Parameters.Add("@Ref", SqlDbType.VarChar).Value = Convert.ToString(dt.Rows[0]["Reference"]);
                    MySqlCommand.Parameters.Add("@articles_quant", SqlDbType.Int).Value = Convert.ToInt32(quant);

                    Connexion.FunctionToWrite(MySqlCommand);
                }
*/
 
        public DataTable SelectByRef(string _Ref)
        {

            string query = string.Format("select * from [Article] where Reference = @_Ref ");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_Ref ", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_Ref);

            return Connexion.FunctionToReadModeDisconnect(query, sqlParameters);
        }

        public Article SelectByRef2(string _Ref)
        {
            Article ArtSearch = new Article();

            string query = string.Format("select * from [Article] where Reference = @_Ref ");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_Ref ", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_Ref);
            dt= Connexion.FunctionToReadModeDisconnect(query, sqlParameters);

            foreach (DataRow row in dt.Rows)
            {
                ArtSearch = ConvertRowToArticle(row);
            }
            return ArtSearch;
        }

        public void Update(Article OldArticle, Article NewArticle)
        {

            //string query = "UPDATE Article SET  Reference ='"+NewArticle.RefProp.ToString() + "', Designation ='"+NewArticle.DesiProp.ToString() + "', Prix ="+NewArticle.PrixProp +", Promo ="+  Convert.ToByte(NewArticle.PromoProp)+",  Quantite ="+NewArticle.QuantProp +" where Reference ='"+OldArticle.RefProp.ToString() + "';";

            MySqlCommand = new SqlCommand(" UPDATE [Article] SET  Reference= @articles_ref , Designation = @articles_desi , Prix= @articles_prix , Promo= @articles_promo , DateInPromo = @articles_datepro , Quantite = @articles_quant where Reference='"+OldArticle.RefProp+"'");
            //MySqlCommand.Parameters.Add("@Ref", SqlDbType.VarChar).Value = OldArticle.RefProp;
            MySqlCommand.Parameters.Add("@articles_ref", SqlDbType.VarChar).Value = Convert.ToString(NewArticle.RefProp);
            MySqlCommand.Parameters.Add("@articles_desi", SqlDbType.VarChar).Value = Convert.ToString(NewArticle.DesiProp);
            MySqlCommand.Parameters.Add("@articles_prix", SqlDbType.Float).Value = Convert.ToDouble(NewArticle.PrixProp);
            MySqlCommand.Parameters.Add("@articles_promo", SqlDbType.Bit).Value = Convert.ToBoolean(NewArticle.PromoProp);
            MySqlCommand.Parameters.Add("@articles_datepro", SqlDbType.Date).Value = Convert.ToDateTime(NewArticle.DatePromoProp);
            MySqlCommand.Parameters.Add("@articles_quant", SqlDbType.Int).Value = Convert.ToInt32(NewArticle.QuantProp);


             Connexion.FunctionToWrite(MySqlCommand);

        }


        public bool CheckUniqueRef(string cref)
        {


            dt = GetAllArticles();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Reference"].ToString() == cref)
                {
                    return false;
                }
            }

            return true;
        }
        public void Update(string Ref , Article NewArticle)
        {
            MySqlCommand = new SqlCommand(" UPDATE [Article] SET  Reference= @articles_ref , Designation = @articles_desi , Prix= @articles_prix , Promo= @articles_promo , DateInPromo = @articles_datepro , Quantite = @articles_quant where Reference=@Ref");
            MySqlCommand.Parameters.Add("@Ref", SqlDbType.VarChar).Value =  Ref;
            MySqlCommand.Parameters.Add("@articles_ref", SqlDbType.VarChar).Value = Convert.ToString(NewArticle.RefProp);
            MySqlCommand.Parameters.Add("@articles_desi", SqlDbType.VarChar).Value = Convert.ToString(NewArticle.DesiProp);
            MySqlCommand.Parameters.Add("@articles_prix", SqlDbType.Float).Value = Convert.ToDouble(NewArticle.PrixProp);
            MySqlCommand.Parameters.Add("@articles_promo", SqlDbType.Bit).Value = Convert.ToBoolean(NewArticle.PromoProp);
            MySqlCommand.Parameters.Add("@articles_datepro", SqlDbType.Date).Value = Convert.ToDateTime(NewArticle.DatePromoProp);
            MySqlCommand.Parameters.Add("@articles_quant", SqlDbType.Int).Value = Convert.ToInt32(NewArticle.QuantProp);
            


            Connexion.FunctionToWrite(MySqlCommand);

        }
 
        public  void Delete(string del)
        {
             
            MySqlCommand = new SqlCommand("DELETE FROM [Article] WHERE Reference = @Rdel");

            MySqlCommand.Parameters.Add("@Rdel", SqlDbType.VarChar).Value = del;

            Connexion.FunctionToWrite(MySqlCommand);
        }
        
    }

 
}
