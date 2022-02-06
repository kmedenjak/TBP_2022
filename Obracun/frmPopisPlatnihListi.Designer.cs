namespace Obracun
{
    partial class frmPopisPlatnihListi
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
            this.lblPopisPlatnihListi = new System.Windows.Forms.Label();
            this.dgvPopisPlatnihListi = new System.Windows.Forms.DataGridView();
            this.lblPopis = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPlatnihListi)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPopisPlatnihListi
            // 
            this.lblPopisPlatnihListi.AutoSize = true;
            this.lblPopisPlatnihListi.Location = new System.Drawing.Point(24, 65);
            this.lblPopisPlatnihListi.Name = "lblPopisPlatnihListi";
            this.lblPopisPlatnihListi.Size = new System.Drawing.Size(87, 13);
            this.lblPopisPlatnihListi.TabIndex = 0;
            this.lblPopisPlatnihListi.Text = "Popis platnih listi:";
            // 
            // dgvPopisPlatnihListi
            // 
            this.dgvPopisPlatnihListi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPopisPlatnihListi.Location = new System.Drawing.Point(27, 89);
            this.dgvPopisPlatnihListi.Name = "dgvPopisPlatnihListi";
            this.dgvPopisPlatnihListi.Size = new System.Drawing.Size(770, 395);
            this.dgvPopisPlatnihListi.TabIndex = 1;
            // 
            // lblPopis
            // 
            this.lblPopis.AutoSize = true;
            this.lblPopis.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblPopis.Location = new System.Drawing.Point(350, 9);
            this.lblPopis.Name = "lblPopis";
            this.lblPopis.Size = new System.Drawing.Size(122, 39);
            this.lblPopis.TabIndex = 3;
            this.lblPopis.Text = "POPIS";
            // 
            // frmPopisPlatnihListi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 496);
            this.Controls.Add(this.lblPopis);
            this.Controls.Add(this.dgvPopisPlatnihListi);
            this.Controls.Add(this.lblPopisPlatnihListi);
            this.Name = "frmPopisPlatnihListi";
            this.Text = "Popis platnih listi";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPopisPlatnihListi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPopisPlatnihListi;
        private System.Windows.Forms.DataGridView dgvPopisPlatnihListi;
        private System.Windows.Forms.Label lblPopis;
    }
}