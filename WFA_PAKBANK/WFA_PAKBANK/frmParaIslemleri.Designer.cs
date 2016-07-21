namespace WFA_PAKBANK
{
    partial class frmParaIslemleri
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
            this.txtHesapId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtHesapNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTarih = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.cbIslemTipleri = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnTamam = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap ID";
            // 
            // txtHesapId
            // 
            this.txtHesapId.Location = new System.Drawing.Point(169, 42);
            this.txtHesapId.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapId.Name = "txtHesapId";
            this.txtHesapId.ReadOnly = true;
            this.txtHesapId.Size = new System.Drawing.Size(199, 23);
            this.txtHesapId.TabIndex = 1;
            this.txtHesapId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 74);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hesap No";
            // 
            // txtHesapNo
            // 
            this.txtHesapNo.Location = new System.Drawing.Point(169, 68);
            this.txtHesapNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtHesapNo.Name = "txtHesapNo";
            this.txtHesapNo.ReadOnly = true;
            this.txtHesapNo.Size = new System.Drawing.Size(199, 23);
            this.txtHesapNo.TabIndex = 1;
            this.txtHesapNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 111);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Açılış Tarihi";
            // 
            // txtTarih
            // 
            this.txtTarih.Location = new System.Drawing.Point(169, 105);
            this.txtTarih.Margin = new System.Windows.Forms.Padding(4);
            this.txtTarih.Name = "txtTarih";
            this.txtTarih.ReadOnly = true;
            this.txtTarih.Size = new System.Drawing.Size(199, 23);
            this.txtTarih.TabIndex = 1;
            this.txtTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 179);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Tutar";
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(169, 173);
            this.txtTutar.Margin = new System.Windows.Forms.Padding(4);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(199, 23);
            this.txtTutar.TabIndex = 1;
            // 
            // cbIslemTipleri
            // 
            this.cbIslemTipleri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIslemTipleri.FormattingEnabled = true;
            this.cbIslemTipleri.Items.AddRange(new object[] {
            "yatan",
            "cekilen"});
            this.cbIslemTipleri.Location = new System.Drawing.Point(169, 205);
            this.cbIslemTipleri.Margin = new System.Windows.Forms.Padding(4);
            this.cbIslemTipleri.Name = "cbIslemTipleri";
            this.cbIslemTipleri.Size = new System.Drawing.Size(199, 24);
            this.cbIslemTipleri.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(48, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 17);
            this.label8.TabIndex = 10;
            this.label8.Text = "İşlem Tipi";
            // 
            // btnTamam
            // 
            this.btnTamam.Location = new System.Drawing.Point(268, 253);
            this.btnTamam.Margin = new System.Windows.Forms.Padding(4);
            this.btnTamam.Name = "btnTamam";
            this.btnTamam.Size = new System.Drawing.Size(100, 28);
            this.btnTamam.TabIndex = 11;
            this.btnTamam.Text = "Tamam";
            this.btnTamam.UseVisualStyleBackColor = true;
            this.btnTamam.Click += new System.EventHandler(this.btnTamam_Click);
            // 
            // frmParaIslemleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(434, 321);
            this.Controls.Add(this.btnTamam);
            this.Controls.Add(this.cbIslemTipleri);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTarih);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtHesapNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtHesapId);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmParaIslemleri";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Para İşlemleri";
            this.Load += new System.EventHandler(this.frmParaIslemleri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ComboBox cbIslemTipleri;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnTamam;
        public System.Windows.Forms.TextBox txtHesapId;
        public System.Windows.Forms.TextBox txtHesapNo;
    }
}