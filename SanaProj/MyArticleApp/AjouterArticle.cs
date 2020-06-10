using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyArticleApp
{
    public partial class AjouterArticle : MetroFramework.Forms.MetroForm
    {
         
        private Article Art;
        private DALArticle DalArt;
        public AjouterArticle()
        {
            InitializeComponent();
            Art = new Article();
            DalArt = new DALArticle();
        }
        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {

                if (string.IsNullOrEmpty(Txt_Reference.Text) || string.IsNullOrEmpty(Txt_Designation.Text)
                    || string.IsNullOrEmpty(Txt_Quantite.Text))
                {
                    MessageBox.Show("Une ou plusieurs entrées invalides", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (DalArt.CheckUniqueRef(Txt_Reference.Text.ToString()) == false)
                {

                    MessageBox.Show("La référence est déjà utilisée", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else
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


                    DalArt.Add(Art);
                    foreach (var Txt_Box in this.Gpb_Add.Controls.OfType<TextBox>())
                    {
                        Txt_Box.Clear();
                    }
                    DateP_DateInPromo.ResetText();
                    MessageBox.Show("Ajouté avec succès", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
