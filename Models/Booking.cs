using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static FitnessApplication.Models.Enums;

namespace FitnessApplication.Models
{
    public class Booking
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public ClassSchedule Class { get; set; }
        [Required]
        public IdentityUser Attendee { get; set; }
        [Required]
        public DateTime TimeStamp { get; set; }
        [Required]
        public BookingStatus Status  { get; set; }
    }
}
