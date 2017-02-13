using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parcial1_EdimarC.BLL;
using Parcial1_EdimarC.UI;
using Parcial1_EdimarC.Entidades;

namespace Parcial1_EdimarC.UI
{
    public partial class ConsultarEmpleados : Form
    {
        public ConsultarEmpleados()
        {
            InitializeComponent();
        }
        private void CargarEmpleados()
        {
            while (true)
            {
                var lista = EmpleadosBLL.GetLista();
                if (lista.Count() <= 0)
                {
                    MessageBox.Show("Por favor, registre al menos 1 'Productor' antes\nde continuar con este proceso", "-- No Hay Productores Registrados --", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    var ventana = new RegistroEmpleados();
                    ventana.ShowDialog();
                }
                else
                {
                    EmpleadocomboBox.DataSource = lista;
                    EmpleadocomboBox.ValueMember = "EmpleadoId";
                    EmpleadocomboBox.DisplayMember = "Nombres";
                    break;
                }
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (ValidarConsulta() == true) ;
            BuscarCombo();

        }
        Utilidades util = new Utilidades();
        public List<Empleados> lista = new List<Empleados>();

        private void BuscarCombo()
        {
            if (EmpleadocomboBox.SelectedIndex == 0)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = EmpleadosBLL.GetLista(util.String(BuscartextBox.Text));
                }
                else
                {
                    lista = EmpleadosBLL.GetLista();
                }
                filtrardataGridView1.DataSource = lista;
            }
            if (EmpleadocomboBox.SelectedIndex == 1)
            {
                if (!String.IsNullOrEmpty(BuscartextBox.Text))
                {
                    lista = EmpleadosBLL.GetListaNombre(BuscartextBox.Text);
                }
                else
                {
                    lista = EmpleadosBLL.GetLista();
                }
                filtrardataGridView1.DataSource = lista;
            }



        }

        private bool ValidarConsulta()
        {
            if (EmpleadocomboBox.SelectedIndex == 5)
            {
                if (desdedateTimePicker1.Value == hastadateTimePicker2.Value)
                {
                    MessageBox.Show("Favor definir una fecha entre las fechas ");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (string.IsNullOrEmpty(BuscartextBox.Text))
            {
                errorProvider1.SetError(BuscartextBox, "Ingrese el campo");
                return true;
            }
            if (EmpleadocomboBox.SelectedIndex == 1 && EmpleadosBLL.GetListaNombre(BuscartextBox.Text).Count == 0)
            {
                MessageBox.Show("No existe registro con este campo de filtro intertar con otro por favor");
                return false;
            }


            errorProvider1.Clear();
            return true;
        }

        private void Cargar()
        {
           
            EmpleadocomboBox.Items.Insert(0, "Nombre");
            EmpleadocomboBox.Items.Insert(1, "Fecha");
            
        }

        private void ConsultarEmpleados_Load(object sender, EventArgs e)
        {
            
            Cargar();
        
    }
    }
}
