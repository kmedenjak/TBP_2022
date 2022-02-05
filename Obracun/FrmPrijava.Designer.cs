namespace Obracun
{
    partial class FrmPrijava
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
            this.lbl_PrijavaId = new System.Windows.Forms.Label();
            this.txt_PrijavaId = new System.Windows.Forms.TextBox();
            this.btn_Prijava = new System.Windows.Forms.Button();
            this.btn_Pocetna = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_PrijavaId
            // 
            this.lbl_PrijavaId.AutoSize = true;
            this.lbl_PrijavaId.Location = new System.Drawing.Point(59, 37);
            this.lbl_PrijavaId.Name = "lbl_PrijavaId";
            this.lbl_PrijavaId.Size = new System.Drawing.Size(21, 13);
            this.lbl_PrijavaId.TabIndex = 0;
            this.lbl_PrijavaId.Text = "ID:";
            // 
            // txt_PrijavaId
            // 
            this.txt_PrijavaId.Location = new System.Drawing.Point(62, 53);
            this.txt_PrijavaId.Name = "txt_PrijavaId";
            this.txt_PrijavaId.Size = new System.Drawing.Size(154, 20);
            this.txt_PrijavaId.TabIndex = 2;
            this.txt_PrijavaId.TextChanged += new System.EventHandler(this.txt_PrijavaId_TextChanged);
            // 
            // btn_Prijava
            // 
            this.btn_Prijava.Location = new System.Drawing.Point(99, 96);
            this.btn_Prijava.Name = "btn_Prijava";
            this.btn_Prijava.Size = new System.Drawing.Size(75, 23);
            this.btn_Prijava.TabIndex = 4;
            this.btn_Prijava.Text = "Prijava";
            this.btn_Prijava.UseVisualStyleBackColor = true;
            this.btn_Prijava.Click += new System.EventHandler(this.btn_Prijava_Click);
            // 
            // btn_Pocetna
            // 
            this.btn_Pocetna.Location = new System.Drawing.Point(99, 125);
            this.btn_Pocetna.Name = "btn_Pocetna";
            this.btn_Pocetna.Size = new System.Drawing.Size(75, 23);
            this.btn_Pocetna.TabIndex = 5;
            this.btn_Pocetna.Text = "Početna";
            this.btn_Pocetna.UseVisualStyleBackColor = true;
            this.btn_Pocetna.Click += new System.EventHandler(this.btn_Pocetna_Click);
            // 
            // FrmPrijava
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(277, 163);
            this.Controls.Add(this.btn_Pocetna);
            this.Controls.Add(this.btn_Prijava);
            this.Controls.Add(this.txt_PrijavaId);
            this.Controls.Add(this.lbl_PrijavaId);
            this.Name = "FrmPrijava";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_PrijavaId;
        private System.Windows.Forms.TextBox txt_PrijavaId;
        private System.Windows.Forms.Button btn_Prijava;
        private System.Windows.Forms.Button btn_Pocetna;
    }
}