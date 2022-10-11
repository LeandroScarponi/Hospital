using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeandroHospital
{
    public partial class VerPersonas : Form
    {
        public VerPersonas()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listPersonas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void VerPersonas_Load(object sender, EventArgs e)
        {
            List<Persona> lista = Form1.HospitalLeandro.ListaGeneralPersonas;
            foreach(Persona p in lista)
            {
                listPersonas.Items.Add(p);
            }
        }
    }
}
