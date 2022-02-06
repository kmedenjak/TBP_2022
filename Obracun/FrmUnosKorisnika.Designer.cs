namespace Obracun
{
    partial class FrmUnosKorisnika
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
            this.lbl_Ime = new System.Windows.Forms.Label();
            this.lbl_Prezime = new System.Windows.Forms.Label();
            this.lbl_Oib = new System.Windows.Forms.Label();
            this.lbl_Telefon = new System.Windows.Forms.Label();
            this.lbl_Email = new System.Windows.Forms.Label();
            this.lbl_Id = new System.Windows.Forms.Label();
            this.dgv_RadnoMjesto = new System.Windows.Forms.DataGridView();
            this.lbl_RadnoMjesto = new System.Windows.Forms.Label();
            this.txt_Oib = new System.Windows.Forms.TextBox();
            this.txt_Ime = new System.Windows.Forms.TextBox();
            this.txt_Prezime = new System.Windows.Forms.TextBox();
            this.txt_Telefon = new System.Windows.Forms.TextBox();
            this.txt_Email = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_UnosNovogKorisnika = new System.Windows.Forms.Label();
            this.btn_Unesi = new System.Windows.Forms.Button();
            this.btn_Odustani = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RadnoMjesto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Ime
            // 
            this.lbl_Ime.AutoSize = true;
            this.lbl_Ime.Location = new System.Drawing.Point(79, 136);
            this.lbl_Ime.Name = "lbl_Ime";
            this.lbl_Ime.Size = new System.Drawing.Size(27, 13);
            this.lbl_Ime.TabIndex = 0;
            this.lbl_Ime.Text = "Ime:";
            // 
            // lbl_Prezime
            // 
            this.lbl_Prezime.AutoSize = true;
            this.lbl_Prezime.Location = new System.Drawing.Point(59, 168);
            this.lbl_Prezime.Name = "lbl_Prezime";
            this.lbl_Prezime.Size = new System.Drawing.Size(47, 13);
            this.lbl_Prezime.TabIndex = 1;
            this.lbl_Prezime.Text = "Prezime:";
            // 
            // lbl_Oib
            // 
            this.lbl_Oib.AutoSize = true;
            this.lbl_Oib.Location = new System.Drawing.Point(78, 104);
            this.lbl_Oib.Name = "lbl_Oib";
            this.lbl_Oib.Size = new System.Drawing.Size(28, 13);
            this.lbl_Oib.TabIndex = 2;
            this.lbl_Oib.Text = "OIB:";
            // 
            // lbl_Telefon
            // 
            this.lbl_Telefon.AutoSize = true;
            this.lbl_Telefon.Location = new System.Drawing.Point(60, 200);
            this.lbl_Telefon.Name = "lbl_Telefon";
            this.lbl_Telefon.Size = new System.Drawing.Size(46, 13);
            this.lbl_Telefon.TabIndex = 3;
            this.lbl_Telefon.Text = "Telefon:";
            // 
            // lbl_Email
            // 
            this.lbl_Email.AutoSize = true;
            this.lbl_Email.Location = new System.Drawing.Point(68, 232);
            this.lbl_Email.Name = "lbl_Email";
            this.lbl_Email.Size = new System.Drawing.Size(38, 13);
            this.lbl_Email.TabIndex = 4;
            this.lbl_Email.Text = "E-mail:";
            // 
            // lbl_Id
            // 
            this.lbl_Id.AutoSize = true;
            this.lbl_Id.Location = new System.Drawing.Point(85, 264);
            this.lbl_Id.Name = "lbl_Id";
            this.lbl_Id.Size = new System.Drawing.Size(21, 13);
            this.lbl_Id.TabIndex = 5;
            this.lbl_Id.Text = "ID:";
            // 
            // dgv_RadnoMjesto
            // 
            this.dgv_RadnoMjesto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_RadnoMjesto.Location = new System.Drawing.Point(64, 352);
            this.dgv_RadnoMjesto.Name = "dgv_RadnoMjesto";
            this.dgv_RadnoMjesto.Size = new System.Drawing.Size(372, 160);
            this.dgv_RadnoMjesto.TabIndex = 7;
            // 
            // lbl_RadnoMjesto
            // 
            this.lbl_RadnoMjesto.AutoSize = true;
            this.lbl_RadnoMjesto.Location = new System.Drawing.Point(60, 336);
            this.lbl_RadnoMjesto.Name = "lbl_RadnoMjesto";
            this.lbl_RadnoMjesto.Size = new System.Drawing.Size(75, 13);
            this.lbl_RadnoMjesto.TabIndex = 8;
            this.lbl_RadnoMjesto.Text = "Radno mjesto:";
            // 
            // txt_Oib
            // 
            this.txt_Oib.Location = new System.Drawing.Point(110, 101);
            this.txt_Oib.Name = "txt_Oib";
            this.txt_Oib.Size = new System.Drawing.Size(235, 20);
            this.txt_Oib.TabIndex = 9;
            // 
            // txt_Ime
            // 
            this.txt_Ime.Location = new System.Drawing.Point(110, 132);
            this.txt_Ime.Name = "txt_Ime";
            this.txt_Ime.Size = new System.Drawing.Size(235, 20);
            this.txt_Ime.TabIndex = 10;
            // 
            // txt_Prezime
            // 
            this.txt_Prezime.Location = new System.Drawing.Point(110, 165);
            this.txt_Prezime.Name = "txt_Prezime";
            this.txt_Prezime.Size = new System.Drawing.Size(235, 20);
            this.txt_Prezime.TabIndex = 11;
            // 
            // txt_Telefon
            // 
            this.txt_Telefon.Location = new System.Drawing.Point(110, 201);
            this.txt_Telefon.Name = "txt_Telefon";
            this.txt_Telefon.Size = new System.Drawing.Size(235, 20);
            this.txt_Telefon.TabIndex = 12;
            // 
            // txt_Email
            // 
            this.txt_Email.Location = new System.Drawing.Point(110, 232);
            this.txt_Email.Name = "txt_Email";
            this.txt_Email.Size = new System.Drawing.Size(235, 20);
            this.txt_Email.TabIndex = 13;
            // 
            // txt_ID
            // 
            this.txt_ID.Location = new System.Drawing.Point(110, 264);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(235, 20);
            this.txt_ID.TabIndex = 14;
            // 
            // lbl_UnosNovogKorisnika
            // 
            this.lbl_UnosNovogKorisnika.AutoSize = true;
            this.lbl_UnosNovogKorisnika.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UnosNovogKorisnika.Location = new System.Drawing.Point(125, 34);
            this.lbl_UnosNovogKorisnika.MaximumSize = new System.Drawing.Size(0, 30);
            this.lbl_UnosNovogKorisnika.Name = "lbl_UnosNovogKorisnika";
            this.lbl_UnosNovogKorisnika.Size = new System.Drawing.Size(193, 30);
            this.lbl_UnosNovogKorisnika.TabIndex = 16;
            this.lbl_UnosNovogKorisnika.Text = "Unos korisnika";
            // 
            // btn_Unesi
            // 
            this.btn_Unesi.Location = new System.Drawing.Point(280, 518);
            this.btn_Unesi.Name = "btn_Unesi";
            this.btn_Unesi.Size = new System.Drawing.Size(75, 23);
            this.btn_Unesi.TabIndex = 17;
            this.btn_Unesi.Text = "Unesi";
            this.btn_Unesi.UseVisualStyleBackColor = true;
            this.btn_Unesi.Click += new System.EventHandler(this.btn_Unesi_Click);
            // 
            // btn_Odustani
            // 
            this.btn_Odustani.Location = new System.Drawing.Point(361, 518);
            this.btn_Odustani.Name = "btn_Odustani";
            this.btn_Odustani.Size = new System.Drawing.Size(75, 23);
            this.btn_Odustani.TabIndex = 18;
            this.btn_Odustani.Text = "Odustani";
            this.btn_Odustani.UseVisualStyleBackColor = true;
            this.btn_Odustani.Click += new System.EventHandler(this.btn_Odustani_Click);
            // 
            // FrmUnosKorisnika
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 567);
            this.Controls.Add(this.btn_Odustani);
            this.Controls.Add(this.btn_Unesi);
            this.Controls.Add(this.lbl_UnosNovogKorisnika);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.txt_Email);
            this.Controls.Add(this.txt_Telefon);
            this.Controls.Add(this.txt_Prezime);
            this.Controls.Add(this.txt_Ime);
            this.Controls.Add(this.txt_Oib);
            this.Controls.Add(this.lbl_RadnoMjesto);
            this.Controls.Add(this.dgv_RadnoMjesto);
            this.Controls.Add(this.lbl_Id);
            this.Controls.Add(this.lbl_Email);
            this.Controls.Add(this.lbl_Telefon);
            this.Controls.Add(this.lbl_Oib);
            this.Controls.Add(this.lbl_Prezime);
            this.Controls.Add(this.lbl_Ime);
            this.Name = "FrmUnosKorisnika";
            this.Text = "Unos korisnika";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_RadnoMjesto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ime;
        private System.Windows.Forms.Label lbl_Prezime;
        private System.Windows.Forms.Label lbl_Oib;
        private System.Windows.Forms.Label lbl_Telefon;
        private System.Windows.Forms.Label lbl_Email;
        private System.Windows.Forms.Label lbl_Id;
        private System.Windows.Forms.DataGridView dgv_RadnoMjesto;
        private System.Windows.Forms.Label lbl_RadnoMjesto;
        private System.Windows.Forms.TextBox txt_Oib;
        private System.Windows.Forms.TextBox txt_Ime;
        private System.Windows.Forms.TextBox txt_Prezime;
        private System.Windows.Forms.TextBox txt_Telefon;
        private System.Windows.Forms.TextBox txt_Email;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_UnosNovogKorisnika;
        private System.Windows.Forms.Button btn_Unesi;
        private System.Windows.Forms.Button btn_Odustani;
    }
}