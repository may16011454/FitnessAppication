using ITS_System.Data.Models;
using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;

namespace ITS_System.Models
{
    public class TechnicalIssue : IIssue
    {
        [Key]
        public Guid Id { get; set; }

        public string Details { get; set; }
        
        [Required]
        public IdentityUser RecordedBy { get; set; }

        [Required]
        public IdentityUser RaisedBy { get; set; }

        [Required]
        [DataType(DataType.DateTime)]
        public DateTime TimeStamp { get; set; } = DateTime.Now;

        public List<Asset> AssetsAffected { get; set; } = new List<Asset>();
    }
}
