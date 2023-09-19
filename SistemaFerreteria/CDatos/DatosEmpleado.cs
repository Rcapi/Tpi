using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    internal class DatosEmpleado : IDataAccess<Entidades.Empleado>
    {
        public IQueryable<Entidades.Empleado> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Entidades.Empleado BuscarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Entidades.Empleado EliminarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Entidades.Empleado ModificarUno(string clave)
        {
            throw new NotImplementedException();
        }
    }
}
