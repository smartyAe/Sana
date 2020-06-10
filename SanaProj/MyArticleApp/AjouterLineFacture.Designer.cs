namespace MyArticleApp
{
    partial class AjouterLineFacture
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
            this.label1 = new System.Windows.Forms.Label();
            this.Txt_RefFac = new System.Windows.Forms.TextBox();
            this.Cbx_Ref = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Quant = new System.Windows.Forms.TextBox();
            this.Lb_Reference = new System.Windows.Forms.Label();
            this.Txt_Prix = new System.Windows.Forms.TextBox();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.Btn_Ajouter = new System.Windows.Forms.Button();
            this.Gpb_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Add
            // 
            this.Gpb_Add.Controls.Add(this.label1);
            this.Gpb_Add.Controls.Add(this.Txt_RefFac);
            this.Gpb_Add.Controls.Add(this.Cbx_Ref);
            this.Gpb_Add.Controls.Add(this.label6);
            this.Gpb_Add.Controls.Add(this.label5);
            this.Gpb_Add.Controls.Add(this.Txt_Quant);
            this.Gpb_Add.Controls.Add(this.Lb_Reference);
            this.Gpb_Add.Controls.Add(this.Txt_Prix);
            this.Gpb_Add.Controls.Add(this.Btn_Annuler);
            this.Gpb_Add.Controls.Add(this.Btn_Ajouter);
            this.Gpb_Add.Location = new System.Drawing.Point(10, 63);
            this.Gpb_Add.Name = "Gpb_Add";
            this.Gpb_Add.Size = new System.Drawing.Size(336, 233);
            this.Gpb_Add.TabIndex = 36;
            this.Gpb_Add.TabStop = false;
            this.Gpb_Add.Text = "Nouvelle ligne facture";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Référence facture";
            // 
            // Txt_RefFac
            // 
            this.Txt_RefFac.Enabled = false;
            this.Txt_RefFac.Location = new System.Drawing.Point(110, 47);
            this.Txt_RefFac.Name = "Txt_RefFac";
            this.Txt_RefFac.Size = new System.Drawing.Size(200, 20);
            this.Txt_RefFac.TabIndex = 42;
            // 
            // Cbx_Ref
            // 
            this.Cbx_Ref.FormattingEnabled = true;
            this.Cbx_Ref.Location = new System.Drawing.Point(110, 81);
            this.Cbx_Ref.Name = "Cbx_Ref";
            this.Cbx_Ref.Size = new System.Drawing.Size(200, 21);
            this.Cbx_Ref.TabIndex = 41;
            this.Cbx_Ref.SelectedIndexChanged += new System.EventHandler(this.Cbx_Ref_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Prix unitaire";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Quantité";
            // 
            // Txt_Quant
            // 
            this.Txt_Quant.Location = new System.Drawing.Point(110, 150);
            this.Txt_Quant.Name = "Txt_Quant";
            this.Txt_Quant.Size = new System.Drawing.Size(200, 20);
            this.Txt_Quant.TabIndex = 38;
            // 
            // Lb_Reference
            // 
            this.Lb_Reference.AutoSize = true;
            this.Lb_Reference.Location = new System.Drawing.Point(5, 81);
            this.Lb_Reference.Name = "Lb_Reference";
            this.Lb_Reference.Size = new System.Drawing.Size(57, 13);
            this.Lb_Reference.TabIndex = 35;
            this.Lb_Reference.Text = "Reference";
            // 
            // Txt_Prix
            // 
            this.Txt_Prix.Enabled = false;
            this.Txt_Prix.Location = new System.Drawing.Point(110, 116);
            this.Txt_Prix.Name = "Txt_Prix";
            this.Txt_Prix.Size = new System.Drawing.Size(200, 20);
            this.Txt_Prix.TabIndex = 37;
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.Location = new System.Drawing.Point(110, 194);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(75, 23);
            this.Btn_Annuler.TabIndex = 9;
            this.Btn_Annuler.Text = "Annuler";
            this.Btn_Annuler.UseVisualStyleBackColor = true;
            this.Btn_Annuler.Click += new System.EventHandler(this.Btn_Annuler_Click);
            // 
            // Btn_Ajouter
            // 
            this.Btn_Ajouter.Location = new System.Drawing.Point(235, 194);
            this.Btn_Ajouter.Name = "Btn_Ajouter";
            this.Btn_Ajouter.Size = new System.Drawing.Size(75, 23);
            this.Btn_Ajouter.TabIndex = 8;
            this.Btn_Ajouter.Text = "Ajouter";
            this.Btn_Ajouter.UseVisualStyleBackColor = true;
            this.Btn_Ajouter.Click += new System.EventHandler(this.Btn_Ajouter_Click);
            // 
            // AjouterLineFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 308);
            this.Controls.Add(this.Gpb_Add);
            this.Name = "AjouterLineFacture";
            this.Text = "Ajouter Ligne Facture";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AjouterLineFacture_FormClosing);
            this.Load += new System.EventHandler(this.AjouterLineFacture_Load);
            this.Shown += new System.EventHandler(this.AjouterLineFacture_Shown);
            this.Gpb_Add.ResumeLayout(false);
            this.Gpb_Add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Add;
        private System.Windows.Forms.ComboBox Cbx_Ref;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Quant;
        private System.Windows.Forms.Label Lb_Reference;
        private System.Windows.Forms.TextBox Txt_Prix;
        private System.Windows.Forms.Button Btn_Annuler;
        private System.Windows.Forms.Button Btn_Ajouter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_RefFac;
    }
}