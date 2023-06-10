namespace WinFormsApp1
{
    partial class DersAdi
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtAd = new TextBox();
            txtSurname = new TextBox();
            txtFinal = new TextBox();
            txtVize = new TextBox();
            lblAd = new Label();
            lblSoyad = new Label();
            lblVize = new Label();
            lblFinal = new Label();
            lblDersAdi = new Label();
            btnKaydet = new Button();
            lbOgrenciListesi = new ListBox();
            cmbDersAdi = new System.Windows.Forms.ComboBox();
            chkAA = new CheckBox();
            chkBA = new CheckBox();
            chkCB = new CheckBox();
            chkBB = new CheckBox();
            chkDD = new CheckBox();
            chkCC = new CheckBox();
            btnListele = new Button();
            chkTumu = new CheckBox();
            cmbDersListele = new System.Windows.Forms.ComboBox();
            SuspendLayout();
            // 
            // txtAd
            // 
            txtAd.Location = new Point(127, 38);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(125, 27);
            txtAd.TabIndex = 0;
            // 
            // txtSurname
            // 
            txtSurname.Location = new Point(127, 71);
            txtSurname.Name = "txtSurname";
            txtSurname.Size = new Size(125, 27);
            txtSurname.TabIndex = 1;
            // 
            // txtFinal
            // 
            txtFinal.Location = new Point(127, 135);
            txtFinal.Name = "txtFinal";
            txtFinal.Size = new Size(125, 27);
            txtFinal.TabIndex = 3;
            // 
            // txtVize
            // 
            txtVize.Location = new Point(127, 102);
            txtVize.Name = "txtVize";
            txtVize.Size = new Size(125, 27);
            txtVize.TabIndex = 4;
            // 
            // lblAd
            // 
            lblAd.AutoSize = true;
            lblAd.Location = new Point(26, 45);
            lblAd.Name = "lblAd";
            lblAd.Size = new Size(28, 20);
            lblAd.TabIndex = 5;
            lblAd.Text = "Ad";
            // 
            // lblSoyad
            // 
            lblSoyad.AutoSize = true;
            lblSoyad.Location = new Point(26, 78);
            lblSoyad.Name = "lblSoyad";
            lblSoyad.Size = new Size(50, 20);
            lblSoyad.TabIndex = 6;
            lblSoyad.Text = "Soyad";
            // 
            // lblVize
            // 
            lblVize.AutoSize = true;
            lblVize.Location = new Point(26, 109);
            lblVize.Name = "lblVize";
            lblVize.Size = new Size(37, 20);
            lblVize.TabIndex = 7;
            lblVize.Text = "Vize";
            // 
            // lblFinal
            // 
            lblFinal.AutoSize = true;
            lblFinal.Location = new Point(26, 142);
            lblFinal.Name = "lblFinal";
            lblFinal.Size = new Size(40, 20);
            lblFinal.TabIndex = 8;
            lblFinal.Text = "Final";
            // 
            // lblDersAdi
            // 
            lblDersAdi.AutoSize = true;
            lblDersAdi.Location = new Point(26, 171);
            lblDersAdi.Name = "lblDersAdi";
            lblDersAdi.Size = new Size(66, 20);
            lblDersAdi.TabIndex = 9;
            lblDersAdi.Text = "Ders Adı";
            // 
            // btnKaydet
            // 
            btnKaydet.Location = new Point(158, 202);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(94, 29);
            btnKaydet.TabIndex = 10;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = true;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // lbOgrenciListesi
            // 
            lbOgrenciListesi.FormattingEnabled = true;
            lbOgrenciListesi.ItemHeight = 20;
            lbOgrenciListesi.Location = new Point(304, 38);
            lbOgrenciListesi.Name = "lbOgrenciListesi";
            lbOgrenciListesi.Size = new Size(771, 404);
            lbOgrenciListesi.TabIndex = 11;
            // 
            // cmbDersAdi
            // 
            cmbDersAdi.FormattingEnabled = true;
            cmbDersAdi.Location = new Point(127, 168);
            cmbDersAdi.Name = "cmbDersAdi";
            cmbDersAdi.Size = new Size(125, 28);
            cmbDersAdi.TabIndex = 12;
            // 
            // chkAA
            // 
            chkAA.AutoSize = true;
            chkAA.Location = new Point(26, 250);
            chkAA.Name = "chkAA";
            chkAA.Size = new Size(51, 24);
            chkAA.TabIndex = 13;
            chkAA.Text = "AA";
            chkAA.UseVisualStyleBackColor = true;
            chkAA.CheckedChanged += chkNotlar_CheckedChanged;
            // 
            // chkBA
            // 
            chkBA.AutoSize = true;
            chkBA.Location = new Point(92, 250);
            chkBA.Name = "chkBA";
            chkBA.Size = new Size(50, 24);
            chkBA.TabIndex = 14;
            chkBA.Text = "BA";
            chkBA.UseVisualStyleBackColor = true;
            chkBA.CheckedChanged += chkNotlar_CheckedChanged;
            // 
            // chkCB
            // 
            chkCB.AutoSize = true;
            chkCB.Location = new Point(92, 280);
            chkCB.Name = "chkCB";
            chkCB.Size = new Size(49, 24);
            chkCB.TabIndex = 16;
            chkCB.Text = "CB";
            chkCB.UseVisualStyleBackColor = true;
            chkCB.CheckedChanged += chkNotlar_CheckedChanged;
            // 
            // chkBB
            // 
            chkBB.AutoSize = true;
            chkBB.Location = new Point(26, 280);
            chkBB.Name = "chkBB";
            chkBB.Size = new Size(49, 24);
            chkBB.TabIndex = 15;
            chkBB.Text = "BB";
            chkBB.UseVisualStyleBackColor = true;
            chkBB.CheckedChanged += chkNotlar_CheckedChanged;
            // 
            // chkDD
            // 
            chkDD.AutoSize = true;
            chkDD.Location = new Point(91, 310);
            chkDD.Name = "chkDD";
            chkDD.Size = new Size(53, 24);
            chkDD.TabIndex = 18;
            chkDD.Text = "DD";
            chkDD.UseVisualStyleBackColor = true;
            chkDD.CheckedChanged += chkNotlar_CheckedChanged;
            // 
            // chkCC
            // 
            chkCC.AutoSize = true;
            chkCC.Location = new Point(25, 310);
            chkCC.Name = "chkCC";
            chkCC.Size = new Size(49, 24);
            chkCC.TabIndex = 17;
            chkCC.Text = "CC";
            chkCC.UseVisualStyleBackColor = true;
            chkCC.CheckedChanged += chkNotlar_CheckedChanged;
            // 
            // btnListele
            // 
            btnListele.Location = new Point(158, 280);
            btnListele.Name = "btnListele";
            btnListele.Size = new Size(115, 29);
            btnListele.TabIndex = 19;
            btnListele.Text = "Listele";
            btnListele.UseVisualStyleBackColor = true;
            btnListele.Click += btnListele_Click;
            // 
            // chkTumu
            // 
            chkTumu.AutoSize = true;
            chkTumu.Location = new Point(25, 340);
            chkTumu.Name = "chkTumu";
            chkTumu.Size = new Size(112, 24);
            chkTumu.TabIndex = 20;
            chkTumu.Text = "Tümünü seç.";
            chkTumu.UseVisualStyleBackColor = true;
            chkTumu.CheckedChanged += chkTumu_CheckedChanged;
            // 
            // cmbDersListele
            // 
            cmbDersListele.FormattingEnabled = true;
            cmbDersListele.Location = new Point(158, 246);
            cmbDersListele.Name = "cmbDersListele";
            cmbDersListele.Size = new Size(115, 28);
            cmbDersListele.TabIndex = 21;
            // 
            // DersAdi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 450);
            Controls.Add(cmbDersListele);
            Controls.Add(chkTumu);
            Controls.Add(btnListele);
            Controls.Add(chkDD);
            Controls.Add(chkCC);
            Controls.Add(chkCB);
            Controls.Add(chkBB);
            Controls.Add(chkBA);
            Controls.Add(chkAA);
            Controls.Add(cmbDersAdi);
            Controls.Add(lbOgrenciListesi);
            Controls.Add(btnKaydet);
            Controls.Add(lblDersAdi);
            Controls.Add(lblFinal);
            Controls.Add(lblVize);
            Controls.Add(lblSoyad);
            Controls.Add(lblAd);
            Controls.Add(txtVize);
            Controls.Add(txtFinal);
            Controls.Add(txtSurname);
            Controls.Add(txtAd);
            Name = "DersAdi";
            Text = "Form1";
            Load += DersAdi_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtAd;
        private TextBox txtSurname;
        private TextBox txtFinal;
        private TextBox txtVize;
        private Label lblAd;
        private Label lblSoyad;
        private Label lblVize;
        private Label lblFinal;
        private Label lblDersAdi;
        private Button btnKaydet;
        private ListBox lbOgrenciListesi;
        private ComboBox comboBox1;
        private System.Windows.Forms.ComboBox cmbDersAdi;
        private CheckBox chkAA;
        private CheckBox chkBA;
        private CheckBox chkCB;
        private CheckBox chkBB;
        private CheckBox chkDD;
        private CheckBox chkCC;
        private Button btnListele;
        private CheckBox chkTumu;
        private System.Windows.Forms.ComboBox cmbDersListele;
    }
}