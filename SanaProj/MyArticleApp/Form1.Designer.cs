namespace MyArticleApp
{
    partial class FormAcc
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.Btn_Article = new MetroFramework.Controls.MetroTile();
            this.Btn_Facture = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // Btn_Article
            // 
            this.Btn_Article.ActiveControl = null;
            this.Btn_Article.Location = new System.Drawing.Point(60, 119);
            this.Btn_Article.Name = "Btn_Article";
            this.Btn_Article.Size = new System.Drawing.Size(173, 127);
            this.Btn_Article.TabIndex = 0;
            this.Btn_Article.Text = "Gestion des articles";
            this.Btn_Article.UseSelectable = true;
            this.Btn_Article.Click += new System.EventHandler(this.Btn_Article_Click);
            // 
            // Btn_Facture
            // 
            this.Btn_Facture.ActiveControl = null;
            this.Btn_Facture.Location = new System.Drawing.Point(313, 119);
            this.Btn_Facture.Name = "Btn_Facture";
            this.Btn_Facture.Size = new System.Drawing.Size(173, 127);
            this.Btn_Facture.TabIndex = 1;
            this.Btn_Facture.Text = "Gestion des factures";
            this.Btn_Facture.UseSelectable = true;
            this.Btn_Facture.Click += new System.EventHandler(this.Btn_Facture_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.Location = new System.Drawing.Point(60, 91);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(67, 25);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Articles";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel2.Location = new System.Drawing.Point(313, 91);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(73, 25);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Factures";
            // 
            // FormAcc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 310);
            this.Controls.Add(this.metroLabel2);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.Btn_Facture);
            this.Controls.Add(this.Btn_Article);
            this.Name = "FormAcc";
            this.Text = "Accueil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTile Btn_Article;
        private MetroFramework.Controls.MetroTile Btn_Facture;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
    }
}

