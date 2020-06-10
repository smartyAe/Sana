namespace MyArticleApp
{
    partial class DetailFacture
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.Btn_Enregistrer = new System.Windows.Forms.Button();
            this.Lb_Mont = new System.Windows.Forms.Label();
            this.Lb_Montant = new System.Windows.Forms.Label();
            this.Dtp_DateFacture = new System.Windows.Forms.DateTimePicker();
            this.Lb_Ref = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LbProgramme = new System.Windows.Forms.Label();
            this.LbDep = new System.Windows.Forms.Label();
            this.LbNomEns = new System.Windows.Forms.Label();
            this.Btn_SupprimerLF = new System.Windows.Forms.Button();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.Btn_AjouterLgFacture = new System.Windows.Forms.Button();
            this.DtgListeLigneFacture = new System.Windows.Forms.DataGridView();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeLigneFacture)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.TxtSearch);
            this.groupBox2.Controls.Add(this.Btn_Enregistrer);
            this.groupBox2.Controls.Add(this.Lb_Mont);
            this.groupBox2.Controls.Add(this.Lb_Montant);
            this.groupBox2.Controls.Add(this.Dtp_DateFacture);
            this.groupBox2.Controls.Add(this.Lb_Ref);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.LbProgramme);
            this.groupBox2.Controls.Add(this.LbDep);
            this.groupBox2.Controls.Add(this.LbNomEns);
            this.groupBox2.Controls.Add(this.Btn_SupprimerLF);
            this.groupBox2.Controls.Add(this.Btn_Modifier);
            this.groupBox2.Controls.Add(this.Btn_AjouterLgFacture);
            this.groupBox2.Controls.Add(this.DtgListeLigneFacture);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 63);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(475, 516);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Détails facture";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(58, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 25);
            this.label3.TabIndex = 30;
            this.label3.Text = "Lignes de la facture";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Recherche";
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(100, 220);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(206, 22);
            this.TxtSearch.TabIndex = 28;
            this.TxtSearch.TextChanged += new System.EventHandler(this.TxtSearch_TextChanged);
            // 
            // Btn_Enregistrer
            // 
            this.Btn_Enregistrer.Location = new System.Drawing.Point(330, 428);
            this.Btn_Enregistrer.Name = "Btn_Enregistrer";
            this.Btn_Enregistrer.Size = new System.Drawing.Size(136, 44);
            this.Btn_Enregistrer.TabIndex = 27;
            this.Btn_Enregistrer.Text = "Enregistrer";
            this.Btn_Enregistrer.UseVisualStyleBackColor = true;
            this.Btn_Enregistrer.Click += new System.EventHandler(this.Btn_Enregistrer_Click);
            // 
            // Lb_Mont
            // 
            this.Lb_Mont.AutoSize = true;
            this.Lb_Mont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Mont.Location = new System.Drawing.Point(262, 483);
            this.Lb_Mont.Name = "Lb_Mont";
            this.Lb_Mont.Size = new System.Drawing.Size(121, 20);
            this.Lb_Mont.TabIndex = 26;
            this.Lb_Mont.Text = "Pas de Montant";
            // 
            // Lb_Montant
            // 
            this.Lb_Montant.AutoSize = true;
            this.Lb_Montant.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Montant.Location = new System.Drawing.Point(162, 479);
            this.Lb_Montant.Name = "Lb_Montant";
            this.Lb_Montant.Size = new System.Drawing.Size(94, 25);
            this.Lb_Montant.TabIndex = 25;
            this.Lb_Montant.Text = "Montant :";
            // 
            // Dtp_DateFacture
            // 
            this.Dtp_DateFacture.Enabled = false;
            this.Dtp_DateFacture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DateFacture.Location = new System.Drawing.Point(167, 150);
            this.Dtp_DateFacture.Name = "Dtp_DateFacture";
            this.Dtp_DateFacture.Size = new System.Drawing.Size(139, 22);
            this.Dtp_DateFacture.TabIndex = 24;
            // 
            // Lb_Ref
            // 
            this.Lb_Ref.AutoSize = true;
            this.Lb_Ref.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Ref.Location = new System.Drawing.Point(163, 102);
            this.Lb_Ref.Name = "Lb_Ref";
            this.Lb_Ref.Size = new System.Drawing.Size(154, 24);
            this.Lb_Ref.TabIndex = 11;
            this.Lb_Ref.Text = "Pas de référence";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 10;
            // 
            // LbProgramme
            // 
            this.LbProgramme.AutoSize = true;
            this.LbProgramme.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbProgramme.Location = new System.Drawing.Point(56, 37);
            this.LbProgramme.Name = "LbProgramme";
            this.LbProgramme.Size = new System.Drawing.Size(320, 37);
            this.LbProgramme.TabIndex = 9;
            this.LbProgramme.Text = "Détails de la facture";
            // 
            // LbDep
            // 
            this.LbDep.AutoSize = true;
            this.LbDep.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbDep.Location = new System.Drawing.Point(6, 150);
            this.LbDep.Name = "LbDep";
            this.LbDep.Size = new System.Drawing.Size(164, 25);
            this.LbDep.TabIndex = 6;
            this.LbDep.Text = "Date facturation  :";
            // 
            // LbNomEns
            // 
            this.LbNomEns.AutoSize = true;
            this.LbNomEns.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbNomEns.Location = new System.Drawing.Point(6, 101);
            this.LbNomEns.Name = "LbNomEns";
            this.LbNomEns.Size = new System.Drawing.Size(112, 25);
            this.LbNomEns.TabIndex = 5;
            this.LbNomEns.Text = "Référence :";
            // 
            // Btn_SupprimerLF
            // 
            this.Btn_SupprimerLF.Location = new System.Drawing.Point(330, 368);
            this.Btn_SupprimerLF.Name = "Btn_SupprimerLF";
            this.Btn_SupprimerLF.Size = new System.Drawing.Size(136, 44);
            this.Btn_SupprimerLF.TabIndex = 3;
            this.Btn_SupprimerLF.Text = "Supprimer";
            this.Btn_SupprimerLF.UseVisualStyleBackColor = true;
            this.Btn_SupprimerLF.Click += new System.EventHandler(this.Btn_SupprimerLF_Click);
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(330, 308);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(136, 44);
            this.Btn_Modifier.TabIndex = 2;
            this.Btn_Modifier.Text = "Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // Btn_AjouterLgFacture
            // 
            this.Btn_AjouterLgFacture.Location = new System.Drawing.Point(330, 248);
            this.Btn_AjouterLgFacture.Name = "Btn_AjouterLgFacture";
            this.Btn_AjouterLgFacture.Size = new System.Drawing.Size(136, 44);
            this.Btn_AjouterLgFacture.TabIndex = 1;
            this.Btn_AjouterLgFacture.Text = "Ajouter";
            this.Btn_AjouterLgFacture.UseVisualStyleBackColor = true;
            this.Btn_AjouterLgFacture.Click += new System.EventHandler(this.Btn_AjouterLgFacture_Click);
            // 
            // DtgListeLigneFacture
            // 
            this.DtgListeLigneFacture.AllowUserToAddRows = false;
            this.DtgListeLigneFacture.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.DtgListeLigneFacture.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgListeLigneFacture.Location = new System.Drawing.Point(6, 248);
            this.DtgListeLigneFacture.Name = "DtgListeLigneFacture";
            this.DtgListeLigneFacture.RowHeadersVisible = false;
            this.DtgListeLigneFacture.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DtgListeLigneFacture.Size = new System.Drawing.Size(300, 224);
            this.DtgListeLigneFacture.TabIndex = 0;
            // 
            // DetailFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 591);
            this.Controls.Add(this.groupBox2);
            this.Name = "DetailFacture";
            this.Text = "Details de la Facture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DetailFacture_FormClosing);
            this.Load += new System.EventHandler(this.DetailFacture_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgListeLigneFacture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button Btn_Enregistrer;
        private System.Windows.Forms.Label Lb_Mont;
        private System.Windows.Forms.Label Lb_Montant;
        private System.Windows.Forms.DateTimePicker Dtp_DateFacture;
        private System.Windows.Forms.Label Lb_Ref;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LbProgramme;
        private System.Windows.Forms.Label LbDep;
        private System.Windows.Forms.Label LbNomEns;
        private System.Windows.Forms.Button Btn_SupprimerLF;
        private System.Windows.Forms.Button Btn_Modifier;
        private System.Windows.Forms.Button Btn_AjouterLgFacture;
        private System.Windows.Forms.DataGridView DtgListeLigneFacture;
        private System.Windows.Forms.Label label3;
    }
}