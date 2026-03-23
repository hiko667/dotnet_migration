using System.ComponentModel.DataAnnotations;

namespace Person.Models;

public class SpottedAt
{
    public int Id {get; set;}
    [Required]
    [MaxLength(100)]
    public string PlaceName {get; set;}
    public ICollection<ConcretePerson> People {get; set;} = new List<ConcretePerson>();
    
}
