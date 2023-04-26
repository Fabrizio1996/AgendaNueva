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
    public string Genero { get; set; }
}

class Agenda
{
    private List<Contacto> contactos;

    public Agenda()
    {
        contactos = new List<Contacto>();
    }

    public void AgregarContacto()
    {
        Console.Write("Ingresar el nombre: ");
        string Nombre = Console.ReadLine();

        Console.Write("Ingresar su apellido paterno: ");
        string ApellidoPaterno = Console.ReadLine();
        
        Console.Write("Ingresar su apellido materno: ");
        string ApellidoMaterno = Console.ReadLine();
        
        Console.Write("Ingresar su fecha de nacimiento: ");
        string FechaNacimiento = Console.ReadLine();
        
        Console.Write("Ingresar su correo electronico ");
        string Email = Console.ReadLine();
        
        Console.Write("Ingresar su direccion: ");
        string Direccion = Console.ReadLine();
        
        Console.Write("Ingresar su telefono: ");
        string Telefono = Console.ReadLine();

        Console.Write("Ingresar el genero (M/F): ");
        string Genero = Console.ReadLine().ToUpper();

        if (Genero != "M" && Genero != "F")
        {
            Console.WriteLine("El género ingresado es inválido.");
            return;
        }

        Contacto contacto = new Contacto
        {
            Nombre = Nombre,
            ApellidoPaterno = ApellidoPaterno,
            ApellidoMaterno = ApellidoMaterno,
            FechaNacimiento = FechaNacimiento,
            Email = Email,
            Direccion = Direccion,
            Telefono = Telefono,
            Genero = Genero,
        };

        contactos.Add(contacto);

        Console.WriteLine("El contacto ha sido agregado exitosamente.");
    }

    public void ListarContactos()
    {
        Console.WriteLine("Listado de contactos:");

        foreach (Contacto contacto in contactos)
        {
            Console.WriteLine("Nombre: {0}", contacto.Nombre);
            Console.WriteLine("Apellido Paterno: {0}", contacto.ApellidoPaterno);
            Console.WriteLine("Apellido Materno: {0}", contacto.ApellidoMaterno);
            Console.WriteLine("Fecha de Nacimiento: {0}", contacto.FechaNacimiento);
            Console.WriteLine("Correo Electronico: {0}", contacto.Email);
            Console.WriteLine("Direccion: {0}", contacto.Direccion);
            Console.WriteLine("Teléfono: {0}", contacto.Telefono);
            Console.WriteLine("Genero: {0}", contacto.Genero);
            Console.WriteLine();
        }
    }

    public void ListarContactosPorGenero()
    {
        Console.Write("Ingresar el genero (M/F): ");
        string Genero = Console.ReadLine().ToUpper();

        if (Genero != "M" && Genero != "F")
        {
            Console.WriteLine("El género ingresado es inválido.");
            return;
        }

        Console.WriteLine($"Listado de contactos {Genero}:");
        
        foreach (Contacto contacto in contactos)
        {
            if (contacto.Genero == Genero)
            {
                Console.WriteLine("Nombre: {0}", contacto.Nombre);
                Console.WriteLine("Apellido Paterno: {0}", contacto.ApellidoPaterno);
                Console.WriteLine("Apellido Materno: {0}", contacto.ApellidoMaterno);
                Console.WriteLine("Fecha de Nacimiento: {0}", contacto.FechaNacimiento);
                Console.WriteLine("Correo Electronico: {0}", contacto.Email);
                Console.WriteLine("Direccion: {0}", contacto.Direccion);
                Console.WriteLine("Teléfono: {0}", contacto.Telefono);
                Console.WriteLine("Genero: {0}", contacto.Genero);
                Console.WriteLine();
            }
        }
    }

    public void ReporteCantidadContactos()
    {
        Console.WriteLine($"Cantidad de contactos registrados: {contactos.Count}");
    }
}
class Program
{
    static void Main(string[] args)
    {
        Agenda agenda = new Agenda();

        {
            int opcion = 0;
            
            do
            {
                Console.WriteLine();
                Console.WriteLine("Agenda");
                Console.WriteLine("------");
                Console.WriteLine("1. Agregar contacto");
                Console.WriteLine("2. Listar contactos");
                Console.WriteLine("3. Listar contactos por genero");
                Console.WriteLine("4. Reporte cantidad de contactos registrados");
                Console.WriteLine("5. Salir");
                Console.Write("Ingresar una opcion: ");

                if (int.TryParse(Console.ReadLine(), out opcion))
                
                {
                    switch (opcion)
                    {
                        case 1:
                             agenda.AgregarContacto();
                             break;
                        case 2:
                             agenda.ListarContactos();
                             break;
                        case 3:
                             agenda.ListarContactosPorGenero();
                             break;
                        case 4:
                             agenda.ReporteCantidadContactos();
                             break;
                        case 5:
                             Console.WriteLine("Se cierra la agenda. Hasta Pronto!");
                             return;
                        default:
                             Console.WriteLine("Opcion invalida. Intentarlo nuevamente");
                             break;
                    }
                }
                
                else
                
                {
                    Console.WriteLine("Opción inválida");
                }
                
                Console.WriteLine("Presione una tecla para continuar...");
                Console.ReadKey();
            }
            
            while (opcion != 5);
        }
    }
}
