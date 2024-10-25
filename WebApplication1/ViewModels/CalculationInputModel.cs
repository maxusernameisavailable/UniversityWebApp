using System.ComponentModel.DataAnnotations;

namespace WebApplication1.ViewModels
{
    public class CalculationInputModel
    {
        [Required]
        // attr check size
        public IFormFile File { get; set; }

        [Required]
        [Range(1, 1000, ErrorMessage = "Matrix size is too large.")]
        public int MatrixSize { get; set; }

        [Required]
        [Range(1, 60, ErrorMessage = "Calculation time exceeded.")]
        public int MaxTime { get; set; }
    }
}
