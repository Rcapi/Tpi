using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    public class DatosUsuario
    {
        public class Usuario : IDataAccess<Entidades.Usuario>
        {
            public IQueryable<Entidades.Usuario> BuscarTodos()
            {
                using (FerreteriaEntities entities = new FerreteriaEntities())
                {

                    var usuarios = from u in entities.Usuarios
                                   select u;

                    return (IQueryable<Entidades.Usuario>)usuarios;
                };
            }

            public Entidades.Usuario BuscarUno(string clave)
            {
                throw new NotImplementedException();
            }

            public Entidades.Usuario EliminarUno(string clave)
            {
                throw new NotImplementedException();
            }

            public Entidades.Usuario ModificarUno(string clave)
            {
                throw new NotImplementedException();
            }
        }
    }
}
