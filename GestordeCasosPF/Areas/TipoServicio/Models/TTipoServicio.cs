using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace GestordeCasosPF.Areas.TipoServicio.Models
{
    public class TTipoServicio
    {

            public int TipoServicioID { get; set; }
            [Required(ErrorMessage = "El campo nombre es obligatorio.")]
            public string Nombre { get; set; }
            [Required(ErrorMessage = "El campo descripcion es obligatorio.")]
            public string Descripcion { get; set; }
            public Decimal Precio { get; set; }
            // public ICollection<TCursos> Cursos { get; set; }
        
    }
}
