namespace TPi_1
{
    public class Usuario
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Dni { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
    }

    public class Cliente : Usuario
    {
        public int NroCli { get; set; }
    }

    public class Empleado : Usuario
    {
        public int Legajo { get; set; }
    }

    public class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
    }

    public class Herramienta : Producto
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
    }

    public class HerramientaElectrica : Herramienta
    {
        public int Potencia { get; set; }
    }

    public class HerramientaManual : Herramienta
    {
        public string Tipo { get; set; }
    }

    public class MaterialDeConstruccion : Producto
    {
        public string TipoMaterial { get; set; }
        public string Medidas { get; set; }
    }

    public class ElementoDeSujecion : Producto
    {
        public string TipoElemento { get; set; }
        public int Capacidad { get; set; }
    }

    public class EquipoDeSeguridad : Producto
    {
        public string TipoEquipo { get; set; }
        public string Normativa { get; set; }
    }

    public class Proveedor
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public List<Producto> ProductosVendidos { get; set; }

        public Proveedor()
        {
            ProductosVendidos = new List<Producto>();
        }

    }
}