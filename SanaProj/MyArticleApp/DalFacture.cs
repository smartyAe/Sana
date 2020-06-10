using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyArticleApp
{
    class DalFacture
    {
        private ConnectionBD Connexion;
        private SqlCommand MySqlCommand;
        private DataTable dt = new DataTable();

        public DalFacture()
        {
            Connexion = new ConnectionBD(); 
        }

        static Facture ConvertRowToFacture(DataRow row)
        {

            Facture CurrentFacture = new Facture();

            
            string Reff = (row["Reference"].ToString().Length != 0) ? row["Reference"].ToString() : "pas de reference";
            CurrentFacture.RefProp = Reff;

            float Mnt = float.Parse(row["Montant"].ToString());
            CurrentFacture.MontantProp = Mnt;

            string dateF = (row["Date"].ToString().Length != 0) ? row["Date"].ToString() : "pas de Date";
            CurrentFacture.DateProp = Convert.ToDateTime(dateF);
             

            return CurrentFacture;

        }
        static LigneFacture ConvertRowToLgFacture(DataRow row)
        {

            LigneFacture CurrentFacture = new LigneFacture();


            string Reff = (row["Reference"].ToString().Length != 0) ? row["Reference"].ToString() : "pas de reference";
            CurrentFacture.RefProp = Reff;

            float Mnt = float.Parse(row["Pu"].ToString());
            CurrentFacture.PrixUProp = Mnt;

            int qte = Int32.Parse(row["Quantite"].ToString());
            CurrentFacture.QuantProp = qte;
             

            return CurrentFacture;

        }

        public void AddByList(Facture fc)
        { 
            try
            {
                Article Artic;
                 
                SqlCommand MySqlCommand = new SqlCommand("insert into [Facture](Reference,Montant, Date) values(@Facture_ref, @Facture_Montant ,@Facture_date)");
                MySqlCommand.Parameters.Add("@Facture_ref", SqlDbType.VarChar).Value = Convert.ToString(fc.RefProp);
                MySqlCommand.Parameters.Add("@Facture_Date", SqlDbType.DateTime).Value = Convert.ToDateTime(fc.DateProp);
                MySqlCommand.Parameters.Add("@Facture_Montant", SqlDbType.Int).Value =fc.MontantProp;
                Connexion.FunctionToWrite(MySqlCommand);
 
                   
                    foreach(LigneFacture ListLf in fc.ListLgFacture)
                    {
                             
                           MySqlCommand = new SqlCommand("insert into [LigneFacture](IdFacture, IdArticle, Reference , Pu, Quantite) values(@FactureId, @ArticleId, @articles_ref,  @articles_prix,  @articles_quant)");

                            MySqlCommand.Parameters.Add("@articles_ref", SqlDbType.VarChar).Value = Convert.ToString(ListLf.RefProp);
                            MySqlCommand.Parameters.Add("@articles_prix", SqlDbType.Float).Value = Convert.ToDouble(ListLf.PrixUProp);
                            MySqlCommand.Parameters.Add("@articles_quant", SqlDbType.Int).Value = Convert.ToInt32(ListLf.QuantProp);
                            MySqlCommand.Parameters.Add("@ArticleId", SqlDbType.Int).Value = Convert.ToInt32(GetArticleId(ListLf.RefProp));
                            MySqlCommand.Parameters.Add("@FactureId", SqlDbType.Int).Value = Convert.ToInt32(GetFactureId(fc.RefProp));
                    DataTable MyDat = new DALArticle().SelectByRef(ListLf.RefProp);
                     Artic = new Article(ListLf.RefProp, MyDat.Rows[0]["Designation"].ToString(), float.Parse(MyDat.Rows[0]["Prix"].ToString()), Convert.ToBoolean(MyDat.Rows[0]["Promo"].ToString())
                       , MyDat.Rows[0]["DateInPromo"].ToString(), Int32.Parse(MyDat.Rows[0]["Quantite"].ToString())- ListLf.QuantProp);
                            new DALArticle().Update(ListLf.RefProp,Artic);
                            Connexion.FunctionToWrite(MySqlCommand);
                         
                    }
                
            }
            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }


        }

       
       
        /*
                public void AddFacture( LigneFacture ListF)
                { 
                    try
                    { 
                        SqlCommand MySqlCommand = new SqlCommand("insert into [Facture](Reference,Montant, Date) values(@Facture_ref, @Facture_Montant, @Facture_date)");

                        MySqlCommand.Parameters.Add("@Facture_ref", SqlDbType.VarChar).Value = Convert.ToString(ListF.RefFProp);
                        MySqlCommand.Parameters.Add("@Facture_Montant", SqlDbType.Int).Value = ListF.MontantProp ;
                        MySqlCommand.Parameters.Add("@Facture_Date", SqlDbType.Date).Value = Convert.ToDateTime(ListF.DateProp);
                        Connexion.FunctionToWrite(MySqlCommand);

                            MySqlCommand = new SqlCommand("insert into [LigneFacture](IdFacture, IdArticle, Reference , Pu, Quantite) values(@FactureId, @ArticleId, @articles_ref,  @articles_prix,  @articles_quant)");

                            MySqlCommand.Parameters.Add("@articles_ref", SqlDbType.VarChar).Value = Convert.ToString(ListF.RefProp);
                            MySqlCommand.Parameters.Add("@articles_prix", SqlDbType.Float).Value = Convert.ToDouble(ListF.PrixUProp);
                            MySqlCommand.Parameters.Add("@articles_quant", SqlDbType.Int).Value = Convert.ToInt32(ListF.QuantProp);
                            MySqlCommand.Parameters.Add("@ArticleId", SqlDbType.Int).Value = Convert.ToInt32(ListF.IdArtProp);
                            MySqlCommand.Parameters.Add("@FactureId", SqlDbType.Int).Value = Convert.ToInt32(GetFactureId(ListF.RefFProp));

                            Connexion.FunctionToWrite(MySqlCommand);

                    }
                    catch (SqlException es)
                    {
                        MessageBox.Show(es.Message);
                    }

                }

            */


        public void AddFacture(LigneFacture ListF)
        {
            try
            {
                SqlCommand MySqlCommand = new SqlCommand("insert into [Facture](Reference,Montant, Date) values(@Facture_ref, @Facture_Montant, @Facture_date)");

                MySqlCommand.Parameters.Add("@Facture_ref", SqlDbType.VarChar).Value = Convert.ToString(ListF.RefFProp);
                MySqlCommand.Parameters.Add("@Facture_Montant", SqlDbType.Int).Value = ListF.MontantProp;
                MySqlCommand.Parameters.Add("@Facture_Date", SqlDbType.Date).Value = Convert.ToDateTime(ListF.DateProp);
                Connexion.FunctionToWrite(MySqlCommand);

                MySqlCommand = new SqlCommand("insert into [LigneFacture](IdFacture, IdArticle, Reference , Pu, Quantite) values(@FactureId, @ArticleId, @articles_ref,  @articles_prix,  @articles_quant)");

                MySqlCommand.Parameters.Add("@articles_ref", SqlDbType.VarChar).Value = Convert.ToString(ListF.RefProp);
                MySqlCommand.Parameters.Add("@articles_prix", SqlDbType.Float).Value = Convert.ToDouble(ListF.PrixUProp);
                MySqlCommand.Parameters.Add("@articles_quant", SqlDbType.Int).Value = Convert.ToInt32(ListF.QuantProp);
                MySqlCommand.Parameters.Add("@ArticleId", SqlDbType.Int).Value = Convert.ToInt32(ListF.IdArtProp);
                MySqlCommand.Parameters.Add("@FactureId", SqlDbType.Int).Value = Convert.ToInt32(GetFactureId(ListF.RefFProp));

                Connexion.FunctionToWrite(MySqlCommand);


            }
            catch (SqlException es)
            {
                MessageBox.Show(es.Message);
            }

        }




        public bool CheckUniqueRef(string cref)
        {
             
             
            dt = GetAllFacture();
            foreach (DataRow dr in dt.Rows)
            {
                if (dr["Reference"].ToString() == cref)
                {
                    return false;
                }
            }
              
            return true;
        }


        public DataTable GetAllFactureLine()
        {

            DataTable dt = new DataTable();
            MySqlCommand = new SqlCommand("SELECT * FROM[LigneFacture] ");

            dt = Connexion.FunctionToRead(MySqlCommand);

            return dt;

        }

        public DataTable GetAllFacture()
        {

            DataTable dt = new DataTable();
            MySqlCommand = new SqlCommand("SELECT [Reference],[Montant], [Date] FROM[Facture] ");

            dt = Connexion.FunctionToRead(MySqlCommand);

            return dt;

        }

        public DataTable GetAllFactureLis()
        {

            DataTable dt = new DataTable();
            MySqlCommand = new SqlCommand("SELECT [Reference],[Montant], [Date] FROM[Facture] ");

            dt = Connexion.FunctionToRead(MySqlCommand);

            return dt;

        }


        public int GetArticleId(string reference)
        {

            DataTable dt = new DataTable();
            MySqlCommand = new SqlCommand("SELECT [Id] FROM[Article] where Reference=@ref");
            MySqlCommand.Parameters.Add("@ref", SqlDbType.VarChar).Value = Convert.ToString(reference);

            dt = Connexion.FunctionToRead(MySqlCommand);

            return Convert.ToInt32(dt.Rows[0]["Id"]);

        }
        public int GetFactureId(string reference)
        {

            DataTable dt = new DataTable();
            MySqlCommand = new SqlCommand("SELECT [Id] FROM[Facture] where Reference=@ref");
            MySqlCommand.Parameters.Add("@ref", SqlDbType.VarChar).Value = Convert.ToString(reference);

            dt = Connexion.FunctionToRead(MySqlCommand);

            return Convert.ToInt32(dt.Rows[0]["Id"].ToString());

        }

        


        public DataTable SelectByRef(string _Ref)
        {

            string query = string.Format("select  Lf.[Reference] ,Lf.[Pu] ,Lf.[Quantite] , F.[Reference], F.[Date] from [LigneFacture] Lf,[Facture] F where F.[Id]= Lf.[IdFacture] and F.Reference= @_Ref ");
            MySqlCommand.Parameters.Add("@_Ref", SqlDbType.VarChar).Value = _Ref;
            dt = Connexion.FunctionToRead(MySqlCommand);
            
            return dt;
        }


        public DataTable GetLigneFacturesByFacture(string RefFacture)
        { 
             MySqlCommand = new SqlCommand("select  Lf.[Reference], Lf.[Pu], Lf.[Quantite] ,F.[Montant], F.[Reference], F.[Date]  from[LigneFacture] Lf,[Facture] F where F.[Id] = Lf.[IdFacture] and F.Reference = @_Ref ");
             
            MySqlCommand.Parameters.Add("@_Ref", SqlDbType.VarChar).Value = RefFacture;
             dt = Connexion.FunctionToRead(MySqlCommand);
            
            return dt;
        }
        public List<LigneFacture> GetLigneFacturesListByFacture(string RefFacture)
        {
            List<LigneFacture> ListLg = new List<LigneFacture>();
            LigneFacture CurrentFacture;
            MySqlCommand = new SqlCommand("select  Lf.[Reference], Lf.[Pu], Lf.[Quantite] ,F.[Montant], F.[Reference], F.[Date]  from[LigneFacture] Lf,[Facture] F where F.[Id] = Lf.[IdFacture] and F.Reference = @_Ref ");

            MySqlCommand.Parameters.Add("@_Ref", SqlDbType.VarChar).Value = RefFacture;
            dt = Connexion.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                CurrentFacture = ConvertRowToLgFacture(row);
                ListLg.Add(CurrentFacture);
            }

            if (dt.Rows.Count == 0)
                return null;
            else
                return ListLg;
        }


        public List<LigneFacture> GetLigneFacturesList(string RefFacture)
        {
            List<LigneFacture> ListLg = new List<LigneFacture>();
            LigneFacture CurrentFacture;
            MySqlCommand = new SqlCommand("select  Lf.[Reference], Lf.[Pu], Lf.[Quantite]  from [LigneFacture] Lf, [Facture] F where  F.Reference = @_Ref ");

            MySqlCommand.Parameters.Add("@_Ref", SqlDbType.VarChar).Value = RefFacture;
            dt = Connexion.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                CurrentFacture = ConvertRowToLgFacture(row);
                ListLg.Add(CurrentFacture);
            }

            if (dt.Rows.Count == 0)
                return null;
            else
                return ListLg;
        }

        public DataTable LgId(string RefFacture,string RefLg)
        {
            MySqlCommand = new SqlCommand("select  Lf.[Id]  from[LigneFacture] Lf,[Facture] F where F.[Id] = Lf.[IdFacture] and F.Reference = @_Ref and Lf.Reference = @_RefLg ");

            MySqlCommand.Parameters.Add("@_Ref", SqlDbType.VarChar).Value = RefFacture;
            MySqlCommand.Parameters.Add("@_RefLg", SqlDbType.VarChar).Value = RefLg;
            dt = Connexion.FunctionToRead(MySqlCommand);

            return dt;
        }
        public DataTable SelectFactureByRef(string _Ref)
        {

            string query = string.Format("select * from [Facture] where Reference = @_Ref ");
            SqlParameter[] sqlParameters = new SqlParameter[1];
            sqlParameters[0] = new SqlParameter("@_Ref ", SqlDbType.VarChar);
            sqlParameters[0].Value = Convert.ToString(_Ref);

            return Connexion.FunctionToReadModeDisconnect(query, sqlParameters);
        }
        public Facture GetFactureByRef(string _Ref)
        {

            Facture FactureSearched = new Facture();
            MySqlCommand = new SqlCommand("select * from [Facture] where Reference = @_Ref ");
            MySqlCommand.Parameters.Add("@_Ref", SqlDbType.VarChar).Value = _Ref;

            dt = Connexion.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                FactureSearched = ConvertRowToFacture(row);
            }

            if (dt.Rows.Count == 0)
                return null;
            else
                return FactureSearched;
        }

        public List<Facture> GetFactureList( )
        {
            List< Facture> ListF = new List< Facture>();
            Facture Factures = new Facture();
            MySqlCommand = new SqlCommand("select [Reference],[Montant], [Date] FROM[Facture]  "); 

            dt = Connexion.FunctionToRead(MySqlCommand);

            foreach (DataRow row in dt.Rows)
            {
                Factures = ConvertRowToFacture(row);
                ListF.Add( Factures);
            }

            if (dt.Rows.Count == 0)
                return null;
            else
                return ListF;
        }


        public void UpdateV2( LigneFacture NewLine)
        {
            MySqlCommand = new SqlCommand(" UPDATE [LigneFacture] SET  Reference= @articles_ref ,   Pu= @articles_prix ,  Quantite = @articles_quant where Reference=@Ref");

            MySqlCommand.Parameters.Add("@articles_ref", SqlDbType.VarChar).Value = Convert.ToString(NewLine.RefProp);
            MySqlCommand.Parameters.Add("@articles_prix", SqlDbType.Float).Value = Convert.ToDouble(NewLine.PrixUProp);
            MySqlCommand.Parameters.Add("@articles_quant", SqlDbType.Int).Value = Convert.ToInt32(NewLine.QuantProp);
            MySqlCommand.Parameters.Add("@Ref", SqlDbType.VarChar).Value = Convert.ToString(NewLine.RefProp);


            Connexion.FunctionToWrite(MySqlCommand);

        }

        public void UpdateFacture( LigneFacture ListF )
        {
            MessageBox.Show("Zqkjjkk");

            SqlCommand MySqlCommand = new SqlCommand(" UPDATE [Facture] SET   Montant=@Facture_Montant,Date=@Facture_Date  where Reference=@Facture_ref");
            MySqlCommand.Parameters.Add("@Facture_ref", SqlDbType.VarChar).Value = Convert.ToString(ListF.RefFProp);
            MySqlCommand.Parameters.Add("@Facture_Montant", SqlDbType.Int).Value = ListF.MontantProp;
            MySqlCommand.Parameters.Add("@Facture_Date", SqlDbType.Date).Value = Convert.ToDateTime(ListF.DateProp);

            Connexion.FunctionToWrite(MySqlCommand);

            MySqlCommand = new SqlCommand("insert into [LigneFacture](IdFacture, IdArticle, Reference , Pu, Quantite) values(@FactureId, @ArticleId, @articles_ref,  @articles_prix,  @articles_quant)");

            MySqlCommand.Parameters.Add("@articles_ref", SqlDbType.VarChar).Value = Convert.ToString(ListF.RefProp);
            MySqlCommand.Parameters.Add("@articles_prix", SqlDbType.Float).Value = Convert.ToDouble(ListF.PrixUProp);
            MySqlCommand.Parameters.Add("@articles_quant", SqlDbType.Int).Value = Convert.ToInt32(ListF.QuantProp);
            MySqlCommand.Parameters.Add("@ArticleId", SqlDbType.Int).Value = Convert.ToInt32(ListF.IdArtProp);
            MySqlCommand.Parameters.Add("@FactureId", SqlDbType.Int).Value = Convert.ToInt32(GetFactureId(ListF.RefFProp)); 
            Connexion.FunctionToWrite(MySqlCommand);


           
            MessageBox.Show("ouuui");


        }
         
          

        public void DeleteFacture(string del)
        {

            MySqlCommand = new SqlCommand("DELETE FROM [Facture] WHERE Reference = @Rdel");

            MySqlCommand.Parameters.Add("@Rdel", SqlDbType.VarChar).Value = del;

            Connexion.FunctionToWrite(MySqlCommand);
        }

        public void DeleteFact(Facture fac)
        {
            Article Artic;
            MySqlCommand = new SqlCommand("DELETE FROM [Facture] WHERE Reference = @Rdel");

            MySqlCommand.Parameters.Add("@Rdel", SqlDbType.VarChar).Value = fac.RefProp;
            foreach(LigneFacture ListLf in fac.ListLgFacture)
            {
                 
                    DataTable MyDat = new DALArticle().SelectByRef(fac.RefProp);
                Artic = new Article(ListLf.RefProp, MyDat.Rows[0]["Designation"].ToString(), float.Parse(MyDat.Rows[0]["Prix"].ToString()), Convert.ToBoolean(MyDat.Rows[0]["Promo"].ToString())
                   , MyDat.Rows[0]["DateInPromo"].ToString(), Int32.Parse(MyDat.Rows[0]["Quantite"].ToString()) + ListLf.QuantProp);
                new DALArticle().Update(ListLf.RefProp, Artic);
                 
            }
           
            Connexion.FunctionToWrite(MySqlCommand);
        }


    }
}
