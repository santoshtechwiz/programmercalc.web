using System.ComponentModel.DataAnnotations;

namespace programmercalc.web.Models
{
    public class NumberViewModel
  {
    [Required]
    public int Decimal { get; set; }

    public string Octol { get; set; }

    public string HexaDecimal { get; set; }

    public string Binary { get; set; }
  }
}