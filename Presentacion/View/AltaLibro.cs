using Negocio.EntitiesDTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio.Managment;
using Negocio;

namespace Presentacion.View
{
    public partial class AltaLibro : Form
    {
        public LibrosDTO LibroMod;
        public AltaLibro(LibrosDTO libro)
        {
            this.LibroMod = libro;

            InitializeComponent();
        }
        public AltaLibro()
        {
            InitializeComponent();
        }

        private void btn_Aceptar_Click(object sender, EventArgs e)
        {
            if (this.LibroMod is null != true)
            {
                LibroMod.Nombre = tb_Nombre.Text;
                LibroMod.Autor = tb_Autor.Text;
                LibroMod.idCategoria = new Negocio.Managment.LibroManagment().ObtenerCategorias().Where(b => b.Nombre == cmb_Categoria.Text).First().idCategoria;
                LibroMod.FechaPublicacion = DateTime.Now;

                new Negocio.Managment.LibroManagment().ModificarLibro(LibroMod);

            }
            else
            {
                LibrosDTO libro = new LibrosDTO();
                libro.Nombre = tb_Nombre.Text;
                libro.Autor = tb_Autor.Text;
                libro.idCategoria = new Negocio.Managment.LibroManagment().ObtenerCategorias().Where(b => b.Nombre == cmb_Categoria.Text).First().idCategoria;
                libro.FechaPublicacion = DateTime.Now;

                new Negocio.Managment.LibroManagment().AltaLibro(libro);
            }

            this.Close();
                

        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AltaLibro_Load(object sender, EventArgs e)
        {
            //Cargamos el combo de categorías
            //Seleccionamos que solo nos de el nombre con la lambda expression.
            cmb_Categoria.DataSource = new Negocio.Managment.LibroManagment().ObtenerCategorias().Select(b => b.Nombre).ToList();

            //Si no hay un libro seleccionado
            if (this.LibroMod is null !=true)
            {
                tb_Nombre.Text = LibroMod.Nombre;
                tb_Autor.Text= LibroMod.Autor;
                cmb_Categoria.Text = new Negocio.Managment.LibroManagment().ObtenerCategorias().Where(b => b.idCategoria == LibroMod.idCategoria).First().Nombre;

            }

        }
    }
}
