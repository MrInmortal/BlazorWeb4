using System.ComponentModel.DataAnnotations;

namespace Tarea4.Modelos
{
    public class Personaje
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apodo es obligatorio.")]
        [StringLength(100, ErrorMessage = "El apodo no puede exceder los 100 caracteres.")]
        public string Apodo { get; set; }

        [Required(ErrorMessage = "La raza es obligatoria.")]
        [StringLength(100, ErrorMessage = "La raza no puede exceder los 100 caracteres.")]
        public string Raza { get; set; }

        [Required(ErrorMessage = "La URL de la foto es obligatoria.")]
        [Url(ErrorMessage = "Por favor, introduce una URL válida.")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "La edad es obligatoria.")]
        [Range(1, 150, ErrorMessage = "La edad debe estar entre 1 y 150.")]
        public int Edad { get; set; }

        [Required(ErrorMessage = "El poder característico es obligatorio.")]
        [StringLength(500, ErrorMessage = "El poder característico no puede exceder los 500 caracteres.")]
        public string Poder { get; set; }

        [Required(ErrorMessage = "Debe seleccionar una serie, película o libro.")]
        public int SerieId { get; set; } // ID de la serie/película/libro asociado
    }
}
