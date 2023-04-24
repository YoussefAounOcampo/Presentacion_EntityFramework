using Datos.Infrastructure;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Repositories
{
    public class LibroRepository
    {
        public List<Libros> ObtenerLibros()
        {
            List<Libros> listadoRetorno = new List<Libros>();
            try
            {
                using (var contexto = new BibliotecaEntities())
                {
                    listadoRetorno = contexto.Libros.ToList();
                    return listadoRetorno;
                }

            }
            catch (Exception)
            {
                return listadoRetorno;
            }
        }

        public List<ObtenerLibrosConUnidades_Result> ObtenerLibrosConUnidades()
        {
            List<ObtenerLibrosConUnidades_Result> listadoRetorno = new List<ObtenerLibrosConUnidades_Result>();
            try
            {
                using (var contexto = new BibliotecaEntities())
                {
                    listadoRetorno = contexto.ObtenerLibrosConUnidades().ToList();
                    return listadoRetorno;
                }

            }
            catch (Exception)
            {
                return listadoRetorno;
            }
        }


        public List<Categorias> ObtenerCategorias()
        {
            List<Categorias> listadoRetorno = new List<Categorias>();
            try
            {
                using (var contexto = new BibliotecaEntities())
                {
                    listadoRetorno = contexto.Categorias.ToList();
                    return listadoRetorno;
                }

            }
            catch (Exception)
            {
                return listadoRetorno;
            }
        }

        public void AltaLibro(Libros libroAlta)
        {
            using (var contexto = new BibliotecaEntities())
            {
                contexto.Libros.Add(libroAlta);
                contexto.SaveChanges();
            }
        }

        public void ModificarLibro(Libros nuevoLibro)
        {
            try
            {
                using (var contexto = new BibliotecaEntities())
                {
                    Libros LibroOriginal = contexto.Libros.Where(b => b.idLibro == nuevoLibro.idLibro).First();
                    LibroOriginal.Nombre = nuevoLibro.Nombre;
                    LibroOriginal.Autor = nuevoLibro.Autor;
                    LibroOriginal.idCategoria = nuevoLibro.idCategoria;
                    //Notificamos que la entidad ha sido modificada.
                    contexto.Entry(LibroOriginal).State = System.Data.Entity.EntityState.Modified;
                    contexto.SaveChanges();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        public void EliminarLibro(Int32 idLibro)
        {
            using (var contexto = new BibliotecaEntities())
            {
                List<LibrosUnidades> libroConUnidades = contexto.LibrosUnidades.Where(b => b.idLibro == idLibro).ToList();
                Libros libroEliminar = contexto.Libros.Where(b => b.idLibro == idLibro).First();

                if (libroConUnidades.Count > 0)
                {
                    contexto.LibrosUnidades.RemoveRange(libroConUnidades);
                    contexto.Entry(libroEliminar).State = System.Data.Entity.EntityState.Deleted;
                    contexto.SaveChanges();
                }

                contexto.Entry(libroEliminar).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }
        }

        public Boolean VerificarUnidades(Int32 idLibro)
        {
            List<LibrosUnidades> LibroConUnidades = new List<LibrosUnidades>();

            using (var contexto = new BibliotecaEntities())
            {
                LibroConUnidades = contexto.LibrosUnidades.Where(b => b.idLibro == idLibro).ToList();
            }
            if (LibroConUnidades.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
