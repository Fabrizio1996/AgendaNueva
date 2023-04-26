using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda2
{
    public partial class FormEliminarContacto : Form
    {
        public FormEliminarContacto()
        {
            InitializeComponent();
        }

        private void FormEliminarContacto_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();

            string nombre = txtNombre.Text;

            dtContactos.DataSource = conexion.BuscarContacto(nombre);
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dtContactos.SelectedCells.Count > 0)
            {
                int filaSeleccionadaIndex = dtContactos.SelectedCells[0].RowIndex;
                DataGridViewRow filaSeleccionada = dtContactos.Rows[filaSeleccionadaIndex];
                string celdaValor = Convert.ToString(filaSeleccionada.Cells["id"].Value);

                ConexionBD conexion = new ConexionBD();
                if (conexion.EliminarContacto(celdaValor))
                {
                    MessageBox.Show("SE ELIMINO EL CONTACTO");
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
