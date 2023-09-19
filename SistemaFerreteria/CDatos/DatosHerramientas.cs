using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    internal class DatosHerramientas : IDataAccess<Entidades.Herramientas>
    {
        public IQueryable<Herramientas> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Herramientas BuscarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Herramientas EliminarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Herramientas ModificarUno(string clave)
        {
            throw new NotImplementedException();
        }
    }
}
