using System.ComponentModel.DataAnnotations;

namespace evaluacion20262.Models
{
    public class SolicitudServicio
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El campo Cliente es obligatorio")]
        public string Cliente { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Teléfono es obligatorio")]
        public string Telefono { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Distrito es obligatorio")]
        public string Distrito { get; set; } = string.Empty;

        [Required(ErrorMessage = "El campo Tipo de Servicio es obligatorio")]
        public string TipoServicio { get; set; } = string.Empty; // Instalación, Mantenimiento, Revisión, Fuga

        public string? Descripcion { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
