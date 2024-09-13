// Program.cs
using System;

class Program
{
    static void Main()
    {
        PersonaService personaService = new PersonaService();
        int opcion;

        do
        {
            Console.WriteLine("\nMenú:");
            Console.WriteLine("1. Agregar Persona");
            Console.WriteLine("2. Buscar Persona");
            Console.WriteLine("3. Listar Personas");
            Console.WriteLine("4. Modificar Persona");
            Console.WriteLine("5. Eliminar Persona");
            Console.WriteLine("6. Salir");
            Console.Write("Seleccione una opción: ");
            opcion = int.Parse(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.Write("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.Write("Email: ");
                    string email = Console.ReadLine();
                    Console.Write("Edad: ");
                    int edad = int.Parse(Console.ReadLine());
                    personaService.AgregarPersona(nombre, email, edad);
                    Console.WriteLine("Persona agregada con éxito.");
                    break;
                
                case 2:
                    Console.Write("ID de la persona a buscar: ");
                    int idBuscar = int.Parse(Console.ReadLine());
                    var persona = personaService.BuscarPersona(idBuscar);
                    if (persona != null)
                    {
                        Console.WriteLine($"ID: {persona.Id}, Nombre: {persona.Nombre}, Email: {persona.Email}, Edad: {persona.Edad}");
                    }
                    else
                    {
                        Console.WriteLine("Persona no encontrada.");
                    }
                    break;

                case 3:
                    var personas = personaService.ListarPersonas();
                    foreach (var p in personas)
                    {
                        Console.WriteLine($"ID: {p.Id}, Nombre: {p.Nombre}, Email: {p.Email}, Edad: {p.Edad}");
                    }
                    break;

                case 4:
                    Console.Write("ID de la persona a modificar: ");
                    int idModificar = int.Parse(Console.ReadLine());
                    Console.Write("Nuevo Nombre: ");
                    string nuevoNombre = Console.ReadLine();
                    Console.Write("Nuevo Email: ");
                    string nuevoEmail = Console.ReadLine();
                    Console.Write("Nueva Edad: ");
                    int nuevaEdad = int.Parse(Console.ReadLine());
                    personaService.ModificarPersona(idModificar, nuevoNombre, nuevoEmail, nuevaEdad);
                    Console.WriteLine("Persona modificada con éxito.");
                    break;

                case 5:
                    Console.Write("ID de la persona a eliminar: ");
                    int idEliminar = int.Parse(Console.ReadLine());
                    personaService.EliminarPersona(idEliminar);
                    Console.WriteLine("Persona eliminada con éxito.");
                    break;

                case 6:
                    Console.WriteLine("Saliendo...");
                    break;

                default:
                    Console.WriteLine("Opción no válida.");
                    break;
            }

        } while (opcion != 6);
    }
}
