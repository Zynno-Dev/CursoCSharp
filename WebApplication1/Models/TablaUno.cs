using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Data
{
    public class TablaUno
    {   
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="El nombre es un campo requerido")]
        [MaxLength(10, ErrorMessage = "El largo maximo es 10"), MinLength(2, ErrorMessage = "El largo minimo es 2")]
        public string Name { get; set; }
        [Required(ErrorMessage ="El apellido es un campo requerido")]
        [MaxLength(10, ErrorMessage ="El largo maximo es 10"), MinLength(2, ErrorMessage ="El largo minimo es 2")]
        public string Lastname { get; set; }
    }
}
