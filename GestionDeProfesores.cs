using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Codigo_de_los_ultimos_3_codigos
{
    public partial class GestionDeProfesores : Form
    {
        public GestionDeProfesores()
        {
            InitializeComponent();
        }

        private void GestionDeProfesores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarProfesor Opcion1 = new RegistrarProfesor();
            Opcion1.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 Inicio = new Form1();
            Inicio.Show();
        }
    }
}
