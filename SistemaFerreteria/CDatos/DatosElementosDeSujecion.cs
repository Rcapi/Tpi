using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    internal class DatosElementosDeSujecion : IDataAccess<Entidades.ElementoDeSujecion>
    {
        public IQueryable<Entidades.ElementoDeSujecion> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Entidades.ElementoDeSujecion BuscarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Entidades.ElementoDeSujecion EliminarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Entidades.ElementoDeSujecion ModificarUno(string clave)
        {
            throw new NotImplementedException();
        }
    }
}
