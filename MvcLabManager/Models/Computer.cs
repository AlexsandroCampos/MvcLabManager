using System.ComponentModel.DataAnnotations;

namespace MvcLabManager.Models;

public class Computer
{
    public int Id { get; set; }
    [Required(ErrorMessage = "Ram é um campo obrigatório.")]
    public string Ram { get; set; }
    [Required(ErrorMessage = "Processador é um campo obrigatório.")]
    [StringLength(30, ErrorMessage = "Processador deve estar entre 5 e 30 caracteres.", MinimumLength = 5)]
    public string Processor { get; set; }

    public Computer() { }

    public Computer(int id, string ram, string processor)
    {
        Id = id;
        Ram = ram;
        Processor = processor;
    }
}