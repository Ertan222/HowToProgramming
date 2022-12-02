using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HowToProgramming.Models
{
    public class LanguageLevel
    {
        [Key]
        public int LanguageLevelId { get; set; }
        public string Name { get; set; }
        public int LanguageId { get; set; }
        public List<Language> Languages { get; set; }
    }
}