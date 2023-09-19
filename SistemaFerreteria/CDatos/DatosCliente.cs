using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    internal class DatosCliente : IDataAccess<Entidades.Cliente>
    {
        public IQueryable<Entidades.Cliente> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Entidades.Cliente BuscarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Entidades.Cliente EliminarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Entidades.Cliente ModificarUno(string clave)
        {
            throw new NotImplementedException();
        }
    }
}
