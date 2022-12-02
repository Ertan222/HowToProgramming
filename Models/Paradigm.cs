using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HowToProgramming.Models
{
    public class Paradigm
    {
        [Key]
        public int ParadigmId { get; set; }
        public string Name { get; set; }

        public int LanguageId { get; set; }
        public ICollection<Language> PLanguages { get; set; }
        public List<LanguageParadigm> JPlanguages { get; set; }
    }
}