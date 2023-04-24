using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Negocio.EntitiesDTO;
using Presentacion.View;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnPrueba_Click(object sender, EventArgs e)
        {
            if (new Negocio.Managment.PruebaDeConexion().pruebaDeConexion())
            {
                lbl_Resultado.Text = "La conexión es correcta";
            }
            else
            {
                lbl_Resultado.Text = "La conexión es fallida.";
            }
            lbl_Resultado.Visible = true;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_AltaLibro_Click(object sender, EventArgs e)
        {
            AltaLibro pantallaAlta = new AltaLibro();
            pantallaAlta.ShowDialog();
            dataGridView1.DataSource = new Negocio.Managment.LibroManagment().ObtenerLibros();

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            //Cogemos el registro seleccionado del grid con el CurrentRow.DataBoundItem
            Negocio.EntitiesDTO.LibrosDTO LibroSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Negocio.EntitiesDTO.LibrosDTO;
            AltaLibro pantallaAlta = new AltaLibro(LibroSeleccionado);
            pantallaAlta.ShowDialog();
            dataGridView1.DataSource = new Negocio.Managment.LibroManagment().ObtenerLibros();

        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                //Cogemos el registro seleccionado del grid con el CurrentRow.DataBoundItem
                Negocio.EntitiesDTO.LibrosDTO LibroSeleccionado = dataGridView1.CurrentRow.DataBoundItem as Negocio.EntitiesDTO.LibrosDTO;
                if (new Negocio.Managment.LibroManagment().VerificarUnidades(LibroSeleccionado.idLibro))
                {
                    DialogResult respuesta = MessageBox.Show("Este libro dispone de unidades" + System.Environment.NewLine + "¿Estás seguro de querer eliminarlo?", "Validación", MessageBoxButtons.YesNo);
                    if (respuesta == DialogResult.Yes)
                    {
                        new Negocio.Managment.LibroManagment().EliminarLibro(LibroSeleccionado);
                         
                    }
                    
                }
                else
                {
                    new Negocio.Managment.LibroManagment().EliminarLibro(LibroSeleccionado);

                }
                dataGridView1.DataSource = new Negocio.Managment.LibroManagment().ObtenerLibros();

            }


        }

        private void dataGriView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Consulta_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Negocio.Managment.LibroManagment().ObtenerLibros();
        }

        private void btn_ConsultaConUnidades_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = new Negocio.Managment.LibroManagment().ObtenerLibrosUnidades();
        }
    }
}
