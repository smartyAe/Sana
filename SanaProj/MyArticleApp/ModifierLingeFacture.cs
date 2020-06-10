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
    public partial class ModifierLingeFacture : MetroFramework.Forms.MetroForm
    {
        string fatherRef;
        DalFacture MyDal = new DalFacture();
        DataTable dxt = new DataTable();
        public LigneFacture CurrentLg { get; set; }
        DataRowView currentDataRowView;
        private int QuantiteInit = 0;

        public ModifierLingeFacture(DataRowView currentDataRowView )
        {
            InitializeComponent();
            this.Cbx_Ref.Text = currentDataRowView.Row[0].ToString();
            this.Txt_Prix.Text = currentDataRowView.Row[1].ToString();
            this.Txt_Quant.Text = currentDataRowView.Row[2].ToString(); 
             
            this.currentDataRowView= currentDataRowView;
            

        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                QuantiteInit = Int32.Parse(new DALArticle().SelectByRef(Cbx_Ref.Text.ToString()).Rows[0]["Quantite"].ToString());
                if ( string.IsNullOrEmpty(Txt_Quant.Text) )
                {
                    MessageBox.Show("Une ou plusieurs entrées invalides", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (Int32.Parse(Txt_Quant.Text.ToString()) > QuantiteInit)
                {
                    MessageBox.Show("Quantité disponible est " + QuantiteInit + " !!!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {

                    int qte = Int32.Parse(Txt_Quant.Text) - Int32.Parse(currentDataRowView.Row[2].ToString());
                    LigneFacture Lg = new LigneFacture(Cbx_Ref.Text.ToString(), float.Parse(Txt_Prix.Text), qte);
                    CurrentLg = Lg;
                    
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }



            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
