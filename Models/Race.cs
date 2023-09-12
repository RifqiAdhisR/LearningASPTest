using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebLearningTest.Data.Enum;

namespace WebLearningTest.Models
{
    public class Race
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public RaceCategory RaceCategory { get; set; }
        [ForeignKey("UserApp")]
        public string? UserAppId { get; set; }
        public UserApp? UserApp { get; set; }
    }
}
