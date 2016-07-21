namespace wfPakBank_OOP
{
    partial class frmHesapDokumu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHesapDokumu));
            this.btnYazici = new System.Windows.Forms.Button();
            this.btnParaIslemleri = new System.Windows.Forms.Button();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtToplamCekilen = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtToplamYatan = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lvHareketler = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtHesapTuru = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAdi = new System.Windows.Forms.TextBox();
            this.btnbul = new System.Windows.Forms.Button();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ppdHesap = new System.Windows.Forms.PrintPreviewDialog();
            this.pdocHesap = new System.Drawing.Printing.PrintDocument();
            this.SuspendLayout();
            // 
            // btnYazici
            // 
            this.btnYazici.Location = new System.Drawing.Point(317, 480);
            this.btnYazici.Name = "btnYazici";
            this.btnYazici.Size = new System.Drawing.Size(94, 40);
            this.btnYazici.TabIndex = 42;
            this.btnYazici.Text = "Yazıcıya Gönder";
            this.btnYazici.UseVisualStyleBackColor = true;
            this.btnYazici.Click += new System.EventHandler(this.btnYazici_Click);
            // 
            // btnParaIslemleri
            // 
            this.btnParaIslemleri.Location = new System.Drawing.Point(317, 434);
            this.btnParaIslemleri.Name = "btnParaIslemleri";
            this.btnParaIslemleri.Size = new System.Drawing.Size(94, 40);
            this.btnParaIslemleri.TabIndex = 41;
            this.btnParaIslemleri.Text = "Para İşlemleri";
            this.btnParaIslemleri.UseVisualStyleBackColor = true;
            this.btnParaIslemleri.Click += new System.EventHandler(this.btnParaIslemleri_Click);
            // 
            // txtBakiye
            // 
            this.txtBakiye.Location = new System.Drawing.Point(156, 492);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(155, 20);
            this.txtBakiye.TabIndex = 40;
            this.txtBakiye.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(28, 492);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 17);
            this.label9.TabIndex = 39;
            this.label9.Text = "Bakiye";
            // 
            // txtToplamCekilen
            // 
            this.txtToplamCekilen.Location = new System.Drawing.Point(156, 466);
            this.txtToplamCekilen.Name = "txtToplamCekilen";
            this.txtToplamCekilen.ReadOnly = true;
            this.txtToplamCekilen.Size = new System.Drawing.Size(155, 20);
            this.txtToplamCekilen.TabIndex = 38;
            this.txtToplamCekilen.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(28, 466);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(119, 17);
            this.label8.TabIndex = 37;
            this.label8.Text = "Toplam Çekilen";
            // 
            // txtToplamYatan
            // 
            this.txtToplamYatan.Location = new System.Drawing.Point(156, 440);
            this.txtToplamYatan.Name = "txtToplamYatan";
            this.txtToplamYatan.ReadOnly = true;
            this.txtToplamYatan.Size = new System.Drawing.Size(155, 20);
            this.txtToplamYatan.TabIndex = 36;
            this.txtToplamYatan.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(28, 440);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 17);
            this.label7.TabIndex = 35;
            this.label7.Text = "Toplam Yatan";
            // 
            // lvHareketler
            // 
            this.lvHareketler.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lvHareketler.Location = new System.Drawing.Point(29, 255);
            this.lvHareketler.Name = "lvHareketler";
            this.lvHareketler.Size = new System.Drawing.Size(382, 167);
            this.lvHareketler.TabIndex = 34;
            this.lvHareketler.UseCompatibleStateImageBehavior = false;
            this.lvHareketler.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 50;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Hesap No";
            this.columnHeader2.Width = 70;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "İşlem Tarihi";
            this.columnHeader3.Width = 90;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "İşlem Tutarı";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.columnHeader4.Width = 90;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "İşlem Tipi";
            this.columnHeader5.Width = 70;
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(135, 218);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(155, 20);
            this.txtTarih.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(26, 218);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 17);
            this.label6.TabIndex = 32;
            this.label6.Text = "Açılış Tarihi";
            // 
            // txtHesapTuru
            // 
            this.txtHesapTuru.Location = new System.Drawing.Point(135, 175);
            this.txtHesapTuru.Name = "txtHesapTuru";
            this.txtHesapTuru.ReadOnly = true;
            this.txtHesapTuru.Size = new System.Drawing.Size(155, 20);
            this.txtHesapTuru.TabIndex = 31;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(26, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Hesap Türü";
            // 
            // txtTcNo
            // 
            this.txtTcNo.Location = new System.Drawing.Point(135, 133);
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.ReadOnly = true;
            this.txtTcNo.Size = new System.Drawing.Size(155, 20);
            this.txtTcNo.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(26, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 28;
            this.label4.Text = "TC No";
            // 
            // txtSoyadi
            // 
            this.txtSoyadi.Location = new System.Drawing.Point(135, 95);
            this.txtSoyadi.Name = "txtSoyadi";
            this.txtSoyadi.ReadOnly = true;
            this.txtSoyadi.Size = new System.Drawing.Size(155, 20);
            this.txtSoyadi.TabIndex = 27;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 17);
            this.label3.TabIndex = 26;
            this.label3.Text = "Soyadı";
            // 
            // txtAdi
            // 
            this.txtAdi.Location = new System.Drawing.Point(135, 58);
            this.txtAdi.Name = "txtAdi";
            this.txtAdi.ReadOnly = true;
            this.txtAdi.Size = new System.Drawing.Size(155, 20);
            this.txtAdi.TabIndex = 25;
            // 
            // btnbul
            // 
            this.btnbul.Location = new System.Drawing.Point(309, 12);
            this.btnbul.Name = "btnbul";
            this.btnbul.Size = new System.Drawing.Size(102, 40);
            this.btnbul.TabIndex = 24;
            this.btnbul.Text = "BUL";
            this.btnbul.UseVisualStyleBackColor = true;
            this.btnbul.Click += new System.EventHandler(this.btnbul_Click);
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(135, 12);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.Size = new System.Drawing.Size(155, 20);
            this.txtHesapNo.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(26, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Adı";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 21;
            this.label1.Text = "Hesap No";
            // 
            // ppdHesap
            // 
            this.ppdHesap.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.ppdHesap.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.ppdHesap.ClientSize = new System.Drawing.Size(400, 300);
            this.ppdHesap.Document = this.pdocHesap;
            this.ppdHesap.Enabled = true;
            this.ppdHesap.Icon = ((System.Drawing.Icon)(resources.GetObject("ppdHesap.Icon")));
            this.ppdHesap.Name = "ppdHesap";
            this.ppdHesap.Visible = false;
            // 
            // pdocHesap
            // 
            this.pdocHesap.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.pdocHesap_PrintPage_1);
            // 
            // frmHesapDokumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 539);
            this.Controls.Add(this.btnYazici);
            this.Controls.Add(this.btnParaIslemleri);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtToplamCekilen);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtToplamYatan);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lvHareketler);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtHesapTuru);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtTcNo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtSoyadi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAdi);
            this.Controls.Add(this.btnbul);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmHesapDokumu";
            this.Text = "frmHesapDokumu";
            this.Load += new System.EventHandler(this.frmHesapDokumu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYazici;
        private System.Windows.Forms.Button btnParaIslemleri;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtToplamCekilen;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtToplamYatan;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListView lvHareketler;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtHesapTuru;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTcNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAdi;
        private System.Windows.Forms.Button btnbul;
        private System.Windows.Forms.TextBox txtHesapNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PrintPreviewDialog ppdHesap;
        private System.Drawing.Printing.PrintDocument pdocHesap;

    }
}