using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyArticleApp
{
    class Article
    {
        private string Ref;

        public string RefProp
        {
            get { return Ref ; }
            set { Ref=value ; }
        }

        private string Designation;
        public string DesiProp
        {
            get { return Designation; }
            set { Designation = value; }
        }

        private float Prix;
        public float PrixProp
        {
            get { return Prix; }
            set { Prix = value; }
        }

        private bool Promo;
        public bool PromoProp
        {
            get { return Promo; }
            set { Promo = value; }
        }

        private string DateInPromo;
        public string DatePromoProp
        {
            get { return DateInPromo; }
            set { DateInPromo = value; }
        }
        private int Quantite;
        public int QuantProp
        {
            get { return Quantite; }
            set { Quantite = value; }
        }

        public Article()
        {
            RefProp = "indéfinie";
            DesiProp = "indéfinie";
            PrixProp = 0 ;
            PromoProp = false;
            DatePromoProp ="01/01/1999";
            QuantProp = 0;

        }

        public Article(string Reference,string Design,float Price, bool Promotion, string DatePromo, int Quant )
        {

            RefProp = Reference;
            DesiProp = Design;
            PrixProp = Price;
            PromoProp = Promotion;
            DatePromoProp = DatePromo;
            QuantProp = Quant;
        }


    }
}
