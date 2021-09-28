using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaControlador;

namespace CapaVista
{
    public partial class frmLinea : Form
    {
        Controlador conAplicacion = new Controlador();
        public frmLinea()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {

                conAplicacion.insertarLinea(txtCodigo.Text, txtNombre.Text, txtEstatus.Text);
                MessageBox.Show("Insercion realizada");
                funLimpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
            actualizarTabla();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                conAplicacion.modificarLinea(txtCodigo.Text, txtNombre.Text, txtEstatus.Text);
                MessageBox.Show("Modificacion realizada");
                funLimpiar();
                actualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: Debes llenar todos los campos");
            }
        }
        public void funLimpiar()
        {
            txtEstatus.Text = "";
            txtCodigo.Text = "";
            txtNombre.Text = "";
            btnActivo.Checked = false;
            btnInactivo.Checked = false;
           

        }

        public void actualizarTabla()
        {
            try
            {
                //this.aplicacionTableAdapter1.Fill(this.dataSet1.aplicacion);
                //CapaVista.deporteTableAdapter.Fill(vista.vwDeportes.deporte);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            funLimpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                conAplicacion.eliminarLinea(txtCodigo.Text);
                MessageBox.Show("Eliminacion realizada");
                funLimpiar();
                actualizarTabla();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: No has ingresado Id del registro a eliminar");
            }
        }

        private void btnActivo_CheckedChanged(object sender, EventArgs e)
        {
            txtEstatus.Text = "1";
        }

        private void btnInactivo_CheckedChanged(object sender, EventArgs e)
        {
            txtEstatus.Text = "0";
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = "";
                string estatus="";
                conAplicacion.buscarLinea(txtCodigo.Text, nombre, estatus);
                txtNombre.Text = nombre;
                txtEstatus.Text = estatus;
                MessageBox.Show("Busqueda exitosa");
                funLimpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex);
            }
        }

        private void txtEstatus_TextChanged(object sender, EventArgs e)
        {

        }

        private void gbxEstado_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
