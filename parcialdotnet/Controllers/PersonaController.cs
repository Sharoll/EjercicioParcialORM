using System.Runtime.ExceptionServices;
using System.ComponentModel;
using System.IO.Pipes;
using System.Security.Permissions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Entidad;
using Logica;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using parcialdotnet.Models;
using Datos;

namespace parcialdotnet.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class PersonaController :  ControllerBase
    {
        private readonly PersonaService _personaService;

        public PersonaController(EjercicioParcialContext context){
    
            _personaService = new PersonaService(context);
        }
        // GET: api/Persona
        [HttpGet()]
        public IEnumerable<PersonaViewModel> Gets(){
            var personas = _personaService.ConsultarTodos().Select(p=> new PersonaViewModel(p));
            return personas;
        }
         
         
        // POST: api/Persona
        [HttpPost]
        public ActionResult<PersonaViewModel> Post(PersonaInputModel personaInput){
            Persona persona = MapearPersona(personaInput);
            var response = _personaService.Guardar(persona);

            if (response.Error)
            {
            return BadRequest(response.Mensaje);
            }
            return Ok(response.Persona);
        }
        
        private Persona MapearPersona(PersonaInputModel personaInput){
            var persona = new Persona();
            
                persona.Identificacion = personaInput.Identificacion;
                persona.Nombre = personaInput.Nombre;
                persona.Apellido = personaInput.Apellido;
                persona.Sexo = personaInput.Sexo;
                persona.Edad = personaInput.Edad;
                persona.Apoyo.Departamento = personaInput.Apoyo.Departamento;
                persona.Apoyo.Ciudad = personaInput.Apoyo.Ciudad;
                persona.Apoyo.valorApoyo = personaInput.Apoyo.valorApoyo;
                persona.Apoyo.Modalidad = personaInput.Apoyo.Modalidad;
                persona.Apoyo.Fecha = personaInput.Apoyo.Fecha;
            
            return persona;
        }

    }
}