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
    public partial class VerMedicos : Form
    {
        public VerMedicos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void VerMedicos_Load(object sender, EventArgs e)
        {
            List<Persona> lista = Form1.HospitalLeandro.ListaGeneralPersonas;
            foreach(Persona p in lista)
            {
                if (p.GetType() == typeof(Medico))
                    listMedicos.Items.Add(p);
            }
        }

        private void listMedicos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Medico seleccionado = (Medico)listMedicos.SelectedItem;

            Form1.HospitalLeandro.ListaGeneralPersonas.Remove(seleccionado);
            listMedicos.Items.Remove(seleccionado);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AgregarMedico c = new AgregarMedico();
            c.ShowDialog();
        }
    }
}
