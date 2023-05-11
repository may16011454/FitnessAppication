using System.ComponentModel.DataAnnotations;

namespace FitnessApplication.Models
{
    public class Room
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        [Required]
        public int Capacity { get; set; }
    }
}
