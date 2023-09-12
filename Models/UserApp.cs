﻿using System.ComponentModel.DataAnnotations;

namespace WebLearningTest.Models
{
    public class UserApp 
    {
        [Key]
        public string Id { get; set; }
        public int? Pace {  get; set; }
        public int? Milage { get; set; }
        public Address? Address { get; set; }
        public ICollection<Club> Clubs { get; set;}
        public ICollection<Race> Races { get; set; }
    }
}
