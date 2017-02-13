using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Parcial1_EdimarC.Entidades;
using Parcial1_EdimarC.BLL;

namespace Parcial1_EdimarC.UI
{
    public partial class RegistroEmpleados : Form
    {
        public RegistroEmpleados()
        {
            InitializeComponent();
        }
        Utilidades util = new Utilidades();
        private void LlenarClase(Empleados e)
        {
            e.Nombres = NombretextBox.Text;
            e.FechaNacimiento = fechadateTimePicker1.Value;
            //SueldotextBox.Text = e.sueldo;
           
            
        }
        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            

            if (IdtextBox.Text == "" || NombretextBox.Text == "" || SueldotextBox.Text == "")
            {
                MessageBox.Show("Existen Campos Vacio, favor llene completamente");
            }
            else
            {
                Empleados empleado = new Empleados();
                LlenarClase(empleado);
                EmpleadosBLL.Guardar(empleado);
                MessageBox.Show("Registro Exitoso!!!");
            }
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            ValidarBuscar();
            BuscarEmpleado(EmpleadosBLL.Buscar(String(IdtextBox.Text)));
            
        }
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }
        private void LlenarEmpleado(Empleados empleado)
        {
            IdtextBox.Text = empleado.EmpleadoId.ToString();
            NombretextBox.Text = empleado.Nombres;
            fechadateTimePicker1.Value = empleado.FechaNacimiento;
        }
        public void BuscarEmpleado(Empleados empleado)
        {
            if (IdtextBox.Text == "")
            {
               
                MessageBox.Show("Para hacer una busqueda de Usuario debe ingresar el ID");
                
            }
            else
            {

                IdtextBox.Text = empleado.EmpleadoId.ToString();
                NombretextBox.Text = empleado.Nombres.ToString();
                fechadateTimePicker1.Value = empleado.FechaNacimiento;
                


            }
            
        }
        private bool ValidarBuscar()
        {
            if (EmpleadosBLL.Buscar(String(IdtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;

            }

            return true;


        }
        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            

        }

        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            if (IdtextBox.Text == "")
            {
                MessageBox.Show("Debe ingresar el Id");
            }
            else {
                EmpleadosBLL.Eliminar(util.String(IdtextBox.Text));
                MessageBox.Show("Eliminado");
            }
        }

        private void Nuevobutton_Click_1(object sender, EventArgs e)
        {
            IdtextBox.Text = "";
            NombretextBox.Text = "";
            SueldotextBox.Text = "";
        }
    }
}
