using System.ComponentModel.DataAnnotations;

namespace Api.Domain.Dtos.Exercise {
    public class ExerciseDtoCreate {
        [Required(ErrorMessage = "Nome do exercício é campo obrigatório")]
        [StringLength (60, ErrorMessage = "Nome deve ter no máximo {1} caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Peso é campo obrigatório")]
        [StringLength (60, ErrorMessage = "Peso deve ter no máximo {1} caracteres.")]
        public string Weight { get; set; }

        [Required(ErrorMessage = "Repetições é campo obrigatório")]
        [StringLength (60, ErrorMessage = "Repetições deve ter no máximo {1} caracteres.")]
        public string Reps { get; set; }

        
        [Required(ErrorMessage = "Series é campo obrigatório")]
        [StringLength (60, ErrorMessage = "Series deve ter no máximo {1} caracteres.")]
        public string Series { get; set; }
    }
}