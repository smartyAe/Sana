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
    public partial class Reference : MetroFramework.Forms.MetroForm
    {
        DalFacture Dal = new DalFacture();
        public Reference()
        {
            InitializeComponent();
        }

        private void Btn_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_SuivF_Click(object sender, EventArgs e)
        {
            if(Dal.CheckUniqueRef(Txt_RefFac.Text)==false)
            {
                MessageBox.Show("une autre facture porte la même référence ","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DetailFacture Df = new DetailFacture(Txt_RefFac.Text);
                var Res = Df.ShowDialog();

                if (Res == DialogResult.Cancel)
                    this.Close();
            }
           
        }
    }
}
