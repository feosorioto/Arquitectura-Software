// Data/PersonaRepository.cs
using System.Collections.Generic;
using System.Linq;

public class PersonaRepository
{
    private List<Persona> personas = new List<Persona>();
    private int currentId = 1;

    // Crear persona
    public void Agregar(Persona persona)
    {
        persona.Id = currentId++;
        personas.Add(persona);
    }

    // Leer o buscar persona
    public Persona Buscar(int id)
    {
        return personas.FirstOrDefault(p => p.Id == id);
    }

    public List<Persona> Listar()
    {
        return personas;
    }

    // Actualizar persona
    public void Modificar(Persona personaModificada)
    {
        var persona = Buscar(personaModificada.Id);
        if (persona != null)
        {
            persona.Nombre = personaModificada.Nombre;
            persona.Email = personaModificada.Email;
            persona.Edad = personaModificada.Edad;
        }
    }

    // Eliminar persona
    public void Eliminar(int id)
    {
        var persona = Buscar(id);
        if (persona != null)
        {
            personas.Remove(persona);
        }
    }
}
