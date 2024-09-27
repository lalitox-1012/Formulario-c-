using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_c_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // Agregamos controladores de los eventos TextChanged/Leave a los campos
            tbedad.TextChanged += validarEdad;
            tbtelefono.Leave += validarTelefono;
            tbnombre.TextChanged += validarNombre;
            tbapellido.TextChanged += validarApellidos;
            tbestatura.TextChanged += validarEstatura;
        }

        private void bttGuardar_Click(object sender, EventArgs e)
        {
            string nombres = tbnombre.Text;
            string apellidos = tbapellido.Text;
            string edad = tbedad.Text;
            string estatura = tbestatura.Text;
            string telefono = tbtelefono.Text;

            // Selección de género
            string genero = "";
            if (rbMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }

            // Validamos los campos
            if (EsEnteroValido(edad) && EsDecimalValido(estatura) && EsEneteroValido100Digitos(telefono) && EsTextoValido(nombres) && EsTextoValido(apellidos))
            {
                // Crear una cadena con los datos
                string datos = $"Nombres: {nombres}\rApellidos: {apellidos}\rEdad: {edad}\rEstatura: {estatura}\rTeléfono: {telefono}\rGénero: {genero}";

                string ruta = "C:/Users/Eduardo Castillejos/OneDrive/Escritorio/Programación.txt";

                bool archivo_existe = File.Exists(ruta);

                using (StreamWriter writer = new StreamWriter(ruta, true))
                {
                    if (archivo_existe)
                    {
                        writer.WriteLine();
                    }
                    writer.WriteLine(datos);
                    // Mostrar los datos en un MessageBox
                    MessageBox.Show("Datos Guardados con éxito:\n\n" + datos, "Información");
                }
                    
            }
            else
            {
                MessageBox.Show("Alguno de los datos es incorrecto", "Error de registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool EsEnteroValido(string valor)
        {
            int resultado;
            return int.TryParse(valor, out resultado);
        }

        private bool EsDecimalValido(string valor)
        {
            decimal resultado;
            return decimal.TryParse(valor, out resultado);
        }

        private bool EsEneteroValido100Digitos(string valor)
        {
            return valor.Length == 10 && valor.All(char.IsDigit) && long.TryParse(valor, out _);
        }

        private bool EsTextoValido(string valor)
        {
            return Regex.IsMatch(valor, @"^[a-zA-Z\s]+$");
        }

        private void validarEdad(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsEnteroValido(textbox.Text))
            {
                MessageBox.Show("Ingrese una edad válida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void validarEstatura(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsDecimalValido(textbox.Text))
            {
                MessageBox.Show("Ingrese una estatura válida", "Error estatura", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void validarTelefono(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (textbox.Text.Length == 10 && EsEneteroValido100Digitos(textbox.Text))
            {
                textbox.BackColor = Color.Green;
            }
            else
            {
                textbox.BackColor = Color.Red;
                MessageBox.Show("Ingrese un teléfono válido", "Error teléfono", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void validarApellidos(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Ingrese un apellido válido", "Error apellido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void validarNombre(object sender, EventArgs e)
        {
            TextBox textbox = (TextBox)sender;
            if (!EsTextoValido(textbox.Text))
            {
                MessageBox.Show("Ingrese un nombre válido", "Error nombre", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textbox.Clear();
            }
        }

        private void bttCancelar_Click(object sender, EventArgs e)
        {
            tbnombre.Clear();
            tbapellido.Clear();
            tbedad.Clear();
            tbestatura.Clear();
            tbtelefono.Clear();
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
        }
    }
}
