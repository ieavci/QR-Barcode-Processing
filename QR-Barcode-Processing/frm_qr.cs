using MessagingToolkit.QRCode.Codec;
using MessagingToolkit.QRCode.Codec.Data;
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

namespace QR_Barcode_Processing
{
    public partial class frm_qr : Form
    {
        public frm_qr()
        {
            InitializeComponent();
        }

        private void btn_qr_uret_Click(object sender, EventArgs e)
        {
            try
            {
                if (rdbtn_alphaNum.Checked == true || rdbtn_byte.Checked == true || rdbtn_numeric.Checked == true)
                    pictureBox1.Image = KareKodOlustur(richTextBox1.Text, 4);
                else
                    MessageBox.Show("Lütfen ENCODE_MODE seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception)
            {
                MessageBox.Show("Karakter sınırını aştınız. Lütfen biraz kısaltın", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private Image KareKodOlustur(string giris, int kkDuzey)
        {
            var deger = giris;
            MessagingToolkit.QRCode.Codec.QRCodeEncoder qre = new MessagingToolkit.QRCode.Codec.QRCodeEncoder();

            if (rdbtn_alphaNum.Checked == true)
                qre.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.ALPHA_NUMERIC;

            if (rdbtn_byte.Checked == true)
                qre.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.BYTE;

            if (rdbtn_numeric.Checked == true)
                qre.QRCodeEncodeMode = QRCodeEncoder.ENCODE_MODE.NUMERIC;

            qre.QRCodeErrorCorrect = QRCodeEncoder.ERROR_CORRECTION.L;
            qre.QRCodeVersion = kkDuzey;
            System.Drawing.Bitmap bm = qre.Encode(deger);
            return bm;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

            lbl_karakterSayisi.Text = "Karakter Sayısı : " + richTextBox1.Text.Length.ToString();

        }
        void karekod_cozumle()
        {
            try
            {
                QRCodeDecoder decoder = new QRCodeDecoder();
                richTextBox1.Text = decoder.decode(new QRCodeBitmapImage(pictureBox1.Image as Bitmap));
            }
            catch (MessagingToolkit.QRCode.ExceptionHandler.DecodingFailedException ex)
            {
                MessageBox.Show("Karekod çözümlenemiyor.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_ac_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog()
            {
                Title = "Karekod Seçin",
                Filter = "JPG Dosyası |*.jpg| PNG Dosyası|*.png| GIF Dosyası|*.gif| Bitmap Dosyası|*.bmp",
                FilterIndex = 1,
                RestoreDirectory = true,
                InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop),
            };

            string DosyaYolu;
            if (file.ShowDialog() == DialogResult.OK)
            {
                DosyaYolu = file.FileName;
                pictureBox1.Image = Image.FromFile(DosyaYolu);
                karekod_cozumle();
            }
        }

        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            string filename;
            try
            {
                filename = "KK-" + richTextBox1.Lines[0] + ".jpg";
            }
            catch (IndexOutOfRangeException) // textbox un ilk satırında yazılı bir şey yok ise...
            {
                filename = "KK-" + DateTime.Now.ToString() + ".jpg";
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
                    MessageBox.Show("KareKod kaydedildi.", "Başarılı!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
                MessageBox.Show("Oluşturulmuş bir Karekod bulunamadı.", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
