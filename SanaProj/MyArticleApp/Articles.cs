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
    public partial class Articles : MetroFramework.Forms.MetroForm
    {
        DALArticle MyArticleDal = new DALArticle();
        private DataTable dt;
        public static DataTable CurrentDataTableArticle = new DataTable();

        DataTable CurrentDataTableArticleInit = new DataTable();
        private Article CurrentArticle = null;
        public Articles()
        {
            InitializeComponent();
            dt = new DataTable();
        }

        private void Btn_Nouveau_Click(object sender, EventArgs e)
        {
            AjouterArticle Insert = new AjouterArticle();

            if (Insert.ShowDialog() == DialogResult.OK)
            {
                FillDtgListeArticle();
            }

            if (Insert.DialogResult != DialogResult.None)
                FillDtgListeArticle();
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
            ModifierArticle Edit = new ModifierArticle(currentDataRowView);
            if (Edit.ShowDialog() == DialogResult.OK)
            {
                FillDtgListeArticle();
            }

            if (Edit.DialogResult != DialogResult.None)
                FillDtgListeArticle();
        }


        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView currentDataRowView = (DataRowView)dataGridView1.CurrentRow.DataBoundItem;
                MyArticleDal.Delete(currentDataRowView.Row[0].ToString());
                FillDtgListeArticle();
                MessageBox.Show("Suppression réuissie", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch(Exception ex)  
            {
                MessageBox.Show("Suppression impossible, article lié à une facture", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
            
        }

        private void Articles_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = MiseEnforme.InitialiseDataGridArticle(CurrentDataTableArticle);

            FillDtgListeArticle();
        }

        public int FillDtgListeArticle()
        {

            CurrentDataTableArticle = new DALArticle().GetAllArticles();
            CurrentDataTableArticleInit = CurrentDataTableArticle;

            CurrentDataTableArticle = MiseEnforme.AdaptDataTableArticle(CurrentDataTableArticle);
            dataGridView1.DataSource = CurrentDataTableArticle;
            if (CurrentDataTableArticle.Rows.Count == 0)
            {
                Btn_Modifier.Enabled = false;
                Btn_Supprimer.Enabled = false;
            }
            else
            {
                Btn_Modifier.Enabled = true;
                Btn_Supprimer.Enabled = true;
            }
            return CurrentDataTableArticle.Rows.Count;
        }

       

        private void Txt_Search_TextChanged(object sender, EventArgs e)
        {
             
                if (string.IsNullOrEmpty(Txt_Search.Text.Trim()))
                {
                    FillDtgListeArticle();
                }
                else
                {
                    List<Article> ListeArticle = new List<Article>();
                    ListeArticle = MyArticleDal.GetArticleList();
                     
                        var query = from o in ListeArticle
                                    where o.RefProp.Contains(Txt_Search.Text) || o.DesiProp.Contains(Txt_Search.Text)
                                    select o;
                        dataGridView1.DataSource = query.ToList();
                    }
                
        }
    }
}
