using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Person.Models;

public class ConcretePerson
{
    public int Id {get; set;}
    [Required]
    [Column(TypeName = "varchar(50)")]
    [MaxLength(100)]
    public string Name {get; set;}
    [MaxLength(100)]
    public string LastName {get; set;}
    [Required]
    public bool IsSecretlyAHamster {get; set;}
    public int? HamsterId {get; set;} 
    public int GroupId {get; set;}
    public virtual Group Group {get; set;}
    public ICollection<SpottedAt> spottedAt {get; set;} = new List<SpottedAt>();
    
}