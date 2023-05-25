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
        [Display(Name = "Class Name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Class Date and Time")]
        public DateTime DateTime { get; set; }

        [Required]
        [Display(Name = "Instructor")]
        public string InstructorId { get; set; }

        [ForeignKey("InstructorId")]
        public IdentityUser Instructor { get; set; }

        [Required]
        [Display(Name = "Max Number of Bookings")]
        public int MaxNumberOfBookings { get; set; }

        public int AvailableSpaces { get; set; }

        [ForeignKey("RoomId")]
        public Room Room { get; set; }

        [Required]
        [Display(Name = "Room")]
        public int RoomId { get; set; }

        public ClassStatus Status { get; set; }

        public virtual List<WaitingListEntry> WaitingList { get; set; } = new List<WaitingListEntry>();
        public virtual List<Booking> Attendees { get; set; } = new List<Booking>();
        public virtual List<EquipmentListEntry> EquipmentList { get; set; } = new List<EquipmentListEntry>();


    }
}



