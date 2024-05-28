using System.ComponentModel.DataAnnotations;

namespace T2_HERRERA_LUIS.Models
{
    public class Distribuidor
    {
        
        
        public int ID { get; set; }

        [Required(ErrorMessage ="El nombre de distribuidor es obligatorio")]
        public string NombreDistribuidor { get; set; }

        [Required(ErrorMessage ="La razon social es obligatoria")]
        public string RazonSocial { get; set; }

        [Required(ErrorMessage = "El telefono de distribuidor es obligatorio")]
        public int Telefono { get; set; }

        [Range(1900, 3000,ErrorMessage ="El rango es de 1900 a 3000"),Required(ErrorMessage = "El nombre de distribuidor es obligatorio")]
        public int AnioInicioOperacion { get; set; }


        [Required(ErrorMessage = "El nombre de contacto es obligatorio")]
        public string Contacto { get; set; }



    }
}
