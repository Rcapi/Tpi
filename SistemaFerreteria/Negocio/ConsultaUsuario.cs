using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CDatos;

namespace Negocio
{
    internal class ConsultaUsuario
    {

        public void TraerTodosUsuarios()
        {
            try
            {
                CDatos.DatosUsuario.Usuario consulta = new CDatos.DatosUsuario.Usuario();
                var resultado = consulta.BuscarTodos();


            }
            catch (Exception ex)
            {
                throw ex;
            }


        }
    }
}
