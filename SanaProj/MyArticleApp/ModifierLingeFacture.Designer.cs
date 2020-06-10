namespace MyArticleApp
{
    partial class ModifierLingeFacture
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
            this.Cbx_Ref = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Btn_Annuler = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.Btn_Modifier = new System.Windows.Forms.Button();
            this.Txt_Quant = new System.Windows.Forms.TextBox();
            this.Lb_Reference = new System.Windows.Forms.Label();
            this.Txt_Prix = new System.Windows.Forms.TextBox();
            this.Gpb_Add.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gpb_Add
            // 
            this.Gpb_Add.Controls.Add(this.Cbx_Ref);
            this.Gpb_Add.Controls.Add(this.label6);
            this.Gpb_Add.Controls.Add(this.Btn_Annuler);
            this.Gpb_Add.Controls.Add(this.label5);
            this.Gpb_Add.Controls.Add(this.Btn_Modifier);
            this.Gpb_Add.Controls.Add(this.Txt_Quant);
            this.Gpb_Add.Controls.Add(this.Lb_Reference);
            this.Gpb_Add.Controls.Add(this.Txt_Prix);
            this.Gpb_Add.Location = new System.Drawing.Point(23, 61);
            this.Gpb_Add.Name = "Gpb_Add";
            this.Gpb_Add.Size = new System.Drawing.Size(336, 211);
            this.Gpb_Add.TabIndex = 37;
            this.Gpb_Add.TabStop = false;
            this.Gpb_Add.Text = "Modifier ligne facture";
            // 
            // Cbx_Ref
            // 
            this.Cbx_Ref.Enabled = false;
            this.Cbx_Ref.FormattingEnabled = true;
            this.Cbx_Ref.Location = new System.Drawing.Point(111, 38);
            this.Cbx_Ref.Name = "Cbx_Ref";
            this.Cbx_Ref.Size = new System.Drawing.Size(200, 21);
            this.Cbx_Ref.TabIndex = 42;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Prix unitaire";
            // 
            // Btn_Annuler
            // 
            this.Btn_Annuler.Location = new System.Drawing.Point(123, 156);
            this.Btn_Annuler.Name = "Btn_Annuler";
            this.Btn_Annuler.Size = new System.Drawing.Size(75, 30);
            this.Btn_Annuler.TabIndex = 9;
            this.Btn_Annuler.Text = "Annuler";
            this.Btn_Annuler.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Quantité";
            // 
            // Btn_Modifier
            // 
            this.Btn_Modifier.Location = new System.Drawing.Point(236, 156);
            this.Btn_Modifier.Name = "Btn_Modifier";
            this.Btn_Modifier.Size = new System.Drawing.Size(75, 30);
            this.Btn_Modifier.TabIndex = 8;
            this.Btn_Modifier.Text = "Modifier";
            this.Btn_Modifier.UseVisualStyleBackColor = true;
            this.Btn_Modifier.Click += new System.EventHandler(this.Btn_Modifier_Click);
            // 
            // Txt_Quant
            // 
            this.Txt_Quant.Location = new System.Drawing.Point(111, 110);
            this.Txt_Quant.Name = "Txt_Quant";
            this.Txt_Quant.Size = new System.Drawing.Size(200, 20);
            this.Txt_Quant.TabIndex = 29;
            // 
            // Lb_Reference
            // 
            this.Lb_Reference.AutoSize = true;
            this.Lb_Reference.Location = new System.Drawing.Point(6, 41);
            this.Lb_Reference.Name = "Lb_Reference";
            this.Lb_Reference.Size = new System.Drawing.Size(57, 13);
            this.Lb_Reference.TabIndex = 1;
            this.Lb_Reference.Text = "Référence";
            // 
            // Txt_Prix
            // 
            this.Txt_Prix.Enabled = false;
            this.Txt_Prix.Location = new System.Drawing.Point(111, 74);
            this.Txt_Prix.Name = "Txt_Prix";
            this.Txt_Prix.Size = new System.Drawing.Size(200, 20);
            this.Txt_Prix.TabIndex = 28;
            // 
            // ModifierLingeFacture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(386, 289);
            this.Controls.Add(this.Gpb_Add);
            this.Name = "ModifierLingeFacture";
            this.Text = "Modifier Ligne Facture";
            this.Gpb_Add.ResumeLayout(false);
            this.Gpb_Add.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gpb_Add;
        public System.Windows.Forms.ComboBox Cbx_Ref;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button Btn_Annuler;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button Btn_Modifier;
        public System.Windows.Forms.TextBox Txt_Quant;
        private System.Windows.Forms.Label Lb_Reference;
        public System.Windows.Forms.TextBox Txt_Prix;
    }
}