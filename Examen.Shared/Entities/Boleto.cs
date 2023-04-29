using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Examen.Shared.Entities
{
    public class Boleto
    {
        [DisplayName("ID")]
        [JsonPropertyName("id")]
        public int Id { get; set; }

        [Display(Name = "Fecha_uso")]
        public DateTime UseDate { get; set; }
        [Required(ErrorMessage = "El campo {0} es obligatorio.")]

        [Display(Name = "Usada")]
        public Boolean Using { get; set; }
        [Display(Name = "Porteria")]
        public String Entrance { get; set; } = null!;
    }
}
