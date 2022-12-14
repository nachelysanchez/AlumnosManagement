using AlumnosManagement.Registros;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlumnosManagement
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void materiasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rMaterias materias = new rMaterias();
            materias.Show();
        }

        private void estudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEstudiantes estudiantes = new rEstudiantes();
            estudiantes.Show();
        }
    }
}
