using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HowToProgramming.Models
{
    public class LanguageFramework
    {
        public int LanguageId { get; set; }
        public Language Language { get; set; }
        public int FrameworkId { get; set; }
        public Framework Framework { get; set; }
    }
}