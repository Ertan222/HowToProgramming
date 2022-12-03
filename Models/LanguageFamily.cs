using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HowToProgramming.Models
{
    public class LanguageFamily
    {
        [Key]
        public int LanguageFamilyId { get; set; }
        public string Name { get; set; }
        public List<Language> Languages { get; set; }
    }
}