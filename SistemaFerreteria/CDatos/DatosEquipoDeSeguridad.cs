using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    internal class DatosEquipoDeSeguridad : IDataAccess<Entidades.ElementoDeSeguridad>
    {
        public IQueryable<ElementoDeSeguridad> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public ElementoDeSeguridad BuscarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public ElementoDeSeguridad EliminarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public ElementoDeSeguridad ModificarUno(string clave)
        {
            throw new NotImplementedException();
        }
    }
}
