using MessagingToolkit.QRCode.Codec.Data;
using MessagingToolkit.QRCode.Codec;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZXing;


namespace QR_Barcode_Processing
{
    public partial class frm_barcode : Form
    {
        public frm_barcode()
        {
            InitializeComponent();
        }

        private void btn_barcode_uret_Click(object sender, EventArgs e)
        {
            Zen.Barcode.Code128BarcodeDraw barcode = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            pictureBox1.Image = barcode.Draw(richTextBox1.Text, 50);
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string filename;
            try
            {
                filename = "Barcode-" + richTextBox1.Lines[0] + ".jpg";
            }
            catch (IndexOutOfRangeException) // textbox un ilk satırında yazılı bir şey yok ise...
            {
                filename = "Barcode-" + DateTime.Now.ToString() + ".jpg";
            }

            if (pictureBox1.Image != null)
            {
                SaveFileDialog sf = new SaveFileDialog()
                {
                    Title = "Kaydet",
                    RestoreDirectory = true,
                    Filter = "JPG Dosyası |*.jpg",
                    FileName = filename,
                };
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(sf.FileName, ImageFormat.Jpeg);
                    MessageBox.Show("Barkod kaydedildi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
                MessageBox.Show("Oluşturulmuş bir Barkod bulunamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);


        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter = "JPG|*.jpg" })
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(ofd.FileName);
                    BarcodeReader reader = new BarcodeReader();
                    var result = reader.Decode((Bitmap)pictureBox1.Image);
                    if (result != null)
                        richTextBox1.Text = result.ToString();
                }
            }

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            lbl_karakterSayisi.Text = "Karakter Sayısı : " + richTextBox1.Text.Length.ToString();
        }
    }
}
