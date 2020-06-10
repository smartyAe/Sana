using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArticleApp
{
    public class Facture
    {
        private string Ref;
        public string RefProp
        {
            get { return Ref; }
            set { Ref = value; }
        }
        private float Montant;
        public float MontantProp
        {
            get { return Montant; }
            set { Montant = value; }
        }
        private DateTime Date;
        public DateTime DateProp
        {
            get { return Date; }
            set { Date = value; }
        }

        public List<LigneFacture> ListLgFacture = new List<LigneFacture>();
         
        public void CalculerMontatnt()
        {
            this.Montant = 0;
            if (ListLgFacture.Count==0)
            {
                this.Montant = 0;
            }
            else
            {
                foreach (LigneFacture lg in ListLgFacture)
                {
                    this.Montant = Montant + lg.QuantProp * lg.PrixUProp;
                }
            }
           

        }
        public Facture()
        {
        }

        public Facture(string reff,float mont, DateTime date)
        {
            this.Ref = reff;
            this.Date = date;
            this.Montant = mont;
        }
    }
}
