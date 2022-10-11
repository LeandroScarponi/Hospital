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
    public partial class VerPacientes : Form
    {
        public VerPacientes()
        {
            InitializeComponent();
        }

       

        private void VerPacientes_Load(object sender, EventArgs e)
        {
            List<Persona> lista = Form1.HospitalLeandro.ListaGeneralPersonas;
            foreach (Persona p in lista)
            {
                if (p.GetType() == typeof(Paciente)) 
                    listPacientes.Items.Add(p);
            }
        }

        private void BorrarPaciente_Click(object sender, EventArgs e)
        {
            Paciente seleccionado = (Paciente)listPacientes.SelectedItem;

            Form1.HospitalLeandro.ListaGeneralPersonas.Remove(seleccionado);
            listPacientes.Items.Remove(seleccionado);
        }
    }
}
