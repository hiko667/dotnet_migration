using System.ComponentModel.DataAnnotations;

namespace Person.Models;

public class Group
{
    public int Id {get; set;}
    [Required]
    [MaxLength(50)]
    public string Name {get; set;}
    public bool IsHamsterFriendly {get; set;}
    public virtual ICollection<ConcretePerson>? People {get; set;}
}