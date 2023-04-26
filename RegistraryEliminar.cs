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

class Agenda 
{
    private List<Contacto> contactos = new List<Contacto>();

    public void AgregarContacto() 
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

        Contacto nuevoContacto = new Contacto();
        nuevoContacto.Nombre = Nombre;
        nuevoContacto.ApellidoPaterno = ApellidoPaterno;
        nuevoContacto.ApellidoMaterno = ApellidoMaterno;
        nuevoContacto.FechaNacimiento = FechaNacimiento;
        nuevoContacto.Email = Email;
        nuevoContacto.Direccion = Direccion;
        nuevoContacto.Telefono = Telefono;

        contactos.Add(nuevoContacto);

        Console.WriteLine("El contacto ha sido agregado.");
    }

    public void MostrarContactos() 
    {
        if (contactos.Count == 0) 
        {
            Console.WriteLine("No hay contactos para mostrar.");
        } 
        
        else 
        {
            foreach (Contacto contacto in contactos) 
            {
                Console.WriteLine("Nombre: {0}", contacto.Nombre);
                Console.WriteLine("Apellido Paterno: {0}", contacto.ApellidoPaterno);
                Console.WriteLine("Apellido Materno: {0}", contacto.ApellidoMaterno);
                Console.WriteLine("Fecha de Nacimiento: {0}", contacto.FechaNacimiento);
                Console.WriteLine("Correo Electronico: {0}", contacto.Email);
                Console.WriteLine("Direccion: {0}", contacto.Direccion);
                Console.WriteLine("Telefono: {0}", contacto.Telefono);
            }
        }
    }

    public void EliminarContacto() {
        Console.WriteLine("Ingresar el nombre del contacto que desea eliminar:");
        string Nombre = Console.ReadLine();

        bool encontrado = false;
        for (int i = 0; i < contactos.Count; i++) {
            if (contactos[i].Nombre == Nombre) {
                contactos.RemoveAt(i);
                encontrado = true;
                break;
            }
        }

        if (encontrado) {
            Console.WriteLine("El contacto ha sido eliminado.");
        } else {
            Console.WriteLine("No se encontró el contacto especificado.");
        }
    }
}

class Program {
    static void Main() 
    {
        Agenda agenda = new Agenda();

        while (true) 
        {
            Console.WriteLine(" ====== Agenda Nueva=====");
            Console.WriteLine("1. Agregar contacto");
            Console.WriteLine("2. Mostrar contactos");
            Console.WriteLine("3. Eliminar contacto");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Seleccionar una opcion:");

            string opcion = Console.ReadLine();

            switch (opcion) {
                case "1":
                    agenda.AgregarContacto();
                    break;
                case "2":
                    agenda.MostrarContactos();
                    break;
                case "3":
                    agenda.EliminarContacto();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Opcion invalida. Ingresar nuevamente otra opcion");
                    break;
            }

            Console.WriteLine();
        }
    }
}