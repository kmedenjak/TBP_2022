namespace Obracun
{
    partial class FrmPocetnaForma
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
            this.dgv_popisZaposlenika = new System.Windows.Forms.DataGridView();
            this.lbl_popisZaposlenika = new System.Windows.Forms.Label();
            this.btn_UnosZaposlenika = new System.Windows.Forms.Button();
            this.btn_ObrsiZaposlenika = new System.Windows.Forms.Button();
            this.txt_Pretrazi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Menu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_popisZaposlenika)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_popisZaposlenika
            // 
            this.dgv_popisZaposlenika.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_popisZaposlenika.Location = new System.Drawing.Point(32, 106);
            this.dgv_popisZaposlenika.Name = "dgv_popisZaposlenika";
            this.dgv_popisZaposlenika.Size = new System.Drawing.Size(877, 400);
            this.dgv_popisZaposlenika.TabIndex = 0;
            // 
            // lbl_popisZaposlenika
            // 
            this.lbl_popisZaposlenika.AutoSize = true;
            this.lbl_popisZaposlenika.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_popisZaposlenika.Location = new System.Drawing.Point(27, 78);
            this.lbl_popisZaposlenika.Name = "lbl_popisZaposlenika";
            this.lbl_popisZaposlenika.Size = new System.Drawing.Size(161, 25);
            this.lbl_popisZaposlenika.TabIndex = 1;
            this.lbl_popisZaposlenika.Text = "Popis zaposlenika:";
            // 
            // btn_UnosZaposlenika
            // 
            this.btn_UnosZaposlenika.Location = new System.Drawing.Point(786, 77);
            this.btn_UnosZaposlenika.Name = "btn_UnosZaposlenika";
            this.btn_UnosZaposlenika.Size = new System.Drawing.Size(123, 23);
            this.btn_UnosZaposlenika.TabIndex = 2;
            this.btn_UnosZaposlenika.Text = "Novi zaposlenik";
            this.btn_UnosZaposlenika.UseVisualStyleBackColor = true;
            this.btn_UnosZaposlenika.Click += new System.EventHandler(this.btn_UnosZaposlenika_Click);
            // 
            // btn_ObrsiZaposlenika
            // 
            this.btn_ObrsiZaposlenika.Location = new System.Drawing.Point(661, 77);
            this.btn_ObrsiZaposlenika.Name = "btn_ObrsiZaposlenika";
            this.btn_ObrsiZaposlenika.Size = new System.Drawing.Size(119, 23);
            this.btn_ObrsiZaposlenika.TabIndex = 3;
            this.btn_ObrsiZaposlenika.Text = "Obrisi zaposelnika";
            this.btn_ObrsiZaposlenika.UseVisualStyleBackColor = true;
            // 
            // txt_Pretrazi
            // 
            this.txt_Pretrazi.Location = new System.Drawing.Point(723, 51);
            this.txt_Pretrazi.Name = "txt_Pretrazi";
            this.txt_Pretrazi.Size = new System.Drawing.Size(186, 20);
            this.txt_Pretrazi.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(723, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pretrazi:";
            // 
            // btn_Menu
            // 
            this.btn_Menu.Location = new System.Drawing.Point(32, 13);
            this.btn_Menu.Name = "btn_Menu";
            this.btn_Menu.Size = new System.Drawing.Size(47, 32);
            this.btn_Menu.TabIndex = 7;
            this.btn_Menu.Text = "Menu";
            this.btn_Menu.UseVisualStyleBackColor = true;
            this.btn_Menu.Click += new System.EventHandler(this.btn_Menu_Click);
            // 
            // FrmPocetnaForma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 530);
            this.Controls.Add(this.btn_Menu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Pretrazi);
            this.Controls.Add(this.btn_ObrsiZaposlenika);
            this.Controls.Add(this.btn_UnosZaposlenika);
            this.Controls.Add(this.lbl_popisZaposlenika);
            this.Controls.Add(this.dgv_popisZaposlenika);
            this.Name = "FrmPocetnaForma";
            this.Text = "Pocetna forma";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_popisZaposlenika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_popisZaposlenika;
        private System.Windows.Forms.Label lbl_popisZaposlenika;
        private System.Windows.Forms.Button btn_UnosZaposlenika;
        private System.Windows.Forms.Button btn_ObrsiZaposlenika;
        private System.Windows.Forms.TextBox txt_Pretrazi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Menu;
    }
}

