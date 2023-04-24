using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Repositories;
using Datos.Infrastructure;
using Negocio.EntitiesDTO;


namespace Negocio.Managment
{
    public class LibroManagment
    {
        public List<LibrosDTO> ObtenerLibros()
        {
            List<Libros> LibrosDatos = new Datos.Repositories.LibroRepository().ObtenerLibros();
            List<LibrosDTO> ListadoRetorno = new List<LibrosDTO>();
            foreach (var item in LibrosDatos)
            {
                var dto = new LibrosDTO();
                Negocio.Utils.parse(item, ref dto);
                //Comentamos las siguientes lineas ya que al usar Reflection no debemos mapear a mano.
                //dto.idLibro= item.idLibro;
                //dto.Nombre = item.Nombre;
                //dto.Autor = item.Autor;
                //dto.FechaPublicacion = item.FechaPublicacion;
                //dto.idCategoria = item.idCategoria;
                ListadoRetorno.Add(dto);
            }
            return ListadoRetorno;
        }

        public List<LibroConUnidadesDTO> ObtenerLibrosUnidades()
        {
            List<ObtenerLibrosConUnidades_Result> LibrosDatos = new Datos.Repositories.LibroRepository().ObtenerLibrosConUnidades();
            List<LibroConUnidadesDTO> ListadoRetorno = new List<LibroConUnidadesDTO>();
            foreach (var item in LibrosDatos)
            {
                var dto = new LibroConUnidadesDTO();
                Negocio.Utils.parse(item, ref dto);

                //dto.AutorDelLibro = item.AutorDelLibro;
                //dto.NombreDelLibro = item.NombreDelLibro;
                //dto.Unidades = item.Unidades;
                ListadoRetorno.Add(dto);
            }
            return ListadoRetorno;
        }

        public List<CategoriaDTO> ObtenerCategorias()
        {
            List<Categorias> LibrosDatos = new Datos.Repositories.LibroRepository().ObtenerCategorias();
            List<CategoriaDTO> ListadoRetorno = new List<CategoriaDTO>();
            foreach (var item in LibrosDatos)
            {
                var dto = new CategoriaDTO();
                Negocio.Utils.parse(item, ref dto);

                ListadoRetorno.Add(dto);
            }
            return ListadoRetorno;
        }

        public void AltaLibro(LibrosDTO libroAlta)
        {
            Libros LibroBaseDatos = new Libros();
            Negocio.Utils.parse(libroAlta, ref LibroBaseDatos);
            //LibroBaseDatos.idCategoria = libroAlta.idCategoria;
            //LibroBaseDatos.Nombre=libroAlta.Nombre;
            //LibroBaseDatos.Autor=libroAlta.Autor;
            //LibroBaseDatos.FechaPublicacion = libroAlta.FechaPublicacion;
            new Datos.Repositories.LibroRepository().AltaLibro(LibroBaseDatos);
        }

        public void ModificarLibro(LibrosDTO libroModificado)
        {

            Libros LibroBaseDatos = new Libros();
            Negocio.Utils.parse(libroModificado, ref LibroBaseDatos);

            //LibroBaseDatos.idLibro = libroModificado.idLibro;
            //LibroBaseDatos.idCategoria = libroModificado.idCategoria;
            //LibroBaseDatos.Nombre = libroModificado.Nombre;
            //LibroBaseDatos.Autor = libroModificado.Autor;
            //LibroBaseDatos.FechaPublicacion = libroModificado.FechaPublicacion;

            new Datos.Repositories.LibroRepository().ModificarLibro(LibroBaseDatos);

        }

        public void EliminarLibro(LibrosDTO libroEliminar)
        {
            new Datos.Repositories.LibroRepository().EliminarLibro(libroEliminar.idLibro);
        }

        public Boolean VerificarUnidades(Int32 idLibro)
        {
            return new Datos.Repositories.LibroRepository().VerificarUnidades(idLibro);
        }
    }
}
