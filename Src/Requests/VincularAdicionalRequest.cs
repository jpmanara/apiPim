namespace api_pim.Models;

using System.ComponentModel.DataAnnotations;

public class VincularAdicionalRequest
{
    [Required]
    public int FuncionarioId { get; set; }

    [Required]

    public double ValorFixo { get; set; }

    [Required]
    public int TipoAdicionalCod { get; set; }
}