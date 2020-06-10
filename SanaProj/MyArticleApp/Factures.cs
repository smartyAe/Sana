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
    public partial class Factures : MetroFramework.Forms.MetroForm
    {
        public static DataTable CurrentDataTableFacture = new DataTable();
        public static DataTable CurrentDataTableLigneFactures = new DataTable();

        public static bool Recording = false; 
        DataTable CurrentDataTableFactureInit = new DataTable();
        DataTable CurrentDataTableLigneFacturesInit = new DataTable();
        private Facture CurrentFacture = null;
        private int CurrentIndex = 0;
        public static bool NouvF=false;
        private LigneFacture CurrentFactureLine;
        private string CurrentRefFacture = "";
        DalFacture DalFac = null;
        private bool Suppression=false;
        DalFacture MyDALFacture = new DalFacture();
        public Factures()
        {
            InitializeComponent();
            Recording = false;
            DalFac = new DalFacture();
        }

        private void Btn_NouvelleFacture_Click(object sender, EventArgs e)
        {
             
               Reference reff = new Reference();
                var res=reff.ShowDialog();
            if (res == DialogResult.Cancel)
            {
                FillDtgListeFacture();
            }

        }


       

        public void DataLoading()
        {

            if (DtgListeFactures.SelectedCells.Count > 0)
            {
                int IndexRowSelected = DtgListeFactures.SelectedCells[0].RowIndex;
                DataGridViewRow SelectedRow = DtgListeFactures.Rows[IndexRowSelected];

                if (SelectedRow.Cells["Référence"].Value != null
                    && SelectedRow.Cells["Référence"].Value.ToString().Trim().Length != 0
                    && IndexRowSelected < new DalFacture().GetAllFacture().Rows.Count)
                {
                    CurrentIndex = IndexRowSelected;
                    CurrentFacture = MiseEnforme.AllFacturesList[IndexRowSelected];

                    //Initialisation(CurrentFacture);
                }
                else
                {
                    CurrentFacture = null;
                    //Initialisation(null);
                }
            }
            else
            {
                CurrentFacture = null;
                //Initialisation(null);
            }
        }

       
        public int FillDtgListeFacture()
        {
           
             
                CurrentDataTableFacture = new DalFacture().GetAllFacture();
                CurrentDataTableFactureInit = CurrentDataTableFacture;
                CurrentDataTableFacture = MiseEnforme.AdaptDataTableFacture(CurrentDataTableFacture);
                
                DtgListeFactures.DataSource = CurrentDataTableFacture;
                 
            if(CurrentDataTableFacture.Rows.Count==0)
            {
                Btn_SuppF.Enabled = false;
                Btn_consulter.Enabled = false; 
                Btn_Imprimer.Enabled = false;
                 
            }
            else
            {
                Btn_SuppF.Enabled = true;
                Btn_consulter.Enabled = true;
                Btn_Imprimer.Enabled = true;
                
            }
            return CurrentDataTableFacture.Rows.Count;
        }
        
        private void Factures_Load(object sender, EventArgs e)
        {
            DtgListeFactures.DataSource = MiseEnforme.InitialiseDataGridFacture(CurrentDataTableFacture);
              FillDtgListeFacture();
             
        }

        

        private void Btn_SuppF_Click(object sender, EventArgs e)
        {
             
                
                DataRowView currentDataRowView = (DataRowView)DtgListeFactures.CurrentRow.DataBoundItem;
                MyDALFacture.DeleteFacture(currentDataRowView.Row[0].ToString());

                FillDtgListeFacture();

                MessageBox.Show("Suppression réuissie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
        }

         

        private void Btn_Imprimer_Click(object sender, EventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)DtgListeFactures.CurrentRow.DataBoundItem;
            Impression.FillReportFacture(currentDataRowView.Row[0].ToString());
        }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            DetailFacture Df = new DetailFacture();
            Df.ShowDialog();
        }

        private void Btn_consulter_Click(object sender, EventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)DtgListeFactures.CurrentRow.DataBoundItem;
            DetailFacture Df = new DetailFacture(MyDALFacture.GetFactureByRef(currentDataRowView.Row[0].ToString()) );
            var result = Df.ShowDialog();
            if(result==DialogResult.Cancel)
            {
                FillDtgListeFacture();
            }
        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(TxtSearch.Text.Trim()))
                {
                    FillDtgListeFacture();
                }
                else
                {
                    List<Facture> Listefacture = new List<Facture>();
                    Listefacture = MyDALFacture.GetFactureList();

                    var query = from o in Listefacture
                                where o.RefProp.Contains(TxtSearch.Text) || o.MontantProp == float.Parse(TxtSearch.Text)
                                select o;
                    DtgListeFactures.DataSource = MiseEnforme.AdaptDataTableFacture( query.ToList());
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Caractères invalide !!");
            }
            
        }
    }
}
