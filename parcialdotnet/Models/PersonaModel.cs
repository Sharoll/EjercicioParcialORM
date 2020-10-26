using System;
using Entidad;

namespace parcialdotnet.Models
{
     public class PersonaInputModel
    {
        public string Identificacion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Sexo { get; set; }
        public int Edad { get; set; }
        public Apoyo Apoyo {get;set;}
    }

    public class PersonaViewModel : PersonaInputModel
    {
        public PersonaViewModel()
        {

        }
        public PersonaViewModel(Persona persona)
        {
            Identificacion = persona.Identificacion;
            Nombre = persona.Nombre;
            Apellido = persona.Apellido;
            Sexo = persona.Sexo;
            Edad = persona.Edad;
            Apoyo = persona.Apoyo;
            
        }
    }
   
}