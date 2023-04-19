using System;
using System.Collections.Generic;

class Contacto {
    public string Nombre { get; set; }
    public string ApellidoPaterno { get; set; }
    public string ApellidoMaterno { get; set; }
    public string Telefono { get; set; }
    public string FechaNacimiento { get; set; }
    public string CorreoElectronico { get; set; }
}

class Agenda {
    static void Main(string[] args) {
        List<Contacto> contactos = new List<Contacto>();

        // Insertar un nuevo contacto
        Contacto nuevoContacto = new Contacto();
        Console.Write("Ingresar su nombre: ");
        nuevoContacto.Nombre = Console.ReadLine();
        Console.Write("Ingresar su apellido parterno: ");
        nuevoContacto.ApellidoPaterno = Console.ReadLine();
        Console.Write("Ingresar su apellido materno: ");
        nuevoContacto.ApellidoMaterno = Console.ReadLine();
        Console.Write("Ingresar su telefono: ");
        nuevoContacto.Telefono = Console.ReadLine();
        Console.Write("Ingresar su fecha de nacimiento: ");
        nuevoContacto.FechaNacimiento = Console.ReadLine();
        Console.Write("Ingresar su correo electronico: ");
        nuevoContacto.CorreoElectronico = Console.ReadLine();
        contactos.Add(nuevoContacto);

        // Mostrar todos los contactos
        Console.WriteLine("Contactos:");
        foreach (Contacto contacto in contactos) {
            Console.WriteLine("Nombre: {0}", contacto.Nombre);
            Console.WriteLine("ApellidoPaterno: {0}", contacto.ApellidoPaterno);
            Console.WriteLine("ApellidoMaterno: {0}", contacto.ApellidoMaterno);
            Console.WriteLine("Telefono: {0}", contacto.Telefono);
            Console.WriteLine("FechaNacimiento: {0}", contacto.FechaNacimiento);
            Console.WriteLine("CorreoElectronico: {0}", contacto.CorreoElectronico);
            Console.WriteLine();
        }

        Console.ReadKey();
    }
}