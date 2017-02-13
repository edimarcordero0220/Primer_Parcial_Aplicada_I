using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parcial1_EdimarC.UI;

namespace Parcial1_EdimarC.UI
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEmpleados re = new RegistroEmpleados();

            re.Show();
        }

        private void empleadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarEmpleados re = new ConsultarEmpleados();

            re.Show();
        }
    }
}
