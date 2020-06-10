using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArticleApp
{
    class MiseEnforme
    {

        public static List<Facture> AllFacturesList = null;
        public static List<LigneFacture> AllLigneFacturesList = null;
        public static List<Article> AllArticlesList = null;
        public static DataTable InitialiseDataGridFacture(DataTable CurrentDataTableFacture)
        {
            try
            {
                DataColumn ColumnFacture = new DataColumn();

                ColumnFacture = new DataColumn();
                ColumnFacture.DataType = System.Type.GetType("System.String");
                ColumnFacture.ColumnName = "Référence";
                ColumnFacture.ReadOnly = true;
                ColumnFacture.Unique = false;
                // Add the Column to the DataColumnCollection.
                CurrentDataTableFacture.Columns.Add(ColumnFacture);

                ColumnFacture = new DataColumn();
                ColumnFacture.DataType = System.Type.GetType("System.String");
                ColumnFacture.ColumnName = "Montant";
                ColumnFacture.ReadOnly = true;
                ColumnFacture.Unique = false;
                // Add the Column to the DataColumnCollection.
                CurrentDataTableFacture.Columns.Add(ColumnFacture);

                ColumnFacture = new DataColumn();
                ColumnFacture.DataType = System.Type.GetType("System.DateTime");
                ColumnFacture.ColumnName = "Date";
                ColumnFacture.ReadOnly = true;
                ColumnFacture.Unique = false;
                // Add the Column to the DataColumnCollection.
                CurrentDataTableFacture.Columns.Add(ColumnFacture);
                  
            }
            
            catch(Exception e)
            {

            }
                return CurrentDataTableFacture;
             
        }
        public static DataTable AdaptDataTableFacture(DataTable CurrentDataTable)
        {

            AllFacturesList = new List<Facture>();
            DataTable Datatable = new DataTable();

            Datatable = InitialiseDataGridFacture(Datatable);

            //Get All The Rows Of The First DataTable
            foreach (DataRow row in CurrentDataTable.Rows)
            {
                int Montant=0;
                 
                string Reff = (row["Reference"].ToString().Length != 0) ? row["Reference"].ToString() : "pas de Reference";

                string Date = (row["Date"].ToString().Length != 0) ? row["Date"].ToString() : "pas de date";
                DateTime DateFacturation = DateTime.MinValue;

                Montant = Int32.Parse(row["Montant"].ToString());
                if (Date != null)
                {
                    DateFacturation = DateTime.Parse(Date);

                }
                Facture CurrentFacture = new Facture(Reff, Montant,DateFacturation);
                Datatable.Rows.Add(
                        Reff,
                        Montant,
                        DateFacturation
                    );
                AllFacturesList.Add(CurrentFacture);
            }

            return Datatable;
        }

        public static DataTable AdaptDataTableFacture(List<Facture> Fact)
        {

            AllFacturesList = new List<Facture>();
            DataTable Datatable = new DataTable();

            Datatable = InitialiseDataGridFacture(Datatable);

            //Get All The Rows Of The First DataTable
            foreach (Facture row in Fact)
            {
                float Montant = 0;

                string Reff = row.RefProp;

                string Date = row.DateProp.ToShortDateString();
                DateTime DateFacturation = DateTime.MinValue;

                Montant = row.MontantProp;
                if (Date != null)
                {
                    DateFacturation = DateTime.Parse(Date);

                }
                Facture CurrentFacture = new Facture(Reff, Montant, DateFacturation);
                Datatable.Rows.Add(
                        Reff,
                        Montant,
                        DateFacturation
                    );
                AllFacturesList.Add(CurrentFacture);
            }

            return Datatable;
        }

        public static DataTable InitialiseDataGridLigneFacture(DataTable CurrentDataTableLigneFacture)
        {
            try
            {
                DataColumn ColumnLigneFacture = new DataColumn();

            
                ColumnLigneFacture = new DataColumn();
                ColumnLigneFacture.DataType = System.Type.GetType("System.String");
                ColumnLigneFacture.ColumnName = "Référence";
                ColumnLigneFacture.ReadOnly = true;
                ColumnLigneFacture.Unique = false;
                // Add the Column to the DataColumnCollection.
                CurrentDataTableLigneFacture.Columns.Add(ColumnLigneFacture);

                ColumnLigneFacture = new DataColumn();
                ColumnLigneFacture.DataType = System.Type.GetType("System.String");
                ColumnLigneFacture.ColumnName = "Prix unitaire";
                ColumnLigneFacture.ReadOnly = true;
                ColumnLigneFacture.Unique = false;
                // Add the Column to the DataColumnCollection.
                CurrentDataTableLigneFacture.Columns.Add(ColumnLigneFacture);

                ColumnLigneFacture = new DataColumn();
                ColumnLigneFacture.DataType = System.Type.GetType("System.String");
                ColumnLigneFacture.ColumnName = "Quantité";
                ColumnLigneFacture.ReadOnly = true;
                ColumnLigneFacture.Unique = false;
                // Add the Column to the DataColumnCollection.
                CurrentDataTableLigneFacture.Columns.Add(ColumnLigneFacture);
            }catch(Exception e)
            {

            }
           

            return CurrentDataTableLigneFacture;


        }
        public static DataTable AdaptDataTableLigneFacture(DataTable CurrentDataTable)
        { 
            DataTable Datatable = new DataTable();
            Datatable = InitialiseDataGridLigneFacture(Datatable);
            AllLigneFacturesList = new List<LigneFacture>();
            //Get All The Rows Of The First DataTable
            foreach (DataRow row in CurrentDataTable.Rows)
            {

                LigneFacture CurrentLigneFacture= new LigneFacture();
                 
                string Reff = (row["Reference"].ToString().Length != 0) ? row["Reference"].ToString() : "pas de référence";
                float Pu = float.Parse(row["Pu"].ToString());
                int Quantite = Int32.Parse(row["Quantite"].ToString());
                CurrentLigneFacture = new LigneFacture(Reff, Pu,Quantite);
                Datatable.Rows.Add(
                    Reff,
                    Pu,
                    Quantite
                );
                AllLigneFacturesList.Add(CurrentLigneFacture);
            }

            return Datatable;
        }

        public static DataTable AdaptDataTableLigneFacture(List<LigneFacture> Lf)
        {
            DataTable Datatable = new DataTable();
            Datatable = InitialiseDataGridLigneFacture(Datatable);
            AllLigneFacturesList = new List<LigneFacture>();
            //Get All The Rows Of The First DataTable
            foreach (LigneFacture row in Lf)
            {

                LigneFacture CurrentLigneFacture = new LigneFacture();

                string Reff = row.RefProp;
                float Pu =row.PrixUProp;
                int Quantite = row.QuantProp;
                CurrentLigneFacture = new LigneFacture(Reff, Pu, Quantite);
                Datatable.Rows.Add(
                    Reff,
                    Pu,
                    Quantite
                );
                AllLigneFacturesList.Add(CurrentLigneFacture);
            }

            return Datatable;
        }

        public static DataTable InitialiseDataGridArticle(DataTable CurrentDataTableArticle)
        {
            try
            {
                DataColumn ColumnArticle = new DataColumn();


                ColumnArticle = new DataColumn();
                ColumnArticle.DataType = System.Type.GetType("System.String");
                ColumnArticle.ColumnName = "Référence";
                ColumnArticle.ReadOnly = true;
                ColumnArticle.Unique = false;
                // Add the Column to the DataColumnCollection.
                CurrentDataTableArticle.Columns.Add(ColumnArticle);

                ColumnArticle = new DataColumn();
                ColumnArticle.DataType = System.Type.GetType("System.String");
                ColumnArticle.ColumnName = "Désignation";
                ColumnArticle.ReadOnly = true;
                ColumnArticle.Unique = false;
                // Add the Column to the DataColumnCollection.
                CurrentDataTableArticle.Columns.Add(ColumnArticle);

                ColumnArticle = new DataColumn();
                ColumnArticle.DataType = System.Type.GetType("System.String");
                ColumnArticle.ColumnName = "Prix unitaire";
                ColumnArticle.ReadOnly = true;
                ColumnArticle.Unique = false;
                // Add the Column to the DataColumnCollection.
                CurrentDataTableArticle.Columns.Add(ColumnArticle);

                ColumnArticle = new DataColumn();
                ColumnArticle.DataType = System.Type.GetType("System.String");
                ColumnArticle.ColumnName = "Quantité";
                ColumnArticle.ReadOnly = true;
                ColumnArticle.Unique = false;
                // Add the Column to the DataColumnCollection.
                CurrentDataTableArticle.Columns.Add(ColumnArticle);

                ColumnArticle = new DataColumn();
                ColumnArticle.DataType = System.Type.GetType("System.Boolean");
                ColumnArticle.ColumnName = "En promo";
                ColumnArticle.ReadOnly = false;
                ColumnArticle.Unique = false;
                // Add the Column to the DataColumnCollection.
                CurrentDataTableArticle.Columns.Add(ColumnArticle);

                ColumnArticle = new DataColumn();
                ColumnArticle.DataType = System.Type.GetType("System.DateTime");
                ColumnArticle.ColumnName = "Date en promo";
                ColumnArticle.ReadOnly = true;
                ColumnArticle.Unique = false;
                // Add the Column to the DataColumnCollection.

                CurrentDataTableArticle.Columns.Add(ColumnArticle);

            }
            catch (Exception e)
            {

            }
            
            return CurrentDataTableArticle;


        }
        public static DataTable AdaptDataTableArticle(DataTable CurrentDataTable)
        {
            DataTable Datatable = new DataTable();
            AllArticlesList = new List<Article>();
            Datatable = InitialiseDataGridArticle(Datatable);

            //Get All The Rows Of The First DataTable
            foreach (DataRow row in CurrentDataTable.Rows)
            { 
                string Reff = (row["Reference"].ToString().Length != 0) ? row["Reference"].ToString() : "pas de référence";
                string Desi = (row["Designation"].ToString().Length != 0) ? row["Designation"].ToString() : "pas de désignation";
                float Pu = float.Parse(row["Prix"].ToString());
                int Quantite = Int32.Parse(row["Quantite"].ToString());
                bool Promo = Convert.ToBoolean(row["Promo"].ToString());
                string Date = (row["DateInPromo"].ToString().Length != 0) ? row["DateInPromo"].ToString() : "pas de date";
                DateTime DateInpromo = DateTime.MinValue; 
                if (Date != null)
                {
                    DateInpromo = DateTime.Parse(Date);

                }
                Article CurrentArticle = new Article(Reff, Desi, Pu,Promo,DateInpromo.ToString(),Quantite);
                Datatable.Rows.Add(
                    Reff,
                    Desi,
                    Pu,
                    Quantite,
                    Promo,
                    DateInpromo
                );
                AllArticlesList.Add(CurrentArticle);
            }

            return Datatable;
        }
    }
}
