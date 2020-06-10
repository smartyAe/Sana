namespace MyArticleApp
{
    partial class Factures
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Btn_Imprimer = new System.Windows.Forms.Button();
            this.Btn_NouvelleFacture = new System.Windows.Forms.Button();
            this.Btn_SuppF = new System.Windows.Forms.Button();
            this.LbListeEns = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DtgListeFactures = new System.Windows.Forms.DataGridView();
            this.Btn_consulter = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeFactures)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_consulter);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Btn_Imprimer);
            this.groupBox1.Controls.Add(this.Btn_NouvelleFacture);
            this.groupBox1.Controls.Add(this.Btn_SuppF);
            this.groupBox1.Controls.Add(this.LbListeEns);
            this.groupBox1.Controls.Add(this.TxtSearch);
            this.groupBox1.Controls.Add(this.DtgListeFactures);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 497);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Factures";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Recherche";
            // 
            // Btn_Imprimer
            // 
            this.Btn_Imprimer.Location = new System.Drawing.Point(311, 303);
            this.Btn_Imprimer.Name = "Btn_Imprimer";
            this.Btn_Imprimer.Size = new System.Drawing.Size(136, 44);
            this.Btn_Imprimer.TabIndex = 27;
            this.Btn_Imprimer.Text = "Imprimer";
            this.Btn_Imprimer.UseVisualStyleBackColor = true;
            this.Btn_Imprimer.Click += new System.EventHandler(this.Btn_Imprimer_Click);
            // 
            // Btn_NouvelleFacture
            // 
            this.Btn_NouvelleFacture.Location = new System.Drawing.Point(311, 182);
            this.Btn_NouvelleFacture.Name = "Btn_NouvelleFacture";
            this.Btn_NouvelleFacture.Size = new System.Drawing.Size(136, 44);
            this.Btn_NouvelleFacture.TabIndex = 25;
            this.Btn_NouvelleFacture.Text = "Ajouter";
            this.Btn_NouvelleFacture.UseVisualStyleBackColor = true;
            this.Btn_NouvelleFacture.Click += new System.EventHandler(this.Btn_NouvelleFacture_Click);
            // 
            // Btn_SuppF
            // 
            this.Btn_SuppF.Location = new System.Drawing.Point(311, 243);
            this.Btn_SuppF.Name = "Btn_SuppF";
            this.Btn_SuppF.Size = new System.Drawing.Size(136, 44);
            this.Btn_SuppF.TabIndex = 24;
            this.Btn_SuppF.Text = "Supprimer ";
            this.Btn_SuppF.UseVisualStyleBackColor = true;
            this.Btn_SuppF.Click += new System.EventHandler(this.Btn_SuppF_Click);
            // 
            // LbListeEns
            // 
            this.LbListeEns.AutoSize = true;
            this.LbListeEns.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbListeEns.Location = new System.Drawing.Point(8, 37);
            this.LbListeEns.Name = "LbListeEns";
            this.LbListeEns.Size = new System.Drawing.Size(268, 37);
            this.LbListeEns.TabIndex = 4;
            this.LbListeEns.Text = "Liste des facture";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(106, 98);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(170, 22);
            this.TxtSearch.TabIndex = 2;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // DtgListeFactures
            // 
            this.DtgListeFactures.AllowUserToAddRows = false;
            this.DtgListeFactures.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DtgListeFactures.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgListeFactures.Location = new System.Drawing.Point(7, 126);
            this.DtgListeFactures.Name = "DtgListeFactures";
            this.DtgListeFactures.RowHeadersVisible = false;
            this.DtgListeFactures.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgListeFactures.Size = new System.Drawing.Size(269, 365);
            this.DtgListeFactures.TabIndex = 0;
            // 
            // Btn_consulter
            // 
            this.Btn_consulter.Location = new System.Drawing.Point(311, 126);
            this.Btn_consulter.Name = "Btn_consulter";
            this.Btn_consulter.Size = new System.Drawing.Size(136, 44);
            this.Btn_consulter.TabIndex = 30;
            this.Btn_consulter.Text = "Consulter";
            this.Btn_consulter.UseVisualStyleBackColor = true;
            this.Btn_consulter.Click += new System.EventHandler(this.Btn_consulter_Click);
            // 
            // Factures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 586);
            this.Controls.Add(this.groupBox1);
            this.Name = "Factures";
            this.Text = "Factures";
            this.Load += new System.EventHandler(this.Factures_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeFactures)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LbListeEns;
        private System.Windows.Forms.TextBox TxtSearch;
        private  System.Windows.Forms.DataGridView DtgListeFactures;
        private System.Windows.Forms.Button Btn_SuppF;
        private System.Windows.Forms.Button Btn_NouvelleFacture;
        private System.Windows.Forms.Button Btn_Imprimer;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Btn_consulter;
    }
}