﻿using System.Security.Permissions;
using Datos;
using Entidad;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace Logica
{
    public class PersonaService
    {
        private readonly EjercicioParcialContext _context;

        public PersonaService(EjercicioParcialContext context)
        {
           _context=context;
        }

        public GuardarPersonaResponse Guardar(Persona persona)
        {
            try
            {
                var personaBuscada = _context.Personas.Find(persona.Identificacion);
                if(personaBuscada != null){
                    return new GuardarPersonaResponse("Error, ya registrarada");
                }
                _context.Personas.Add(persona);
                _context.SaveChanges();
                return new GuardarPersonaResponse(persona);
            }
            catch (Exception e)
            {
                return new GuardarPersonaResponse($"Error de la Aplicacion: {e.Message}");
            }
            
        }
        public List<Persona> ConsultarTodos()
        {
           
            List<Persona> personas = _context.Personas.Include(p => p.Apoyo).ToList();
            return personas;
        }
       
    }

    public class GuardarPersonaResponse 
    {
        public GuardarPersonaResponse(Persona persona)
        {
            Error = false;
            Persona = persona;
        }
        public GuardarPersonaResponse(string mensaje)
        {
            Error = true;
            Mensaje = mensaje;
        }
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Persona Persona { get; set; }
    }
}