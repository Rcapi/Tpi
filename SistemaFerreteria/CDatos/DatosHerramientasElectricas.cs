using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    internal class DatosHerramientasElectricas : IDataAccess<Entidades.HerramientaElectrica>
    {
        public IQueryable<Entidades.HerramientaElectrica> BuscarTodos()
        {
            throw new NotImplementedException();
        }

        public Entidades.HerramientaElectrica BuscarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Entidades.HerramientaElectrica EliminarUno(string clave)
        {
            throw new NotImplementedException();
        }

        public Entidades.HerramientaElectrica ModificarUno(string clave)
        {
            throw new NotImplementedException();
        }
    }
}
