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

namespace WindowsFormsApp1
{
    public partial class frmQR : Form
    {
        public frmQR()
        {
            InitializeComponent();
        }

        private void btnbarra_Click(object sender, EventArgs e)
        {
            
            Zen.Barcode.Code128BarcodeDraw codigodebarra = Zen.Barcode.BarcodeDrawFactory.Code128WithChecksum;
            imgbarra.Image = codigodebarra.Draw(txtcajabarra.Text,40);
            

           
            var imagentemporal = codigodebarra.Draw(txtcajabarra.Text, 40);
            var imagenconcodigo = new Bitmap(imagentemporal.Width, imagentemporal.Height + 20);

            var x = imagenconcodigo.Width / 2;
            var y = imagenconcodigo.Height;

            using (var vargrafico = Graphics.FromImage(imagenconcodigo))
            using (var varformato = new StringFormat()
            { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Far })
            {
                vargrafico.Clear(Color.White);
                vargrafico.DrawImage(imagentemporal, 2, 2);
                vargrafico.DrawString(txtcajabarra.Text, new Font("", 10), new SolidBrush(Color.Black), x, y, varformato);
            }

            imgbarra.Image = imagenconcodigo;


        }

        private void btnqr_Click(object sender, EventArgs e)
        {

            Zen.Barcode.CodeQrBarcodeDraw codigoqr = Zen.Barcode.BarcodeDrawFactory.CodeQr;
            imgqr.Image = codigoqr.Draw(txtcajaqr.Text, 40);

        }

        private void btnguardarbarra_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "JPEG|*.jpeg";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string varimg = saveFileDialog1.FileName;
                Bitmap varbmp = new Bitmap(imgbarra.Image);
                varbmp.Save(varimg, ImageFormat.Jpeg);
            }
        }

        private void btnguardarqr_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "JPEG|*.jpeg";

            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                string varimg = saveFileDialog1.FileName;
                Bitmap varbmp = new Bitmap(imgqr.Image);
                varbmp.Save(varimg, ImageFormat.Jpeg);
            }
        }
    }
}
