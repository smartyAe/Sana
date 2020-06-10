using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyArticleApp
{
    public partial class ModifierArticle : MetroFramework.Forms.MetroForm
    {
        private Article Old = new Article();
        private Article Art;
        private DALArticle DalArt = new DALArticle();
        public string OldRef;
        public ModifierArticle(DataRowView currentDataRowView)
        {
            InitializeComponent();
             
            OldRef = currentDataRowView.Row[0].ToString();
            Art = new Article(); 

            this.Txt_Reference.Text = currentDataRowView.Row[0].ToString();
            this.Txt_Designation.Text = currentDataRowView.Row[1].ToString();
            this.Txt_Prix.Text = currentDataRowView.Row[2].ToString();
             
            if (currentDataRowView.Row[4].Equals(true))
            {
                this.Ckb_Promo.Checked = true;
            }
            else
            {
                this.Ckb_Promo.Checked = false;
            }

            this.DateP_DateInPromo.Text = currentDataRowView.Row[5].ToString();
            this.Txt_Quantite.Text = currentDataRowView.Row[3].ToString();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {

                Art.RefProp = Txt_Reference.Text;
                Art.DesiProp = Txt_Designation.Text;
                Art.PrixProp = float.Parse(Txt_Prix.Text);
                if (Ckb_Promo.Checked)
                {
                    Art.PromoProp = true;
                }
                else
                {
                    Art.PromoProp = false;
                }

                Art.DatePromoProp = DateP_DateInPromo.Value.ToString();
                Art.QuantProp = Int32.Parse(Txt_Quantite.Text);
                DalArt.Update(OldRef, Art);
                 
                MessageBox.Show("Modification réuissie", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool verificationTextBox(TextBox uneTextBox)
        {
            Regex expressionReguliere = new Regex("^$|^[0 - 9] +$");
            
            //^[0 - 9] +$
            if (expressionReguliere.IsMatch(uneTextBox.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
