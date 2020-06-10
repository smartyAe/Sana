namespace MyArticleApp
{
    partial class AjouterArticle
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
            this.Gpb_Add = new System.Windows.Forms.GroupBox();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.Lb_Promo = new System.Windows.Forms.Label();
            this.Lb_DateInPromo = new System.Windows.Forms.Label();
            this.DateP_DateInPromo = new System.Windows.Forms.DateTimePicker();
            this.Txt_Quantite = new System.Windows.Forms.TextBox();
            this.Lb_Quantite = new System.Windows.Forms.Label();
            this.Txt_Prix = new System.Windows.Forms.TextBox();
            this.Lb_Prix = new System.Windows.Forms.Label();
            this.Txt_Designation = new System.Windows.Forms.TextBox();
            this.Lb_Designation = new System.Windows.Forms.Label();
            this.Lb_Reference = new System.Windows.Forms.Label();
            this.Txt_Reference = new System.Windows.Forms.TextBox();
            this.Ckb_Promo = new System.Windows.Forms.CheckBox();
            this.Gpb_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Add
            // 
            this.Gpb_Add.Controls.Add(this.Ckb_Promo);
            this.Gpb_Add.Controls.Add(this.Btn_Annuler);
            this.Gpb_Add.Controls.Add(this.Btn_Ajouter);
            this.Gpb_Add.Controls.Add(this.Lb_Promo);
            this.Gpb_Add.Controls.Add(this.Lb_DateInPromo);
            this.Gpb_Add.Controls.Add(this.DateP_DateInPromo);
            this.Gpb_Add.Controls.Add(this.Txt_Quantite);
            this.Gpb_Add.Controls.Add(this.Lb_Quantite);
            this.Gpb_Add.Controls.Add(this.Txt_Prix);
            this.Gpb_Add.Controls.Add(this.Lb_Prix);
            this.Gpb_Add.Controls.Add(this.Txt_Designation);
            this.Gpb_Add.Controls.Add(this.Lb_Designation);
            this.Gpb_Add.Controls.Add(this.Lb_Reference);
            this.Gpb_Add.Controls.Add(this.Txt_Reference);
            this.Gpb_Add.Location = new System.Drawing.Point(23, 63);
            this.Gpb_Add.Name = "Gpb_Add";
            this.Gpb_Add.Size = new System.Drawing.Size(336, 315);
            this.Gpb_Add.TabIndex = 2;
            this.Gpb_Add.TabStop = false;
            this.Gpb_Add.Text = "Nouveau article";
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.Location = new System.Drawing.Point(122, 273);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Btn_Annuler.TabIndex = 9;
            this.Btn_Annuler.Text = "Annuler";
            this.Btn_Annuler.UseVisualStyleBackColor = true;
            this.Btn_Annuler.Click += new System.EventHandler(this.Btn_Annuler_Click);
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(235, 273);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajouter.TabIndex = 8;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // Lb_Promo
            // 
            this.Lb_Promo.AutoSize = true;
            this.Lb_Promo.Location = new System.Drawing.Point(6, 160);
            this.Lb_Promo.Name = "Lb_Promo";
            this.Lb_Promo.Size = new System.Drawing.Size(37, 13);
            this.Lb_Promo.TabIndex = 7;
            this.Lb_Promo.Text = "Promo";
            // 
            // Lb_DateInPromo
            // 
            this.Lb_DateInPromo.AutoSize = true;
            this.Lb_DateInPromo.Location = new System.Drawing.Point(6, 197);
            this.Lb_DateInPromo.Name = "Lb_DateInPromo";
            this.Lb_DateInPromo.Size = new System.Drawing.Size(75, 13);
            this.Lb_DateInPromo.TabIndex = 1;
            this.Lb_DateInPromo.Text = "Date In Promo";
            // 
            // DateP_DateInPromo
            // 
            this.DateP_DateInPromo.Location = new System.Drawing.Point(117, 194);
            this.DateP_DateInPromo.Name = "DateP_DateInPromo";
            this.DateP_DateInPromo.Size = new System.Drawing.Size(200, 20);
            this.DateP_DateInPromo.TabIndex = 1;
            // 
            // Txt_Quantite
            // 
            this.Txt_Quantite.Location = new System.Drawing.Point(117, 231);
            this.Txt_Quantite.Name = "Txt_Quantite";
            this.Txt_Quantite.Size = new System.Drawing.Size(200, 20);
            this.Txt_Quantite.TabIndex = 5;
            // 
            // Lb_Quantite
            // 
            this.Lb_Quantite.AutoSize = true;
            this.Lb_Quantite.Location = new System.Drawing.Point(6, 234);
            this.Lb_Quantite.Name = "Lb_Quantite";
            this.Lb_Quantite.Size = new System.Drawing.Size(47, 13);
            this.Lb_Quantite.TabIndex = 2;
            this.Lb_Quantite.Text = "Quantite";
            // 
            // Txt_Prix
            // 
            this.Txt_Prix.Location = new System.Drawing.Point(117, 123);
            this.Txt_Prix.Name = "Txt_Prix";
            this.Txt_Prix.Size = new System.Drawing.Size(200, 20);
            this.Txt_Prix.TabIndex = 4;
            // 
            // Lb_Prix
            // 
            this.Lb_Prix.AutoSize = true;
            this.Lb_Prix.Location = new System.Drawing.Point(6, 114);
            this.Lb_Prix.Name = "Lb_Prix";
            this.Lb_Prix.Size = new System.Drawing.Size(24, 13);
            this.Lb_Prix.TabIndex = 1;
            this.Lb_Prix.Text = "Prix";
            // 
            // Txt_Designation
            // 
            this.Txt_Designation.Location = new System.Drawing.Point(117, 86);
            this.Txt_Designation.Name = "Txt_Designation";
            this.Txt_Designation.Size = new System.Drawing.Size(200, 20);
            this.Txt_Designation.TabIndex = 3;
            // 
            // Lb_Designation
            // 
            this.Lb_Designation.AutoSize = true;
            this.Lb_Designation.Location = new System.Drawing.Point(6, 83);
            this.Lb_Designation.Name = "Lb_Designation";
            this.Lb_Designation.Size = new System.Drawing.Size(63, 13);
            this.Lb_Designation.TabIndex = 0;
            this.Lb_Designation.Text = "Designation";
            // 
            // Lb_Reference
            // 
            this.Lb_Reference.AutoSize = true;
            this.Lb_Reference.Location = new System.Drawing.Point(6, 52);
            this.Lb_Reference.Name = "Lb_Reference";
            this.Lb_Reference.Size = new System.Drawing.Size(57, 13);
            this.Lb_Reference.TabIndex = 1;
            this.Lb_Reference.Text = "Reference";
            // 
            // Txt_Reference
            // 
            this.Txt_Reference.Location = new System.Drawing.Point(117, 49);
            this.Txt_Reference.Name = "Txt_Reference";
            this.Txt_Reference.Size = new System.Drawing.Size(200, 20);
            this.Txt_Reference.TabIndex = 2;
            // 
            // Ckb_Promo
            // 
            this.Ckb_Promo.AutoSize = true;
            this.Ckb_Promo.Location = new System.Drawing.Point(117, 160);
            this.Ckb_Promo.Name = "Ckb_Promo";
            this.Ckb_Promo.Size = new System.Drawing.Size(15, 14);
            this.Ckb_Promo.TabIndex = 14;
            this.Ckb_Promo.UseVisualStyleBackColor = true;
            // 
            // AjouterArticle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 407);
            this.Controls.Add(this.Gpb_Add);
            this.Name = "AjouterArticle";
            this.Text = "AjouterArticle";
            this.Gpb_Add.ResumeLayout(false);
            this.Gpb_Add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Add;
        private System.Windows.Forms.Button Btn_Annuler;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.Label Lb_Promo;
        private System.Windows.Forms.Label Lb_DateInPromo;
        private System.Windows.Forms.DateTimePicker DateP_DateInPromo;
        private System.Windows.Forms.TextBox Txt_Quantite;
        private System.Windows.Forms.Label Lb_Quantite;
        private System.Windows.Forms.TextBox Txt_Prix;
        private System.Windows.Forms.Label Lb_Prix;
        private System.Windows.Forms.TextBox Txt_Designation;
        private System.Windows.Forms.Label Lb_Designation;
        private System.Windows.Forms.Label Lb_Reference;
        private System.Windows.Forms.TextBox Txt_Reference;
        private System.Windows.Forms.CheckBox Ckb_Promo;
    }
}