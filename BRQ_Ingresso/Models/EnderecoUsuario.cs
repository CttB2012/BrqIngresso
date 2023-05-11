using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace BRQ_Ingresso.Models;

public class EnderecoUsuario
{
    [Key]
    [JsonIgnore]
    public Guid EnderecoUsuarioId { get; set; }

    [Required]
   // [MaxLength(100)]
    public string Logradouro { get; set; }

    [Required]
    //[MaxLength(10)]
    public string Numero { get; set; }

    [Required]
    //[MaxLength(20)]
    public string Bairro { get; set; }

    [Required]
    //[MaxLength(20)]
    public string Cidade { get; set; }

    [Required]
    //[MaxLength(2)]
    public string Estado { get; set; }

    [Required]
    //[MaxLength(2)]
    public string Pais { get; set; }

    [Required]
    //[MaxLength(8)]
    public string Cep { get; set; }

    
}
