using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static FitnessApplication.Models.Enums;


namespace FitnessApplication.Models
{
    public class ClassSchedule
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public DateTime DateTime { get; set; }
        [Required]
        public IdentityUser Instructor { get; set; }
        [Required]
        public int MaxNumberOfBookings { get; set; }
        [Required]
        public Room Room { get; set; }
        [Required]
        [ForeignKey("RoomId")]
        public int RoomId { get; set; }
        public ClassStatus Status { get; set; }

        
        public virtual Dictionary<IdentityUser, DateTime> WaitingList { get; set; }
        public  virtual List<Booking> Attendees{ get; set; }
        public virtual List<Equipment> Equipment{ get; set; }
        
    }
}
