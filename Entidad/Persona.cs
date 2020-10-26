using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class Persona
    {
        public Persona(){
            Apoyo = new Apoyo();
        }

        [Key]
        [Column(TypeName = "nvarchar(15)")]
        public string Identificacion { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Nombre { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Apellido { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string Sexo { get; set; }

        [Column(TypeName = "int")]
        public int Edad { get; set; }
       
       public Apoyo Apoyo {get;set;}
        
    }
}
