using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Response;
using FireSharp.Interfaces;

namespace CityXtremeSport
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();

        }

        FirebaseConfig fireConf = new FirebaseConfig()
        { 
            AuthSecret = "20328j3JfoRNwLtzyNRMO6fo1T2HChAkFmgxkjmP", 
            BasePath = "https://cityxtremesportdb-a63c6-default-rtdb.firebaseio.com/" 
        };

        IFirebaseClient fireCli;
        int contadorUniv = 0;


        public void idCodGen()
        {

            string a = "";

            if (cbxClase.SelectedItem != null)
            {
                if (cbxClase.SelectedItem.Equals("Toros"))
                {
                    a = "tr-";
                }
                if (cbxClase.SelectedItem.Equals("Calistenia"))
                {
                    a = "ca-";
                }
                if (cbxClase.SelectedItem.Equals("Ballet"))
                {
                    a = "ba-";
                }
                if (cbxClase.SelectedItem.Equals("Taekwondo"))
                {
                    a = "tk-";
                }
                if (cbxClase.SelectedItem.Equals("Parkour"))
                {
                    a = "pr-";
                }
                if (cbxClase.SelectedItem.Equals("Twerk"))
                {
                    a = "tw-";
                }
            }

            if (txtNombre.Text.Length >= 3)
            {
                a = a + txtNombre.Text.Substring(0, 3);
            }

            if (txtApellido.Text != "")
            {
                a = a + txtApellido.Text.Substring(0, 1);
            }

            a = a + contadorUniv.ToString();

            a = a.ToUpper();

            lblCodigo.Text = a;

            QrEncoder qrEn = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qr = new QrCode();

            qrEn.TryEncode(a.Trim(), out qr);

            GraphicsRenderer rend = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            rend.WriteToStream(qr.Matrix, ImageFormat.Png, ms);
            var auxTemp = new Bitmap(ms);
            var img = new Bitmap(auxTemp, new Size(new Point(200, 200)));
            pbCode.BackgroundImage = img;
            if (a != "")
            {
                img.Save(a, ImageFormat.Png);
            }
            if (a.Length >= 6)
            {
                btnGuardar.Enabled = true;
            }


        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            idCodGen();
            
        }

        private void cbxClase_SelectedIndexChanged(object sender, EventArgs e)
        {
            idCodGen();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            idCodGen();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                fireCli = new FireSharp.FirebaseClient(fireConf);
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo conectar a la Base de Datos");
            }
            actCont();
        }

        private void actCont()
        {
            var aux = fireCli.Get("CitiXtremeSport/Contador/Num");
            string al = aux.ResultAs<string>();
            contadorUniv = Int32.Parse(al);
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Image img = (Image)pbCode.BackgroundImage.Clone();
            SaveFileDialog save = new SaveFileDialog();
            save.AddExtension = true;
            save.Filter = "Image PNG (*.png)|*.png";
            save.ShowDialog();
            if (!string.IsNullOrEmpty(save.FileName))
            {
                img.Save(save.FileName, ImageFormat.Png);
            }
            img.Dispose();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Alumnos auxAl = new Alumnos()
            {
                IDAlumno = lblCodigo.Text,
                nombre = txtNombre.Text,
                apellidos = txtApellido.Text,
                clase = cbxClase.SelectedItem.ToString(),
                horario = txtHorario.Text,
                telefono = txtTel.Text,
                fechPago = dtpPagoMes.Text
            };

            int auxC = contadorUniv + 1;

            Alumnos auxCont = new Alumnos()
            {
                Num = auxC.ToString()
            };

            var set = fireCli.Set("CitiXtremeSport/"+lblCodigo.Text,auxAl);
            var setvd = fireCli.Set("CitiXtremeSport/Contador", auxCont);
            MessageBox.Show("Datos subidos correctamente!");
            actCont();

            txtApellido.Text = "";
            txtHorario.Text = "";
            txtNombre.Text = "";
            txtTel.Text = "";
            cbxClase.SelectedItem = null;
            lblCodigo.Text = "---------";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}