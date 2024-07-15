using System.ComponentModel.DataAnnotations;

namespace BarDaFatima.Web.Models;

public class Mesa
{
    public enum StatusMesa
    {
        Livre = 1,
        Ocupada = 2,
        Reservada= 3,
        Bloqueada = 99
    }
    [Required]
     public int Numero { get; set; }

    public StatusMesa Status { get; set; }

  

    public DateTime?  DataAbertura  { get; set; }
}
