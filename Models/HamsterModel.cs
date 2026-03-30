using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Person.Models;

public class Hamster
{
    public int Id {get; set;}
    [Required]
    [Column(TypeName = "varchar(50)")]
    [MaxLength(100)]
    public string Name {get; set;}
    [MaxLength(200)]
    public string Specie {get; set;}
    [Required]
    public virtual ConcretePerson HumanForm {get; set;}
}