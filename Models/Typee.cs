using System.ComponentModel.DataAnnotations;

namespace HowToProgramming.Models
{
    public class Typee
    {
        [Key]
        public int TypeeId { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public List<Language> Language { get; set; }
    }
}