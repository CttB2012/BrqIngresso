using System.ComponentModel.DataAnnotations;

namespace BRQ_Ingresso.Models;

public class EnderecoUsuario
{
    [Key]
    public string IdEndereco { get; set; }
    [Required]
    [StringLength(100)]
    public string? Logradouro { get; set; }
    [Required]
    [StringLength(10)]
    public string? Numero { get; set; }
    [Required]
    [StringLength(20)]
    public string? Bairro { get; set; }
    [Required]
    [StringLength(20)]
    public string? Cidade { get; set; }
    [Required]
    [StringLength(2)]
    public string? Estado { get; set; }
    [Required]
    [StringLength(2)]
    public string? Pais { get; set; }
    [Required]
    [StringLength(8)]
    public string? Cep { get; set; }

    
    public string? IdUsuario { get; set; }    
    
}
