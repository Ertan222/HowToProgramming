namespace HowToProgramming.Models;

    public class Creator
    {
        public int CreatorId { get; set; }   
        public string Name { get; set; }
        public DateTime DOB { get; set; }
        public int Age  { get { return DateTime.Now.Year - DOB.Year; }}
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }
        public int LanguageId { get; set; }
        public virtual List<Language> Languages { get; set; }

        public int FrameworkId { get; set; }
        public virtual List<Framework> Frameworks { get; set; }

    }
