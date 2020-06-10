using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArticleApp
{
    public class LigneFacture
    {
        private int IdArt;

        private int Montant;
        public int MontantProp
        {
            get { return Montant; }
            set { Montant = value; }
        }
        public int IdArtProp
        {
            get { return IdArt; }
            set { IdArt = value; }
        }
        private int IdFact;

        public int IdFactProp
        {
            get { return IdFact; }
            set { IdFact = value; }
        }
        private string Ref;

        public string RefProp
        {
            get { return Ref; }
            set { Ref = value; }
        }
        private DateTime Date;
        public DateTime DateProp
        {
            get { return Date; }
            set { Date = value; }
        }

        private string RefF;

        public string RefFProp
        {
            get { return RefF; }
            set { RefF = value; }
        }

        private float PrixU;
        public float PrixUProp
        {
            get { return PrixU; }
            set { PrixU = value; }
        }

        private int Quantite;
        public int QuantProp
        {
            get { return Quantite; }
            set { Quantite = value; }
        }
        private int QuantiteMax;
        public int QuantPropMax
        {
            get { return Quantite; }
            set { Quantite = value; }
        }

        public LigneFacture(string reff, float pu, int quantite)
        {
            this.Ref = reff;
            this.PrixU = pu;
            this.Quantite = quantite;
        }
        public LigneFacture(string reff )
        {
            this.RefF = reff;
             
        }

        public LigneFacture()
        {
        }
    }
}
