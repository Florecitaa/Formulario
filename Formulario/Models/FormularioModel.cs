using System.ComponentModel.DataAnnotations;

namespace Formulario.Models
{
    public class FormularioModel
    {
        [Required(ErrorMessage = "El espacio debe tener un nombre")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El correo electrónico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El formato del correo electrónico no es válido.")]
        public string CorreoElectronico { get; set; }

        [Required(ErrorMessage = "El mensaje es obligatorio.")]
        public string Mensaje { get; set; }
    }
}