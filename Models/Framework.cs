using System.ComponentModel.DataAnnotations;

namespace HowToProgramming.Models
{
    public class Framework
    {
        [Key]
        public int FrameWorkId { get; set; }
        public string Name { get; set; }

        public int CreatorId { get; set; }
        public virtual Creator Creator { get; set; }

    }
}