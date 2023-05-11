﻿using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace FitnessApplication.Models
{
    public class WaitingListEntry
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public IdentityUser Customer{ get; set; }
        [Required]
        public DateTime AddedOn { get; set; }
    }
}
