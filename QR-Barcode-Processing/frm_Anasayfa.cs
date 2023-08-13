using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode;
using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;

namespace QR_Barcode_Processing
{
    public partial class frm_Anasayfa : Form
    {
        public frm_Anasayfa()
        {
            InitializeComponent();
        }

        #region form hareket ettirme 
        private bool isDragging = false;
        private Point lastPoint;
        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                int deltaX = e.X - lastPoint.X;
                int deltaY = e.Y - lastPoint.Y;
                this.Location = new Point(this.Location.X + deltaX, this.Location.Y + deltaY);
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            isDragging = false;
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                lastPoint = e.Location;
            }
        }

        #endregion

        

        private void btn_kapat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        #region multiple_form
        public void loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();
        }
        #endregion

        

        private void btn_barcode_Click(object sender, EventArgs e)
        {
            loadform(new frm_barcode());
        }

        private void btn_qrcode_Click(object sender, EventArgs e)
        {
            loadform(new frm_qr());
        }
    }
}
