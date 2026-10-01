using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3NLIDTS_GC_P04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string apellidos = tbApellidos.Text;
            string tel = tbTelefono.Text;
            string edad = tbEdad.Text;
            string estatura = tbEstatura.Text;
            string genero = "";
            if (rbFemenino.Checked)
            {
                genero = "Femenino";
            }
            else if (rbMasculino.Checked)
            {
                genero = "Masculino";
            }
            else if (rbOtros.Checked)
            {
                genero = "Otros";
            }
            string Mensaje = $"Nombre: {nombre}\n\rApellidos: {apellidos}\n\r Telefono: {tel}\n\r" + $"Edad: {edad}\n\r Estatura: {estatura}\n\rGenero: {genero}";
            // Ruta de almacenamiento de archivo TXT
            string rutaArchivo = "C:\\Users\\Gabriela\\OneDrive\\Documentos\\datos.txt";
            bool ArchivoExiste = File.Exists(rutaArchivo);
            //Instanciacion dxe objeto para la creacion de archivo de TxT
            using (StreamWriter escritor = new StreamWriter(rutaArchivo, true))
            {
                if (ArchivoExiste)
                {
                    escritor.WriteLine();
                }
                escritor.WriteLine(Mensaje);
            }
            MessageBox.Show(Mensaje, "Confirmación de registro", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            tbNombre.Clear();
            tbApellidos.Clear();
            tbEdad.Clear();
            tbEstatura.Clear();
            tbTelefono.Clear();
            rbFemenino.Checked = false;
            rbMasculino.Checked = false;
            rbOtros.Checked = false;
        }
    }
}
