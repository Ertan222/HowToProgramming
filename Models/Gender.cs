using System.ComponentModel.DataAnnotations;

namespace HowToProgramming.Models
{
    public class Gender
    {
        [Key]
        public int GenderId { get; set; }
        public string Name { get; set; }
        public virtual List<Creator> Creator { get; set; }
    }
}