using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Entidad
{
    public class Apoyo
    {
        [Key]
        
        [Column(TypeName = "int")]
        public int Codigo {get;set;}

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