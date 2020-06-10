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
    public partial class FormAcc : MetroFramework.Forms.MetroForm
    {
        public FormAcc()
        {
            InitializeComponent();
        }

        private void Btn_Facture_Click(object sender, EventArgs e)
        {
            Factures FactureView = new Factures();
            FactureView.ShowDialog();
        }

        private void Btn_Article_Click(object sender, EventArgs e)
        {
            Articles ArticleView = new Articles();
            ArticleView.ShowDialog(); 
        }
    }
}
