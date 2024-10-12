using System.ComponentModel.DataAnnotations;

namespace Tarea4.Modelos
{
    public class Serie
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede exceder los 100 caracteres.")]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El país es obligatorio.")]
        [StringLength(100, ErrorMessage = "El país no puede exceder los 100 caracteres.")]
        public string Pais { get; set; }

        [Required(ErrorMessage = "El idioma es obligatorio.")]
        [StringLength(100, ErrorMessage = "El idioma no puede exceder los 100 caracteres.")]
        public string Idioma { get; set; }

        [Required(ErrorMessage = "La URL de la foto es obligatoria.")]
        [Url(ErrorMessage = "Por favor, introduce una URL válida.")]
        public string Foto { get; set; }

        [Required(ErrorMessage = "El resumen es obligatorio.")]
        [StringLength(1000, ErrorMessage = "El resumen no puede exceder los 1000 caracteres.")]
        public string Resumen { get; set; }
    }
}
