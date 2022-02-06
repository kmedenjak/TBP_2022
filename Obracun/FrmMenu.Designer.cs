namespace Obracun
{
    partial class FrmMenu
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
            this.btn_ObrisiRadnoMjesto = new System.Windows.Forms.Button();
            this.lbl_PopisRadniMjesta = new System.Windows.Forms.Label();
            this.dgv_PopisRadnoMjesto = new System.Windows.Forms.DataGridView();
            this.btn_UnesiRadnoMjesto = new System.Windows.Forms.Button();
            this.txt_Satnica = new System.Windows.Forms.TextBox();
            this.txt_NazivRadnoMjesto = new System.Windows.Forms.TextBox();
            this.lbl_Odjel = new System.Windows.Forms.Label();
            this.cmb_Odjel = new System.Windows.Forms.ComboBox();
            this.lbl_Satnica = new System.Windows.Forms.Label();
            this.lbl_NazivRadnogMjesta = new System.Windows.Forms.Label();
            this.gb_DodajNoviOdjel = new System.Windows.Forms.GroupBox();
            this.btn_ObrisiOdjel = new System.Windows.Forms.Button();
            this.cmb_VoditeljOdjela = new System.Windows.Forms.ComboBox();
            this.lbl_PopisOdjela = new System.Windows.Forms.Label();
            this.dgv_PopisOdjel = new System.Windows.Forms.DataGridView();
            this.btn_UnesiOdjel = new System.Windows.Forms.Button();
            this.txt_NazivOdjel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_NazivOdjel = new System.Windows.Forms.Label();
            this.btn_Zatvori = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PopisRadnoMjesto)).BeginInit();
            this.gb_DodajNoviOdjel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PopisOdjel)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_ObrisiRadnoMjesto);
            this.groupBox1.Controls.Add(this.lbl_PopisRadniMjesta);
            this.groupBox1.Controls.Add(this.dgv_PopisRadnoMjesto);
            this.groupBox1.Controls.Add(this.btn_UnesiRadnoMjesto);
            this.groupBox1.Controls.Add(this.txt_Satnica);
            this.groupBox1.Controls.Add(this.txt_NazivRadnoMjesto);
            this.groupBox1.Controls.Add(this.lbl_Odjel);
            this.groupBox1.Controls.Add(this.cmb_Odjel);
            this.groupBox1.Controls.Add(this.lbl_Satnica);
            this.groupBox1.Controls.Add(this.lbl_NazivRadnogMjesta);
            this.groupBox1.Location = new System.Drawing.Point(12, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dodaj novo radno mjesto";
            // 
            // btn_ObrisiRadnoMjesto
            // 
            this.btn_ObrisiRadnoMjesto.Location = new System.Drawing.Point(309, 228);
            this.btn_ObrisiRadnoMjesto.Name = "btn_ObrisiRadnoMjesto";
            this.btn_ObrisiRadnoMjesto.Size = new System.Drawing.Size(75, 23);
            this.btn_ObrisiRadnoMjesto.TabIndex = 8;
            this.btn_ObrisiRadnoMjesto.Text = "Obrisi";
            this.btn_ObrisiRadnoMjesto.UseVisualStyleBackColor = true;
            this.btn_ObrisiRadnoMjesto.Click += new System.EventHandler(this.btn_ObrisiRadnoMjesto_Click);
            // 
            // lbl_PopisRadniMjesta
            // 
            this.lbl_PopisRadniMjesta.AutoSize = true;
            this.lbl_PopisRadniMjesta.Location = new System.Drawing.Point(18, 238);
            this.lbl_PopisRadniMjesta.Name = "lbl_PopisRadniMjesta";
            this.lbl_PopisRadniMjesta.Size = new System.Drawing.Size(101, 13);
            this.lbl_PopisRadniMjesta.TabIndex = 7;
            this.lbl_PopisRadniMjesta.Text = "Popis radnih mjesta:";
            // 
            // dgv_PopisRadnoMjesto
            // 
            this.dgv_PopisRadnoMjesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PopisRadnoMjesto.Location = new System.Drawing.Point(18, 263);
            this.dgv_PopisRadnoMjesto.Name = "dgv_PopisRadnoMjesto";
            this.dgv_PopisRadnoMjesto.Size = new System.Drawing.Size(366, 150);
            this.dgv_PopisRadnoMjesto.TabIndex = 1;
            // 
            // btn_UnesiRadnoMjesto
            // 
            this.btn_UnesiRadnoMjesto.Location = new System.Drawing.Point(168, 199);
            this.btn_UnesiRadnoMjesto.Name = "btn_UnesiRadnoMjesto";
            this.btn_UnesiRadnoMjesto.Size = new System.Drawing.Size(75, 23);
            this.btn_UnesiRadnoMjesto.TabIndex = 1;
            this.btn_UnesiRadnoMjesto.Text = "Unesi";
            this.btn_UnesiRadnoMjesto.UseVisualStyleBackColor = true;
            this.btn_UnesiRadnoMjesto.Click += new System.EventHandler(this.btn_UnesiRadnoMjesto_Click);
            // 
            // txt_Satnica
            // 
            this.txt_Satnica.Location = new System.Drawing.Point(18, 107);
            this.txt_Satnica.Name = "txt_Satnica";
            this.txt_Satnica.Size = new System.Drawing.Size(225, 20);
            this.txt_Satnica.TabIndex = 6;
            // 
            // txt_NazivRadnoMjesto
            // 
            this.txt_NazivRadnoMjesto.Location = new System.Drawing.Point(18, 56);
            this.txt_NazivRadnoMjesto.Name = "txt_NazivRadnoMjesto";
            this.txt_NazivRadnoMjesto.Size = new System.Drawing.Size(225, 20);
            this.txt_NazivRadnoMjesto.TabIndex = 5;
            // 
            // lbl_Odjel
            // 
            this.lbl_Odjel.AutoSize = true;
            this.lbl_Odjel.Location = new System.Drawing.Point(15, 136);
            this.lbl_Odjel.Name = "lbl_Odjel";
            this.lbl_Odjel.Size = new System.Drawing.Size(34, 13);
            this.lbl_Odjel.TabIndex = 4;
            this.lbl_Odjel.Text = "Odjel:";
            // 
            // cmb_Odjel
            // 
            this.cmb_Odjel.FormattingEnabled = true;
            this.cmb_Odjel.Location = new System.Drawing.Point(18, 158);
            this.cmb_Odjel.Name = "cmb_Odjel";
            this.cmb_Odjel.Size = new System.Drawing.Size(225, 21);
            this.cmb_Odjel.TabIndex = 3;
            // 
            // lbl_Satnica
            // 
            this.lbl_Satnica.AutoSize = true;
            this.lbl_Satnica.Location = new System.Drawing.Point(15, 85);
            this.lbl_Satnica.Name = "lbl_Satnica";
            this.lbl_Satnica.Size = new System.Drawing.Size(46, 13);
            this.lbl_Satnica.TabIndex = 2;
            this.lbl_Satnica.Text = "Satnica:";
            // 
            // lbl_NazivRadnogMjesta
            // 
            this.lbl_NazivRadnogMjesta.AutoSize = true;
            this.lbl_NazivRadnogMjesta.Location = new System.Drawing.Point(15, 34);
            this.lbl_NazivRadnogMjesta.Name = "lbl_NazivRadnogMjesta";
            this.lbl_NazivRadnogMjesta.Size = new System.Drawing.Size(37, 13);
            this.lbl_NazivRadnogMjesta.TabIndex = 1;
            this.lbl_NazivRadnogMjesta.Text = "Naziv:";
            // 
            // gb_DodajNoviOdjel
            // 
            this.gb_DodajNoviOdjel.Controls.Add(this.btn_ObrisiOdjel);
            this.gb_DodajNoviOdjel.Controls.Add(this.cmb_VoditeljOdjela);
            this.gb_DodajNoviOdjel.Controls.Add(this.lbl_PopisOdjela);
            this.gb_DodajNoviOdjel.Controls.Add(this.dgv_PopisOdjel);
            this.gb_DodajNoviOdjel.Controls.Add(this.btn_UnesiOdjel);
            this.gb_DodajNoviOdjel.Controls.Add(this.txt_NazivOdjel);
            this.gb_DodajNoviOdjel.Controls.Add(this.label3);
            this.gb_DodajNoviOdjel.Controls.Add(this.btn_NazivOdjel);
            this.gb_DodajNoviOdjel.Location = new System.Drawing.Point(435, 25);
            this.gb_DodajNoviOdjel.Name = "gb_DodajNoviOdjel";
            this.gb_DodajNoviOdjel.Size = new System.Drawing.Size(400, 426);
            this.gb_DodajNoviOdjel.TabIndex = 8;
            this.gb_DodajNoviOdjel.TabStop = false;
            this.gb_DodajNoviOdjel.Text = "Dodaj novi odjel";
            // 
            // btn_ObrisiOdjel
            // 
            this.btn_ObrisiOdjel.Location = new System.Drawing.Point(309, 233);
            this.btn_ObrisiOdjel.Name = "btn_ObrisiOdjel";
            this.btn_ObrisiOdjel.Size = new System.Drawing.Size(75, 23);
            this.btn_ObrisiOdjel.TabIndex = 9;
            this.btn_ObrisiOdjel.Text = "Obrisi";
            this.btn_ObrisiOdjel.UseVisualStyleBackColor = true;
            this.btn_ObrisiOdjel.Click += new System.EventHandler(this.btn_ObrisiOdjel_Click);
            // 
            // cmb_VoditeljOdjela
            // 
            this.cmb_VoditeljOdjela.FormattingEnabled = true;
            this.cmb_VoditeljOdjela.Location = new System.Drawing.Point(18, 106);
            this.cmb_VoditeljOdjela.Name = "cmb_VoditeljOdjela";
            this.cmb_VoditeljOdjela.Size = new System.Drawing.Size(225, 21);
            this.cmb_VoditeljOdjela.TabIndex = 8;
            // 
            // lbl_PopisOdjela
            // 
            this.lbl_PopisOdjela.AutoSize = true;
            this.lbl_PopisOdjela.Location = new System.Drawing.Point(15, 238);
            this.lbl_PopisOdjela.Name = "lbl_PopisOdjela";
            this.lbl_PopisOdjela.Size = new System.Drawing.Size(67, 13);
            this.lbl_PopisOdjela.TabIndex = 7;
            this.lbl_PopisOdjela.Text = "Popis odjela:";
            // 
            // dgv_PopisOdjel
            // 
            this.dgv_PopisOdjel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_PopisOdjel.Location = new System.Drawing.Point(18, 263);
            this.dgv_PopisOdjel.Name = "dgv_PopisOdjel";
            this.dgv_PopisOdjel.Size = new System.Drawing.Size(366, 150);
            this.dgv_PopisOdjel.TabIndex = 1;
            // 
            // btn_UnesiOdjel
            // 
            this.btn_UnesiOdjel.Location = new System.Drawing.Point(168, 136);
            this.btn_UnesiOdjel.Name = "btn_UnesiOdjel";
            this.btn_UnesiOdjel.Size = new System.Drawing.Size(75, 23);
            this.btn_UnesiOdjel.TabIndex = 1;
            this.btn_UnesiOdjel.Text = "Unesi";
            this.btn_UnesiOdjel.UseVisualStyleBackColor = true;
            this.btn_UnesiOdjel.Click += new System.EventHandler(this.btn_UnesiOdjel_Click);
            // 
            // txt_NazivOdjel
            // 
            this.txt_NazivOdjel.Location = new System.Drawing.Point(18, 56);
            this.txt_NazivOdjel.Name = "txt_NazivOdjel";
            this.txt_NazivOdjel.Size = new System.Drawing.Size(225, 20);
            this.txt_NazivOdjel.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Voditelj odjela:";
            // 
            // btn_NazivOdjel
            // 
            this.btn_NazivOdjel.AutoSize = true;
            this.btn_NazivOdjel.Location = new System.Drawing.Point(15, 34);
            this.btn_NazivOdjel.Name = "btn_NazivOdjel";
            this.btn_NazivOdjel.Size = new System.Drawing.Size(37, 13);
            this.btn_NazivOdjel.TabIndex = 1;
            this.btn_NazivOdjel.Text = "Naziv:";
            // 
            // btn_Zatvori
            // 
            this.btn_Zatvori.Location = new System.Drawing.Point(699, 466);
            this.btn_Zatvori.Name = "btn_Zatvori";
            this.btn_Zatvori.Size = new System.Drawing.Size(136, 23);
            this.btn_Zatvori.TabIndex = 9;
            this.btn_Zatvori.Text = "Zatvori";
            this.btn_Zatvori.UseVisualStyleBackColor = true;
            this.btn_Zatvori.Click += new System.EventHandler(this.btn_Zatvori_Click);
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 501);
            this.Controls.Add(this.btn_Zatvori);
            this.Controls.Add(this.gb_DodajNoviOdjel);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmMenu";
            this.Text = "Azuriranje podataka";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PopisRadnoMjesto)).EndInit();
            this.gb_DodajNoviOdjel.ResumeLayout(false);
            this.gb_DodajNoviOdjel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_PopisOdjel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_UnesiRadnoMjesto;
        private System.Windows.Forms.TextBox txt_Satnica;
        private System.Windows.Forms.TextBox txt_NazivRadnoMjesto;
        private System.Windows.Forms.Label lbl_Odjel;
        private System.Windows.Forms.ComboBox cmb_Odjel;
        private System.Windows.Forms.Label lbl_Satnica;
        private System.Windows.Forms.Label lbl_NazivRadnogMjesta;
        private System.Windows.Forms.DataGridView dgv_PopisRadnoMjesto;
        private System.Windows.Forms.Label lbl_PopisRadniMjesta;
        private System.Windows.Forms.GroupBox gb_DodajNoviOdjel;
        private System.Windows.Forms.ComboBox cmb_VoditeljOdjela;
        private System.Windows.Forms.Label lbl_PopisOdjela;
        private System.Windows.Forms.DataGridView dgv_PopisOdjel;
        private System.Windows.Forms.Button btn_UnesiOdjel;
        private System.Windows.Forms.TextBox txt_NazivOdjel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label btn_NazivOdjel;
        private System.Windows.Forms.Button btn_Zatvori;
        private System.Windows.Forms.Button btn_ObrisiRadnoMjesto;
        private System.Windows.Forms.Button btn_ObrisiOdjel;
    }
}