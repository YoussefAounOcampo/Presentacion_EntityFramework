using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Infrastructure;
namespace Datos.Repositories
{
    public class PruebaDeConexion
    {

        public Boolean ProbarConexion()
        {
            try
            {
                using (var contexto = new BibliotecaEntities())
                {
                    List<Libros> librosRetorno = contexto.Libros.ToList();
                }
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
    }
}
