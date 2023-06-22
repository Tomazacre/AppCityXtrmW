using FireSharp.Config;
using FireSharp.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using FireSharp.Response;

namespace CityXtremeSport
{
    public partial class DatosAlumnos : Form
    {
        public DatosAlumnos()
        {
            InitializeComponent();
        }

        int contadorUniv = 0;

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

        private void DatosAlumnos_Load(object sender, EventArgs e)
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
            actDat();
        }

        private void actDat()
        {
            FirebaseResponse res = fireCli.Get(@"CitiXtremeSport");
            Dictionary<string, Alumnos> datos = JsonConvert.DeserializeObject<Dictionary<string, Alumnos>>(res.Body.ToString());
            datosGrid(datos);
        }

        void datosGrid(Dictionary<string, Alumnos> rec)
        {
            int aucon = contadorUniv - 1;
            lblNumAlu.Text = aucon.ToString();
            dtgDatAlu.Rows.Clear();
            dtgDatAlu.Columns.Clear();

            dtgDatAlu.Columns.Add("ID","ID");
            dtgDatAlu.Columns.Add("Nombre", "Nombre");
            dtgDatAlu.Columns.Add("Clase", "Clase");
            dtgDatAlu.Columns.Add("Horario", "Horario");
            dtgDatAlu.Columns.Add("Telefono", "Telefono");
            dtgDatAlu.Columns.Add("FechaPag", "Fecha De Pago");

            foreach (var item in rec)
            {
                string nombre =  item.Value.nombre + " " + item.Value.apellidos;
                dtgDatAlu.Rows.Add(item.Key,item.Value.IDAlumno, nombre, item.Value.clase, item.Value.horario, item.Value.telefono, item.Value.fechPago);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            actDat();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnModDat_Click(object sender, EventArgs e)
        {
            string h = dtgDatAlu.CurrentCell.Value.ToString();
            if (h != "")
            {
                ActDatos vent = new ActDatos(h);
                vent.Show();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string h = dtgDatAlu.CurrentCell.Value.ToString();
            var get = fireCli.Delete("CitiXtremeSport/" + h);
        }
    }
}
