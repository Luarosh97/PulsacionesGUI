using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ENTITY;
using DAL;

namespace BLL
{
    public class PersonaService
    {
        private PersonaRepository personaRepositorio;

        public PersonaService()
        {
            personaRepositorio = new PersonaRepository();
        }


        public string Guardar(Persona persona)
        {
            try
            {
                if (personaRepositorio.Buscar(persona.Identificacion) == null)
                {

                    personaRepositorio.Guardar(persona);
                    return "Los Datos han sido guardados satisfactoriamente";
                }
                return $"La identificacion {persona.Identificacion} ya se encuentra registrada por favor verifique los datos";

            }
            catch (Exception e)
            {

                return "Error de Datos: " + e.Message;
            }
        }

        public string Eliminar(string identificacion)
        {
            try
            {
                if (personaRepositorio.Buscar(identificacion) != null)
                {

                    personaRepositorio.Eliminar(identificacion);
                    return $"Los Persona con identificacion {identificacion} ha sido eliminada satisfacatoriamente";
                }
                return $"La identificacion {identificacion} no se encuentra registrada por favor verifique los datos";
            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }


        }
        public string Modificar(Persona persona)
        {

            try
            {
                if (personaRepositorio.Buscar(persona.Identificacion) != null)
                {

                    personaRepositorio.Modificar(persona);
                    return $"Los Persona con identificacion {persona.Identificacion} ha sido modificada satisfacatoriamente";
                }
                return $"La identificacion {persona.Identificacion} no se encuentra registrada por favor verifique los datos";

            }
            catch (Exception e)
            {

                return "Error de datos" + e.Message;
            }
        }

        public void ImprimirPersonas(List<Persona> persona)
        {
            Console.WriteLine("{0,15}{1,17}{2,16}{3,12}{4,16}{5,17}", "Identificacion", "Nombre_persona", "Edad", "Nombre", "PulsacionCalculada");
            Console.WriteLine("---------------------------------------------------------------------------------------------");
            Console.WriteLine("---------------------------------------------------------------------------------------------");

            foreach (var item in persona)
            {
                Console.WriteLine("{0,15}{1,17}{2,16}{3,12}{4,16}{5,17}", item.Identificacion, item.Nombre, item.Edad, item.Sexo, item.Pulsacion);
            }
            }

            public Persona Buscar(string identificacion)
        {
            try
            {
                Persona persona= personaRepositorio.Buscar(identificacion);
                if (persona == null)
                {
                    Console.WriteLine($"La identificacion {identificacion} no se encuentra registrada");
                }
                return persona;
            }
            catch (Exception E)
            {
                Console.WriteLine("Error de lectura " + E.Message);
                return null;
            }
}
        public void Consultar()
        {
            try
            {
                List<Persona>personas = personaRepositorio.Consultar();
                if (personas != null)
                {
                    ImprimirPersonas(personas);
                }
                else
                {
                    Console.WriteLine("No existen personas registradas en la lista");
                }
            }
            catch (Exception E)
            {
                Console.WriteLine("Error de lectura " + E.Message);
            }
        }









    }
    }

