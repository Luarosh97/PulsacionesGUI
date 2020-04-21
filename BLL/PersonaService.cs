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
       public static PersonaRepository personaRepositorio = new PersonaRepository();
       
        public PersonaService()
        {
           
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



        public static Persona Buscar(string identificacion)
        {

            return personaRepositorio.Buscar(identificacion);
        }

        public RespuestaConsulta Consultar()
        {
            RespuestaConsulta respuesta = new RespuestaConsulta();
            try
            {
                respuesta.Error = false;
                respuesta.Personas = personaRepositorio.Consultar();
                if (respuesta.Personas != null)
                {
                    respuesta.Mensaje = "Se Consulta la Informacion de personas";
                }
                else
                {
                    respuesta.Mensaje = "No existen Datos para Consultar";
                }

            }
            catch (Exception e)
            {
                respuesta.Error = true;
                respuesta.Mensaje = $"Erro en datos: " + e.Message;
            }
            return respuesta;

        }

        public  int TotalizarPersonas()
        {
            return personaRepositorio.TotalizarPersonas();
        }

        public  int TotalizarMujeres()
        {
            return personaRepositorio.TotalizarMujeres();
        }

        public  int TotalizarHombres()
        {
            return personaRepositorio.TotalizarHombres();
        }

        public IList<Persona> ListaHombres()
        {
            return personaRepositorio.ListaHombres();
        }


        public IList<Persona> ListaMujeres()
        {
            return personaRepositorio.Listamujeres();
        }


       

    }
}

