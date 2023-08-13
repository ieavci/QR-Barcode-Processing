namespace QR_Barcode_Processing
{
    partial class frm_Anasayfa
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Anasayfa));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_qrcode = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_barcode = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_kapat = new System.Windows.Forms.Button();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.mainpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_qrcode);
            this.panel1.Controls.Add(this.btn_barcode);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(141, 420);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 58);
            this.label1.TabIndex = 3;
            this.label1.Text = "QR\r\nBarcode\r\nProcessor";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_qrcode
            // 
            this.btn_qrcode.BackColor = System.Drawing.Color.DimGray;
            this.btn_qrcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_qrcode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_qrcode.FlatAppearance.BorderSize = 0;
            this.btn_qrcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_qrcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_qrcode.ForeColor = System.Drawing.Color.White;
            this.btn_qrcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_qrcode.ImageIndex = 1;
            this.btn_qrcode.ImageList = this.ımageList1;
            this.btn_qrcode.Location = new System.Drawing.Point(0, 215);
            this.btn_qrcode.Name = "btn_qrcode";
            this.btn_qrcode.Size = new System.Drawing.Size(141, 41);
            this.btn_qrcode.TabIndex = 2;
            this.btn_qrcode.Text = "QR Code";
            this.btn_qrcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_qrcode.UseVisualStyleBackColor = false;
            this.btn_qrcode.Click += new System.EventHandler(this.btn_qrcode_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "barcode.png");
            this.ımageList1.Images.SetKeyName(1, "qr-code.png");
            // 
            // btn_barcode
            // 
            this.btn_barcode.BackColor = System.Drawing.Color.DimGray;
            this.btn_barcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_barcode.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_barcode.FlatAppearance.BorderSize = 0;
            this.btn_barcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_barcode.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_barcode.ForeColor = System.Drawing.Color.White;
            this.btn_barcode.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_barcode.ImageKey = "barcode.png";
            this.btn_barcode.ImageList = this.ımageList1;
            this.btn_barcode.Location = new System.Drawing.Point(0, 160);
            this.btn_barcode.Name = "btn_barcode";
            this.btn_barcode.Size = new System.Drawing.Size(141, 41);
            this.btn_barcode.TabIndex = 1;
            this.btn_barcode.Text = "Barcode";
            this.btn_barcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_barcode.UseVisualStyleBackColor = false;
            this.btn_barcode.Click += new System.EventHandler(this.btn_barcode_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btn_kapat);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 30);
            this.panel2.TabIndex = 0;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // btn_kapat
            // 
            this.btn_kapat.BackColor = System.Drawing.Color.Gray;
            this.btn_kapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_kapat.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_kapat.FlatAppearance.BorderSize = 0;
            this.btn_kapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_kapat.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_kapat.ForeColor = System.Drawing.Color.White;
            this.btn_kapat.Location = new System.Drawing.Point(766, 3);
            this.btn_kapat.Name = "btn_kapat";
            this.btn_kapat.Size = new System.Drawing.Size(22, 22);
            this.btn_kapat.TabIndex = 0;
            this.btn_kapat.Text = "X";
            this.btn_kapat.UseVisualStyleBackColor = false;
            this.btn_kapat.Click += new System.EventHandler(this.btn_kapat_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.mainpanel.Controls.Add(this.label2);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(141, 30);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(659, 420);
            this.mainpanel.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.IndianRed;
            this.label2.Location = new System.Drawing.Point(264, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 58);
            this.label2.TabIndex = 4;
            this.label2.Text = "QR\r\nBarcode\r\nProcessor";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "frm_Anasayfa";
            this.Text = "QR-Barcode Processor";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.mainpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button btn_kapat;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btn_qrcode;
        private System.Windows.Forms.Button btn_barcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

