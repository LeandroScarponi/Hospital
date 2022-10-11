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
    public partial class Form1 : Form
    {
        public static Hospital HospitalLeandro = new Hospital();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerMedicos c = new VerMedicos();
            c.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VerPacientes c = new VerPacientes();
            c.ShowDialog();
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            VerPersonas c = new VerPersonas();
            c.ShowDialog();
        }
    }
}
