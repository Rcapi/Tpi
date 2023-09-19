using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    internal class DatosMaterialesDeConstruccion : IDataAccess<Entidades.MaterialesDeConstruccion>
    {
        public IQueryable<MaterialesDeConstruccion> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public MaterialesDeConstruccion BuscarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public MaterialesDeConstruccion EliminarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public MaterialesDeConstruccion ModificarUno(string clave)
        {
            throw new NotImplementedException();
        }
    }
}
