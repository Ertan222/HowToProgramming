using System.ComponentModel.DataAnnotations;

namespace HowToProgramming.Models
{
    public class Framework
    {
        public int FrameWorkId { get; set; }
        public string Name { get; set; }

        public int CreatorId { get; set; }
        public virtual Creator Creator { get; set; }

        public virtual ICollection<Language> FLanguages { get; set; }
        public List<LanguageFramework> JFLanguage { get; set; }
    }
}