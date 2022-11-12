using System.ComponentModel.DataAnnotations;

namespace MvcLabManager.Models;

public class Lab
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Número é um campo obrigatório.")]
    public int? Number { get; set; }
    [Required(ErrorMessage = "Nome é um campo obrigatório.")]
    [StringLength(20, ErrorMessage = "Nome deve estar entre 4 e 20 caracteres.", MinimumLength = 4)]
    public string Name { get; set; }
    [StringLength(1, ErrorMessage = "Bloco deve ter no máximo 1 caractere")]
    [Required(ErrorMessage = "Bloco é um campo obrigatório.")]
    public string Block { get; set; }

    public Lab() { }

    public Lab(int id, int number, string name, string block)
    {
        Id = id;
        Number = number;
        Name = name;
        Block = block;
    }
}