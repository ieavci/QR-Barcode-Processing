namespace QR_Barcode_Processing
{
    partial class frm_qr
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
            this.components = new System.ComponentModel.Container();
            this.rdbtn_byte = new System.Windows.Forms.RadioButton();
            this.rdbtn_alphaNum = new System.Windows.Forms.RadioButton();
            this.rdbtn_numeric = new System.Windows.Forms.RadioButton();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip2 = new System.Windows.Forms.ToolTip(this.components);
            this.toolTip3 = new System.Windows.Forms.ToolTip(this.components);
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_karakterSayisi = new System.Windows.Forms.Label();
            this.btn_qr_uret = new System.Windows.Forms.Button();
            this.btn_ac = new System.Windows.Forms.Button();
            this.btn_kaydet = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rdbtn_byte
            // 
            this.rdbtn_byte.AutoSize = true;
            this.rdbtn_byte.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtn_byte.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtn_byte.Location = new System.Drawing.Point(30, 27);
            this.rdbtn_byte.Name = "rdbtn_byte";
            this.rdbtn_byte.Size = new System.Drawing.Size(98, 21);
            this.rdbtn_byte.TabIndex = 0;
            this.rdbtn_byte.TabStop = true;
            this.rdbtn_byte.Text = "BYTE MODE";
            this.toolTip1.SetToolTip(this.rdbtn_byte, "Byte olarak şifrelenir. Tüm karakterler desteklenir.");
            this.rdbtn_byte.UseVisualStyleBackColor = true;
            // 
            // rdbtn_alphaNum
            // 
            this.rdbtn_alphaNum.AutoSize = true;
            this.rdbtn_alphaNum.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtn_alphaNum.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtn_alphaNum.Location = new System.Drawing.Point(30, 65);
            this.rdbtn_alphaNum.Name = "rdbtn_alphaNum";
            this.rdbtn_alphaNum.Size = new System.Drawing.Size(172, 21);
            this.rdbtn_alphaNum.TabIndex = 1;
            this.rdbtn_alphaNum.TabStop = true;
            this.rdbtn_alphaNum.Text = "ALPHA NUMERIC MODE";
            this.toolTip2.SetToolTip(this.rdbtn_alphaNum, "Alfa numeric olarak şifrelenir. Metin girilirse geriye 0 değerini dönderir.");
            this.rdbtn_alphaNum.UseVisualStyleBackColor = true;
            // 
            // rdbtn_numeric
            // 
            this.rdbtn_numeric.AutoSize = true;
            this.rdbtn_numeric.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rdbtn_numeric.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rdbtn_numeric.Location = new System.Drawing.Point(30, 103);
            this.rdbtn_numeric.Name = "rdbtn_numeric";
            this.rdbtn_numeric.Size = new System.Drawing.Size(126, 21);
            this.rdbtn_numeric.TabIndex = 2;
            this.rdbtn_numeric.TabStop = true;
            this.rdbtn_numeric.Text = "NUMERIC MODE";
            this.toolTip3.SetToolTip(this.rdbtn_numeric, "Sayısal olarak şifrelenir. Sadece sayı değeri girmelisiniz.");
            this.rdbtn_numeric.UseVisualStyleBackColor = true;
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip1.ToolTipTitle = "Info";
            // 
            // toolTip2
            // 
            this.toolTip2.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip2.ToolTipTitle = "Info";
            // 
            // toolTip3
            // 
            this.toolTip3.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip3.ToolTipTitle = "Info";
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.Location = new System.Drawing.Point(30, 144);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(358, 150);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.pictureBox1.Location = new System.Drawing.Point(439, 131);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(175, 175);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_karakterSayisi
            // 
            this.lbl_karakterSayisi.AutoSize = true;
            this.lbl_karakterSayisi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_karakterSayisi.Location = new System.Drawing.Point(27, 311);
            this.lbl_karakterSayisi.Name = "lbl_karakterSayisi";
            this.lbl_karakterSayisi.Size = new System.Drawing.Size(107, 17);
            this.lbl_karakterSayisi.TabIndex = 6;
            this.lbl_karakterSayisi.Text = "Karakter Sayısı : ";
            this.lbl_karakterSayisi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // btn_qr_uret
            // 
            this.btn_qr_uret.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_qr_uret.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_qr_uret.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_qr_uret.Location = new System.Drawing.Point(227, 306);
            this.btn_qr_uret.Name = "btn_qr_uret";
            this.btn_qr_uret.Size = new System.Drawing.Size(138, 29);
            this.btn_qr_uret.TabIndex = 7;
            this.btn_qr_uret.Text = "QR Üret";
            this.btn_qr_uret.UseVisualStyleBackColor = true;
            this.btn_qr_uret.Click += new System.EventHandler(this.btn_qr_uret_Click);
            // 
            // btn_ac
            // 
            this.btn_ac.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ac.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ac.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ac.Location = new System.Drawing.Point(423, 325);
            this.btn_ac.Name = "btn_ac";
            this.btn_ac.Size = new System.Drawing.Size(90, 29);
            this.btn_ac.TabIndex = 8;
            this.btn_ac.Text = "Aç";
            this.btn_ac.UseVisualStyleBackColor = true;
            this.btn_ac.Click += new System.EventHandler(this.btn_ac_Click);
            // 
            // btn_kaydet
            // 
            this.btn_kaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_kaydet.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kaydet.Location = new System.Drawing.Point(534, 325);
            this.btn_kaydet.Name = "btn_kaydet";
            this.btn_kaydet.Size = new System.Drawing.Size(90, 29);
            this.btn_kaydet.TabIndex = 9;
            this.btn_kaydet.Text = "Kaydet";
            this.btn_kaydet.UseVisualStyleBackColor = true;
            this.btn_kaydet.Click += new System.EventHandler(this.btn_kaydet_Click);
            // 
            // frm_qr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(659, 420);
            this.Controls.Add(this.btn_kaydet);
            this.Controls.Add(this.btn_ac);
            this.Controls.Add(this.btn_qr_uret);
            this.Controls.Add(this.lbl_karakterSayisi);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.rdbtn_numeric);
            this.Controls.Add(this.rdbtn_alphaNum);
            this.Controls.Add(this.rdbtn_byte);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_qr";
            this.Text = "frm_qr";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdbtn_byte;
        private System.Windows.Forms.RadioButton rdbtn_alphaNum;
        private System.Windows.Forms.RadioButton rdbtn_numeric;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ToolTip toolTip2;
        private System.Windows.Forms.ToolTip toolTip3;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_karakterSayisi;
        private System.Windows.Forms.Button btn_qr_uret;
        private System.Windows.Forms.Button btn_ac;
        private System.Windows.Forms.Button btn_kaydet;
    }
}