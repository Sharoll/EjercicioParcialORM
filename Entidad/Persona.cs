using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entidad
{
    public class Persona
    {
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
       
        [Column(TypeName = "nvarchar(20)")]
        public string Departamento { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Ciudad { get; set; }

        [Column(TypeName = "decimal(18,0)")]
        public decimal valorApoyo { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string Modalidad { get; set; }

        [Column(TypeName = "Date")]
        public DateTime Fecha { get; set; }
        
    }
}
