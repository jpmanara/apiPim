using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api_pim.Entities;

public class Funcionario
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int Id { get; set; }

    public string NomeCompleto { get; set; } = string.Empty;

    public DateTime DataNascimento {get; set; }
    public string Cpf { get; set; } = string.Empty;

    public string Rg { get; set; } = string.Empty;

    public string Celular { get; set; } = string.Empty;

    public string CelularContatoEmergencia { get; set; } = string.Empty;

    public string Endereco { get; set; } = string.Empty;

    public string Bairro { get; set; } = string.Empty;

    public string Cidade { get; set; } = string.Empty;

    public string Estado { get; set; } = string.Empty;

    public string Pis { get; set; } = string.Empty;

    public string? AgenciaBancaria { get; set; } = string.Empty;

    public string? DigitoAgencia { get; set; } = string.Empty;

    public string? ContaBancaria { get; set; } = string.Empty;

    public string? DigitoConta { get; set; } = string.Empty;

    public string? Banco { get; set; } = string.Empty;

    [ForeignKey("TipoCargo")]
    public int TipoCargoCod { get; set; }

    public TipoCargo TipoCargo { get; set; } = null!;

    public double SalarioBase { get; set; }

    public double JornadaTrabalhoSemanal { get; set; }

    [ForeignKey("Usuario")]
    public int UsuarioId { get; set; }

    public Usuario Usuario { get; set; } = null!;

    [ForeignKey("Empresa")]
    public int EmpresaId { get; set; }

    public Empresa Empresa { get; set; } = null!;

    public ICollection<AdicionalFuncionario> AdicionalFuncionario { get; set;} = new List<AdicionalFuncionario>();
    public ICollection<DescontoFuncionario> DescontoFuncionario { get; set;} = new List<DescontoFuncionario>();

}