using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos.Infrastructure;
namespace Negocio.EntitiesDTO
{
    public class LibroConUnidadesDTO
    {
        public string NombreDelLibro { get; set; }
        public string AutorDelLibro { get; set; }
        public Nullable<int> Unidades { get; set; }
    }


}
