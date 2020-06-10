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
    public partial class AjouterLineFacture : MetroFramework.Forms.MetroForm
    {
        public static string reff;
        private Facture fact;
        DalFacture MyFactureDal = new DalFacture(); 
        private bool exist=false;
        public static bool click=false;
        private bool existLine = false;
        private int QuantiteInit = 0;

        public LigneFacture CurrentLg { get; set; }
        public AjouterLineFacture(Facture Fac)
        {
            InitializeComponent();
            fact = Fac;
            Txt_RefFac.Text = Fac.RefProp;
        }
        public AjouterLineFacture(DataRowView currentDataRowViewF)
        {
            InitializeComponent();
             reff = currentDataRowViewF.Row[0].ToString();
            Txt_RefFac.Text = currentDataRowViewF.Row[0].ToString();
            if (!reff.Equals("A modifier"))
                Txt_RefFac.Enabled = false;
            exist = false;
            existLine = false;
            
        }

        private void Btn_Ajouter_Click(object sender, EventArgs e)
        {
 
            try
            {
                if (string.IsNullOrEmpty(Txt_RefFac.Text)  || string.IsNullOrEmpty(Txt_Quant.Text) || string.IsNullOrEmpty(Cbx_Ref.SelectedItem.ToString()))
                {
                    MessageBox.Show("Une ou plusieurs entrées invalides", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Int32.Parse(Txt_Quant.Text.ToString())> QuantiteInit)
                {
                    MessageBox.Show("Quantité disponible est "+QuantiteInit+" !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    LigneFacture Lg = new LigneFacture(Cbx_Ref.SelectedItem.ToString() ,float.Parse(Txt_Prix.Text), Int32.Parse(Txt_Quant.Text));
                    CurrentLg = Lg;
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }


 
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
             
        }

        private void AjouterLineFacture_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
             dt =new DALArticle().GetAllArticles();

            for (int i = 0; i < dt.Rows.Count; i++)
            {
                this.Cbx_Ref.Items.Add(dt.Rows[i]["Reference"]);
            }
        }

        private void Cbx_Ref_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_Prix.Text = new DALArticle().SelectByRef(Cbx_Ref.SelectedItem.ToString()).Rows[0]["Prix"].ToString();
            QuantiteInit=    Int32.Parse(new DALArticle().SelectByRef(Cbx_Ref.SelectedItem.ToString()).Rows[0]["Quantite"].ToString());
            Txt_Quant.Text=new DALArticle().SelectByRef(Cbx_Ref.SelectedItem.ToString()).Rows[0]["Quantite"].ToString();

        }

        private void AjouterLineFacture_Shown(object sender, EventArgs e)
        {
             
        }

        private void AjouterLineFacture_FormClosing(object sender, FormClosingEventArgs e)
        {
             
            
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
