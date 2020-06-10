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
    public partial class DetailFacture : MetroFramework.Forms.MetroForm
    {
        public static DataTable CurrentDataTableLigneFactures = new DataTable();
        private Facture Fac;
        DalFacture MyFactureDal = new DalFacture();
         bool IsNew=false; 
        public DetailFacture(string reference)
        {
            InitializeComponent();
            Fac = new Facture(reference,0,DateTime.Now);
            Lb_Ref.Text = reference;
            Dtp_DateFacture.Value  = Fac.DateProp ;
            Lb_Mont.Text = Fac.MontantProp.ToString();
             
            FillDtgListeLigneFactures(reference);
        }

        public DetailFacture( )
        {
            InitializeComponent();
            FillDtgListeLigneFactures(Fac.RefProp);
        }
        public DetailFacture(Facture fact )
        {
            Fac = fact;

            InitializeComponent();
            Lb_Ref.Text = fact.RefProp;
            Dtp_DateFacture.Value = Fac.DateProp;
            Lb_Mont.Text = Fac.MontantProp.ToString();
            FillDtgListeLigneFactures(fact.RefProp);

        }

        private void Btn_Enregistrer_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable Mydata = MyFactureDal.GetAllFacture();
                foreach(DataRow dr in Mydata.Rows)
                {
                    if (dr["Reference"].ToString() == Fac.RefProp)
                    {
                        IsNew = false;
                        break;
                    }
                }

                Fac.CalculerMontatnt();
                if ( IsNew == true || Mydata.Rows.Count==0)
                {
                    MyFactureDal.AddByList(Fac);
                    IsNew = false;
                }
                else  
                {
                    MyFactureDal.DeleteFact(Fac );
                    MyFactureDal.AddByList(Fac);
                    IsNew = false;

                }
                
                
                MessageBox.Show("Facture mise à jour !");
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }

        }

        private void Btn_AjouterLgFacture_Click(object sender, EventArgs e)
        { 
            AjouterLineFacture AjoutLF = new AjouterLineFacture(Fac  );
            
            var result = AjoutLF.ShowDialog();
             
            if (result == DialogResult.OK)
            {
                LigneFacture NewLg = AjoutLF.CurrentLg;
                int qte=0;
                foreach (DataRow row in CurrentDataTableLigneFactures.Rows)
                {

                    if (row["Référence"].ToString() == AjoutLF.CurrentLg.RefProp)
                    {
                        NewLg.QuantProp = Int32.Parse(row["Quantité"].ToString()) + NewLg.QuantProp;
                        qte = Int32.Parse(row["Quantité"].ToString());
                        CurrentDataTableLigneFactures.Rows.Remove(row);
                        foreach(LigneFacture lf in Fac.ListLgFacture)
                        {
                            if(lf.RefProp==NewLg.RefProp)
                            {
                                Fac.ListLgFacture.Remove(lf);
                                break;
                            }
                        }
                        break;
                    }

                }
                 
                Fac.ListLgFacture.Add(NewLg);
                 
                if (Lb_Mont.Text == "Pas de Montant")
                {
                    Lb_Mont.Text = (NewLg.PrixUProp * NewLg.QuantProp).ToString();
                }
                else

                {

                    Lb_Mont.Text = ( Int32.Parse(Lb_Mont.Text) + NewLg.PrixUProp * NewLg.QuantProp - qte* NewLg.PrixUProp).ToString();
                }
                CurrentDataTableLigneFactures.Rows.Add(
                         NewLg.RefProp,
                         NewLg.PrixUProp,
                         NewLg.QuantProp 
                         
                     );
               

                DtgListeLigneFacture.DataSource = CurrentDataTableLigneFactures;
                Btn_Modifier.Enabled = true;
                Btn_SupprimerLF.Enabled = true;
                Btn_Enregistrer.Enabled = true;
                }

            }

        private void Btn_Modifier_Click(object sender, EventArgs e)
        {
            DataRowView currentDataRowView = (DataRowView)DtgListeLigneFacture.CurrentRow.DataBoundItem;
            ModifierLingeFacture MF = new ModifierLingeFacture(currentDataRowView);

            var result = MF.ShowDialog();

            if (result == DialogResult.OK)
            {
                LigneFacture NewLg = MF.CurrentLg;
                int qte = 0;
                foreach (DataRow row in CurrentDataTableLigneFactures.Rows)
                {

                    if (row["Référence"].ToString() == MF.CurrentLg.RefProp)
                    {
                        NewLg.QuantProp = Int32.Parse(row["Quantité"].ToString()) + NewLg.QuantProp;
                        qte = Int32.Parse(row["Quantité"].ToString());
                        CurrentDataTableLigneFactures.Rows.Remove(row);
                        foreach (LigneFacture lf in Fac.ListLgFacture)
                        {
                            if (lf.RefProp == NewLg.RefProp)
                            {
                                Fac.ListLgFacture.Remove(lf);
                                break;
                            }
                        }
                        break;
                    }

                }
                Fac.ListLgFacture.Add(NewLg);
                 
                Lb_Mont.Text = (Int32.Parse(Lb_Mont.Text) + NewLg.PrixUProp * NewLg.QuantProp - qte * NewLg.PrixUProp).ToString();
                 
                CurrentDataTableLigneFactures.Rows.Add(
                         NewLg.RefProp,
                         NewLg.PrixUProp,
                         NewLg.QuantProp

                     );

            }
        }

        private void Btn_SupprimerLF_Click(object sender, EventArgs e)
        {
            int IndexRowSelected = DtgListeLigneFacture.SelectedCells[0].RowIndex;
            DataGridViewRow SelectedRow = DtgListeLigneFacture.Rows[IndexRowSelected];
            DataRowView currentDataRowView = (DataRowView)DtgListeLigneFacture.CurrentRow.DataBoundItem;
           
            DialogResult Result = MessageBox.Show("Voulez vous supprimer?", "Confirmation de suppression", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Information);

            if (Result == DialogResult.Yes)
            {
                Lb_Mont.Text = (Int32.Parse(Lb_Mont.Text) - (float.Parse(currentDataRowView.Row[1].ToString()) * Int32.Parse(currentDataRowView.Row[2].ToString()))).ToString();
                int qte = 0;
                foreach (DataRow row in CurrentDataTableLigneFactures.Rows)
                {

                    if (row["Référence"].ToString() == currentDataRowView.Row[0].ToString())
                    {
                         
                        qte = Int32.Parse(row["Quantité"].ToString()); 
                        foreach (LigneFacture lf in Fac.ListLgFacture)
                        {
                            if (lf.RefProp == currentDataRowView.Row[0].ToString())
                            {
                                Fac.ListLgFacture.Remove(lf);
                                IsNew = false;
                                break;
                            }
                        }
                        break;
                    }

                }
                CurrentDataTableLigneFactures.Rows.RemoveAt(IndexRowSelected);
                DtgListeLigneFacture.DataSource = CurrentDataTableLigneFactures;

                if (CurrentDataTableLigneFactures.Rows.Count == 0)
                {

                    Btn_SupprimerLF.Enabled = false;
                    Btn_Modifier.Enabled = false;

                }
                MessageBox.Show("Suppression réuissie", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        public void FillDtgListeLigneFactures(string RefFacture)
        {

            CurrentDataTableLigneFactures = new DalFacture().GetLigneFacturesByFacture(RefFacture);
             
            CurrentDataTableLigneFactures = MiseEnforme.AdaptDataTableLigneFacture(CurrentDataTableLigneFactures);
            if (CurrentDataTableLigneFactures.Rows.Count == 0)
            {
                 
                Btn_Modifier.Enabled = false;
                Btn_Enregistrer.Enabled = false;
                Btn_SupprimerLF.Enabled = false;
                 
            }
            else
            {
                 
                Btn_Modifier.Enabled = true;
                Btn_Enregistrer.Enabled = true;
                Btn_SupprimerLF.Enabled = true;
                  
            }
            DtgListeLigneFacture.DataSource = CurrentDataTableLigneFactures;

        }

        private void DetailFacture_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
             
        }

        private void DetailFacture_Load(object sender, EventArgs e)
        {

        }

        private void TxtSearch_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtSearch.Text.Trim()))
            {
                FillDtgListeLigneFactures(Fac.RefProp);
            }
            else
            {
                List<LigneFacture> Listefacture = new List<LigneFacture>();
                Listefacture = MyFactureDal.GetLigneFacturesList(Fac.RefProp);

                var query = from o in Listefacture 
                            where o.RefProp.Contains(TxtSearch.Text) || o.PrixUProp >= float.Parse(TxtSearch.Text)
                                    || o.QuantProp>= Int32.Parse(TxtSearch.Text)
                            select o;
                DtgListeLigneFacture.DataSource =MiseEnforme.AdaptDataTableLigneFacture( query.ToList());
            }
        }
    }
}
