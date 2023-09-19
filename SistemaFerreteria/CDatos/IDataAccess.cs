using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDatos
{
    internal interface IDataAccess<T>
    {
        T BuscarUno(string clave);

        IQueryable<T> BuscarTodos();


        T ModificarUno(string clave);


        T EliminarUno(string clave);




    }
}
