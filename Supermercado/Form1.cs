using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Supermercado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tbc.Appearance = TabAppearance.FlatButtons;
            tbc.ItemSize = new Size(0, 1);
            tbc.SizeMode = TabSizeMode.Fixed;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tbc.SelectedTab = tabPage2;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tbc.SelectedTab = tabPage1;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO clientes(nombre,apellido," +
                    "tipo_doc,nro_doc,nro_tel_princ,nro_tel_sec,email)Values('" + txtNombreCliente.Text + "','" +
                    txtApellidoCliente.Text + "','" +
                    txtTipoDocCliente.Text + "','" + txtNumeroDocCliente.Text + "','" + txtTelefonoPCliente.Text + "','" + txtTelefonoSCliente.Text + "','" + txtCorreoCliente.Text + "')";
            resultado = data.ExecuteQuery(query);
            if (resultado)
            {
                MessageBox.Show("Registro agregado", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al agregar el registro", "Sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
