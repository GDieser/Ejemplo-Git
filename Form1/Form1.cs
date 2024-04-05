using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Form1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Boton_Click(object sender, EventArgs e)
        {
            //int a = 1, b = 2;

            //int c = a + b;

            //MessageBox.Show("Resultado: " + c);
            string texto1 = capNombre.Text;
            string texto2 = capApellido.Text;
            string texto3 = capEdad.Text;
            string texto4 = capPuesto.Text;
            lblSaludar.Text = "Hola: " + texto1 + ", " + texto2 + ", Edad: " + texto3 + ", Puesto: " + texto4;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //MessageBox.Show("Nos vemos...");
        }

        private void capSaludo_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string elem = txtElemento.Text;
            lwElementos.Items.Add(elem);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cbColor.Items.Add("Rojo");
            cbColor.Items.Add("Azul");
            cbColor.Items.Add("Verde");
        }

        private void btnPerfil_Click(object sender, EventArgs e)
        {
            string texto1 = capNombre.Text;
            string texto2 = capApellido.Text;
            string texto3 = capEdad.Text;
            string texto4 = capPuesto.Text;
            DateTime fecha = dtpFecha.Value;
        }
    }
}
