using FireSharp.Config;
using FireSharp.Interfaces;
using Gma.QrCodeNet.Encoding.Windows.Render;
using Gma.QrCodeNet.Encoding;
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

namespace CityXtremeSport
{
    public partial class ActDatos : Form
    {
        string IDAlu;
        int contadorUniv = 0;

        public ActDatos(string id)
        {
            InitializeComponent();
            lblIdCodePrin.Text = id;
            IDAlu = id;
        }
        

        private void actCont()
        {
            var aux = fireCli.Get("CitiXtremeSport/Contador/Num");
            string al = aux.ResultAs<string>();
            contadorUniv = Int32.Parse(al);
        }

        FirebaseConfig fireConf = new FirebaseConfig()
        {
            AuthSecret = "20328j3JfoRNwLtzyNRMO6fo1T2HChAkFmgxkjmP",
            BasePath = "https://cityxtremesportdb-a63c6-default-rtdb.firebaseio.com/"
        };

        IFirebaseClient fireCli;

        private void ActDatos_Load(object sender, EventArgs e)
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

            var get = fireCli.Get("CitiXtremeSport/" + IDAlu);
            Alumnos alu = get.ResultAs<Alumnos>();

            txtNombre.Text = alu.nombre;
            txtApellido.Text = alu.apellidos;
            cbxClase.SelectedItem = alu.clase;
            txtHorario.Text = alu.horario;
            txtTel.Text = alu.telefono;
            dtpPagoMes.Text = alu.fechPago;
        }

        public void idCodGen()
        {

            QrEncoder qrEn = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qr = new QrCode();

            qrEn.TryEncode(lblIdCodePrin.Text.Trim(), out qr);

            GraphicsRenderer rend = new GraphicsRenderer(new FixedCodeSize(400, QuietZoneModules.Zero), Brushes.Black, Brushes.White);
            MemoryStream ms = new MemoryStream();
            rend.WriteToStream(qr.Matrix, ImageFormat.Png, ms);
            var auxTemp = new Bitmap(ms);
            var img = new Bitmap(auxTemp, new Size(new Point(200, 200)));
            pbCode.BackgroundImage = img;

            img.Save(lblIdCodePrin.Text, ImageFormat.Png);
            btnGuardar.Enabled = true;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Alumnos auxAl = new Alumnos()
            {
                IDAlumno = lblIdCodePrin.Text,
                nombre = txtNombre.Text,
                apellidos = txtApellido.Text,
                clase = cbxClase.SelectedItem.ToString(),
                horario = txtHorario.Text,
                telefono = txtTel.Text,
                fechPago = dtpPagoMes.Text
            };

            var set = fireCli.Update("CitiXtremeSport/" + lblIdCodePrin.Text, auxAl);
            MessageBox.Show("Datos subidos correctamente!");
        }

        private void lblCodigo_TextChanged(object sender, EventArgs e)
        {
            idCodGen();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
