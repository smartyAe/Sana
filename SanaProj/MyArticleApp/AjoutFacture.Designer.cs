﻿namespace MyArticleApp
{
    partial class AjoutFacture
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
            this.Dtp_DateFacture = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Prix = new System.Windows.Forms.TextBox();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.Btn_SuivF = new System.Windows.Forms.Button();
            this.Gpb_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Add
            // 
            this.Gpb_Add.Controls.Add(this.Dtp_DateFacture);
            this.Gpb_Add.Controls.Add(this.label6);
            this.Gpb_Add.Controls.Add(this.label5);
            this.Gpb_Add.Controls.Add(this.Txt_Prix);
            this.Gpb_Add.Controls.Add(this.Btn_Annuler);
            this.Gpb_Add.Controls.Add(this.Btn_SuivF);
            this.Gpb_Add.Location = new System.Drawing.Point(12, 63);
            this.Gpb_Add.Name = "Gpb_Add";
            this.Gpb_Add.Size = new System.Drawing.Size(336, 189);
            this.Gpb_Add.TabIndex = 38;
            this.Gpb_Add.TabStop = false;
            this.Gpb_Add.Text = "Nouvelle ligne facture";
            // 
            // Dtp_DateFacture
            // 
            this.Dtp_DateFacture.Enabled = false;
            this.Dtp_DateFacture.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dtp_DateFacture.Location = new System.Drawing.Point(110, 98);
            this.Dtp_DateFacture.Name = "Dtp_DateFacture";
            this.Dtp_DateFacture.Size = new System.Drawing.Size(150, 20);
            this.Dtp_DateFacture.TabIndex = 41;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Prix unitaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Quantité";
            // 
            // Txt_Prix
            // 
            this.Txt_Prix.Enabled = false;
            this.Txt_Prix.Location = new System.Drawing.Point(110, 65);
            this.Txt_Prix.Name = "Txt_Prix";
            this.Txt_Prix.Size = new System.Drawing.Size(150, 20);
            this.Txt_Prix.TabIndex = 37;
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.Location = new System.Drawing.Point(103, 140);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Btn_Annuler.TabIndex = 9;
            this.Btn_Annuler.Text = "Annuler";
            this.Btn_Annuler.UseVisualStyleBackColor = true;
            this.Btn_Annuler.Click += new System.EventHandler(this.Btn_Annuler_Click);
            // 
            // Btn_SuivF
            // 
            this.Btn_SuivF.Location = new System.Drawing.Point(216, 140);
            this.Btn_SuivF.Name = "Btn_SuivF";
            this.Btn_SuivF.Size = new System.Drawing.Size(75, 23);
            this.Btn_SuivF.TabIndex = 8;
            this.Btn_SuivF.Text = "Suivant";
            this.Btn_SuivF.UseVisualStyleBackColor = true;
            this.Btn_SuivF.Click += new System.EventHandler(this.Btn_SuivF_Click);
            // 
            // AjoutFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 273);
            this.Controls.Add(this.Gpb_Add);
            this.Name = "AjoutFacture";
            this.Text = "AjoutFacture";
             this.Gpb_Add.ResumeLayout(false);
            this.Gpb_Add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Add;
        private System.Windows.Forms.DateTimePicker Dtp_DateFacture;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Prix;
        private System.Windows.Forms.Button Btn_Annuler;
        private System.Windows.Forms.Button Btn_SuivF;
    }
}