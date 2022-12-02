using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowToProgramming.Models
{
    public class LanguageParadigm
    {
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int ParadigmId { get; set; }
        public Paradigm Paradigm { get; set; }
    }
}