using System.ComponentModel.DataAnnotations;

namespace BRQ_Ingresso.Models;

public class Usuario
{
    [Key]
    public string IdUsuario { get; set; }
    [Required]
    [StringLength(11)]
    public string? CPF { get; set; }
    [Required]
    [StringLength(50)]
    public string? Email { get; set; }
    [Required]
    [StringLength(100)]
    public string? NomeCompleto { get; set; }
    [Required]
    [StringLength(100)]
    public string? Senha { get; set; }
    [StringLength(20)]
    public string? Apelido { get; set; }
    [Required]
    [StringLength(12)]
    public string? DataNascimento { get; set; }
    [Required]
    [StringLength(13)]
    public int Celular { get; set; }
    [Required]
    [StringLength(2)]
    public int Sexo { get; set; }

    public DateTime DataCadastro { get; set; }
    public DateTime DataAtualizacao { get; set; }

    public string? IdEndereco { get; set; }
    
   
}
