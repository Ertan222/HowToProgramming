using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace HowToProgramming.Models
{
    public class Language
    {
        public int LanguageId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string? CreatorId { get; set; }
        public virtual Creator? Creator { get; set; }     
        public int FrameworkId { get; set; }
        public virtual List<Framework> Framework { get; set; }
        public int TypeeId { get; set; }
        public virtual Typee Typee { get; set; }
        public int LanguageLevelId { get; set; }
        public  virtual LanguageLevel LanguageLevel { get; set; }
        public int LanguageFamilyId { get; set; }
        public virtual LanguageFamily LanguageFamily { get; set; }
        public int ParadigmId { get; set; }
        public virtual List<Paradigm> Paradigms { get; set; }
    }
}