using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using TPi_1;

namespace ConsoleApp
{


    class Program
    {
        private static List<Usuario> Usuarios = new List<Usuario>();
        private static int intentosFallidos = 0;

        static void Main(string[] args)
        {
            Usuarios = new List<Usuario>
            {
                new Cliente { Nombre = "Rodrigo", Apellido = "Capiglioni", Dni = "12345678", Email = "rodrigo@gmail.com", Telefono = "123456789", Direccion = "Zeballos 123", Ciudad = "Rosario", NroCli = 1 },
                new Empleado { Nombre = "Matias", Apellido = "Petrich", Dni = "98765432", Email = "matias@gmail.com", Telefono = "987654321", Direccion = "Corrientes 456", Ciudad = "Rosario", Legajo = 123 }
            };

            Console.WriteLine("¿Qué desea hacer?");
            Console.WriteLine("1. Ingresar");
            Console.WriteLine("2. Registrarse");
            Console.WriteLine("3. Salir");
            bool band = true;
            while (band) {
            Console.Write("Ingrese el número correspondiente a su opción: ");
                string opcion = Console.ReadLine();

                if (opcion == "1")
                {
                    Ingreso();
                }
                else if (opcion == "2")
                {
                    Registro();
                }
                else if (opcion == "3")
                {
                    band = false;
                }
                else
                {
                    Console.WriteLine("Opción inválida");
                }

            Console.ReadKey();
            }
        }




        static void Ingreso()
        {

            Console.Write("Nombre de usuario: ");
            string username = Console.ReadLine();

            Console.Write("Contraseña: ");
            string password = Console.ReadLine();

            Usuario usuario = Usuarios.FirstOrDefault(u => u.Nombre.ToLower() == username.ToLower() && u.Dni == password);

            if (usuario != null)
            {
                if (usuario is Cliente)
                {
                    Console.WriteLine("Bienvenido como cliente");
                    // opciones  cliente
                }
                else if (usuario is Empleado)
                {
                    Console.WriteLine("Bienvenido como empleado");
                    // opciones Empleado
                }
            }
            else
            {
                intentosFallidos++;

                if (intentosFallidos >= 3)
                {
                    Console.WriteLine("Ha excedido el número máximo de intentos fallidos. Cerrando la ventana...");
                    Environment.Exit(0);
                }
                else
                {
                    Console.WriteLine("Usuario o contraseña incorrectos");
                    Ingreso();
                }
            }

            Console.ReadKey();
        }


        static void Registro()
        {
            Console.WriteLine("Bienvenido al registro!");
            Console.WriteLine("Por favor ingrese su nombre");
            string Nombre = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su apellido");
            string Apellido = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su numero de documento");
            string Dni = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su mail");
            string Email = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su telefono");
            string Telefono = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su ciudad");
            string Ciudad = Console.ReadLine();
            Console.WriteLine("Por favor ingrese su direccion");
            string Direccion = Console.ReadLine();

            //preguntar como hacer para registrar si es empleado/cliente
            //se me ocurre hacer un numero autoincremental para cada uno y asignarle el codigo automaticamente
            //pero a la hora de registrarse me parece poco seguro preguntar si quiere registrarse como empleado o cliente
            //ya que el empleado tiene permisos especiales

            bool usuarioExistente = Usuarios.Any(u => u.Dni == Dni);

            if (!usuarioExistente)
            {
                Console.WriteLine("Desea registrarse como cliente o empelado? ingrese 1 para cliente, 2 para empleado");
                int num = int.Parse(Console.ReadLine());
                if (num == 1)
                {
                    Console.WriteLine("Ingrese un numero de cliente");
                    int nroCli = int.Parse(Console.ReadLine());

                    Usuario nuevoUsuario = new Cliente
                    {
                        Nombre = Nombre,
                        Apellido = Apellido,
                        Direccion = Direccion,
                        Email = Email,
                        Telefono = Telefono,
                        Ciudad = Ciudad,
                        Dni = Dni,
                        NroCli = nroCli
                    };

                    Usuarios.Add(nuevoUsuario);
                    Console.WriteLine("Cliente Registrado con exito");
                }
                else if (num == 2)
                {
                    Console.WriteLine("Ingrese su numero de legajo");
                    int legajo = int.Parse(Console.ReadLine());

                    Usuario nuevoUsuario = new Empleado
                    {

                        Nombre = Nombre,
                        Apellido = Apellido,
                        Direccion = Direccion,
                        Email = Email,
                        Telefono = Telefono,
                        Ciudad = Ciudad,
                        Dni = Dni,
                        Legajo = legajo
                    };

                    Usuarios.Add(nuevoUsuario);

                    Console.WriteLine("Empleado Registrado con exito");
                }
                else
                {
                    Console.WriteLine("Opción inválida");
                }
            }
            else
            {
                Console.WriteLine("El DNI ingresado ya esta registrado");
            }


                Console.ReadKey();
            }
        }
    }






