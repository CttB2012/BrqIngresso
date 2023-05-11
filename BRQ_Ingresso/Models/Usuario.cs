using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace BRQ_Ingresso.Models;

[Index(nameof(CPF), nameof(Email), IsUnique = true)]
public class Usuario
{
    [Key]
    [JsonIgnore]
    public Guid UsuarioId { get; set; }

    [Required]
    //[MaxLength(11)]    
    public string CPF { get; set; }

    [Required]
    //[MaxLength(50)]
    public string Email { get; set; }

    [Required]
    //[MaxLength(100)]
    public string NomeCompleto { get; set; }

    [Required]
    //[MaxLength(100)]
    public string Senha { get; set; }

    
    //[StringLength(20)]
    public string Apelido { get; set; }

    [Required]
    //[MaxLength(12)]
    public string DataNascimento { get; set; }

    [Required]
    //[MaxLength(13)]
    public int Celular { get; set; }

    [Required]
    //[MaxLength(2)]
    public string Sexo { get; set; }

    public DateTime DataCadastro { get; set; }

    [JsonIgnore]
    public DateTime DataAtualizacao { get; set; }

    [JsonIgnore]
    public Guid EnderecoUsuarioId { get; set; }
    public EnderecoUsuario EnderecoUsuario {get; set;}
}
