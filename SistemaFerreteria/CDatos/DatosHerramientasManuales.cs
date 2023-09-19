using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    internal class DatosHerramientasManuales : IDataAccess<Entidades.HerramientaDeMano>
    {
        public IQueryable<HerramientaDeMano> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public HerramientaDeMano BuscarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public HerramientaDeMano EliminarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public HerramientaDeMano ModificarUno(string clave)
        {
            throw new NotImplementedException();
        }
    }
}
