using System;
using System.Collections.Generic;

class Contacto
{
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public string FechaNacimiento { get; set; }
    public string Email { get; set; }
    public string Direccion { get; set; }
    public string Telefono { get; set; }
}

class Program
{
    static List<Contacto> contactos = new List<Contacto>();

    static void Main(string[] args)
    {
        bool salir = false;

        while (!salir)
        {
            Console.WriteLine("----- AGENDA DE CONTACTOS -----");
            Console.WriteLine("1. Registrar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Salir");
            Console.WriteLine("--------------------------------");

            Console.Write("Ingresar la opcion que desee: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RegistrarContacto();
                    break;
                case "2":
                    MostrarContactos();
                    break;
                case "3":
                    salir = true;
                    break;
                default:
                    Console.WriteLine("Opción inválida. Por favor ingresar nuevamente otra opcion");
                    break;
            }

            Console.WriteLine();
        }
    }

    static void RegistrarContacto()
    {
        Console.Write("Ingresar el nombre del contacto: ");
        string Nombre = Console.ReadLine();

        Console.Write("Ingresar el apellido paterno del contacto: ");
        string ApellidoPaterno = Console.ReadLine();
        
        Console.Write("Ingresar el apellido materno del contacto: ");
        string ApellidoMaterno = Console.ReadLine();
        
        Console.Write("Ingresar la fecha de nacimiento del contacto: ");
        string FechaNacimiento = Console.ReadLine();
        
        Console.Write("Ingresar el correo electronico del contacto: ");
        string Email = Console.ReadLine();
        
        Console.Write("Ingresar la direccion del contacto: ");
        string Direccion = Console.ReadLine();
        
        Console.Write("Ingresar el telefono del contacto: ");
        string Telefono = Console.ReadLine();

        Contacto nuevoContacto = new Contacto { Nombre = Nombre, ApellidoPaterno = ApellidoPaterno, ApellidoMaterno = ApellidoMaterno, FechaNacimiento = FechaNacimiento, Email = Email, Direccion = Direccion, Telefono = Telefono, };
        contactos.Add(nuevoContacto);

        Console.WriteLine("Contacto registrado exitosamente");
    }

    static void MostrarContactos()
    {
        if (contactos.Count == 0)
        {
            Console.WriteLine("No hay contactos registrados");
        }
        else
        {
            Console.WriteLine("----- CONTACTOS REGISTRADOS -----");

            foreach (Contacto contacto in contactos)
            {
                Console.WriteLine("Nombre: {0}", contacto.Nombre);
                Console.WriteLine("Apellido Paterno: {0}", contacto.ApellidoPaterno);
                Console.WriteLine("Apellido Materno: {0}", contacto.ApellidoMaterno);
                Console.WriteLine("Fecha de Nacimiento: {0}", contacto.FechaNacimiento);
                Console.WriteLine("Correo Electronico: {0}", contacto.Email);
                Console.WriteLine("Direccion: {0}", contacto.Direccion);
                Console.WriteLine("Teléfono: {0}", contacto.Telefono);
            }
        }
    }
}