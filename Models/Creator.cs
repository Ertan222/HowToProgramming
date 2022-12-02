using System.ComponentModel.DataAnnotations;

namespace HowToProgramming.Models;

    public class Creator
    {
        public int? CreatorId { get; set; }   
        public string? Name { get; set; }

        // date of birth'ü fluent yap bir ara
        [Required(ErrorMessage = "{0} must be filled"), Display(Name = "Date of birth")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "(0:dd/MM/yyyy)")]
        [DataType(DataType.Date, ErrorMessage ="Date is not in correct form")]
        public DateTime DOB { get; set; }
        public int? GenderId { get; set; }
        public virtual Gender Gender { get; set; }
        public int? LanguageId { get; set; }
        public virtual List<Language> CLanguages { get; set; }

        public int? FrameworkId { get; set; }
        public virtual List<Framework> CFrameworks { get; set; }

    }
