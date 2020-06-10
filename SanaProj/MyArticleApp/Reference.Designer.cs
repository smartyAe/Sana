namespace MyArticleApp
{
    partial class Reference
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_RefFac = new System.Windows.Forms.TextBox();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.Btn_SuivF = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 45;
            this.label1.Text = "Référence";
            // 
            // Txt_RefFac
            // 
            this.Txt_RefFac.Location = new System.Drawing.Point(101, 61);
            this.Txt_RefFac.Name = "Txt_RefFac";
            this.Txt_RefFac.Size = new System.Drawing.Size(200, 20);
            this.Txt_RefFac.TabIndex = 44;
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.Location = new System.Drawing.Point(101, 103);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Btn_Annuler.TabIndex = 47;
            this.Btn_Annuler.Text = "Annuler";
            this.Btn_Annuler.UseVisualStyleBackColor = true;
            this.Btn_Annuler.Click += new System.EventHandler(this.Btn_Annuler_Click);
            // 
            // Btn_SuivF
            // 
            this.Btn_SuivF.Location = new System.Drawing.Point(214, 103);
            this.Btn_SuivF.Name = "Btn_SuivF";
            this.Btn_SuivF.Size = new System.Drawing.Size(75, 23);
            this.Btn_SuivF.TabIndex = 46;
            this.Btn_SuivF.Text = "Suivant";
            this.Btn_SuivF.UseVisualStyleBackColor = true;
            this.Btn_SuivF.Click += new System.EventHandler(this.Btn_SuivF_Click);
            // 
            // Reference
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 136);
            this.Controls.Add(this.Btn_Annuler);
            this.Controls.Add(this.Btn_SuivF);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_RefFac);
            this.Name = "Reference";
            this.Text = "Reférence de la facture";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_RefFac;
        private System.Windows.Forms.Button Btn_Annuler;
        private System.Windows.Forms.Button Btn_SuivF;
    }
}