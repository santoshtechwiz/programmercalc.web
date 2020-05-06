using System.ComponentModel.DataAnnotations;

namespace programmercalc.web.Models
{
    public class InputViewModel
  {
    [Required]
    [Display(Name = "Enter input string")]
    public string Input { get; set; }

    public string Output { get; set; }

    public string Description { get; set; }
  }
}