using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    internal class DatosProducto : IDataAccess<Entidades.Producto>
    {
        public IQueryable<Entidades.Producto> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Entidades.Producto BuscarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Entidades.Producto EliminarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Entidades.Producto ModificarUno(string clave)
        {
            throw new NotImplementedException();
        }
    }
}
