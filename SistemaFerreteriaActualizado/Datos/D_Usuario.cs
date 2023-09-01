using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using System.Data.SqlClient;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Datos
{

    public class MiDbContext : DbContext
    {

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Empleado> Empleadoes { get; set; }
    }

    public class D_Usuario
    {
        public Usuario ObtenerUsuarioPorDNI(string dni)
        {
            using (var context = new MiDbContext())
            {
                return context.Usuarios.FirstOrDefault(u => u.Dni == dni);
            }
        }


    }
}
