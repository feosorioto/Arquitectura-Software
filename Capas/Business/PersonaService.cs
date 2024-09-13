// Business/PersonaService.cs
using System.Collections.Generic;

public class PersonaService
{
    private PersonaRepository personaRepository = new PersonaRepository();

    public void AgregarPersona(string nombre, string email, int edad)
    {
        var persona = new Persona
        {
            Nombre = nombre,
            Email = email,
            Edad = edad
        };
        personaRepository.Agregar(persona);
    }

    public Persona BuscarPersona(int id)
    {
        return personaRepository.Buscar(id);
    }

    public List<Persona> ListarPersonas()
    {
        return personaRepository.Listar();
    }

    public void ModificarPersona(int id, string nombre, string email, int edad)
    {
        var personaModificada = new Persona
        {
            Id = id,
            Nombre = nombre,
            Email = email,
            Edad = edad
        };
        personaRepository.Modificar(personaModificada);
    }

    public void EliminarPersona(int id)
    {
        personaRepository.Eliminar(id);
    }
}

