using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EindProgOPdracht5.Models
{
    public class Room
    {
        [Key]
        public int RoomId { get; set; }

        [Required]
        [Display(Name = "Room Number")]
        public int RoomNumber { get; set; }

        [Required, RegularExpression(@"[235]", ErrorMessage="Room Capacity can only be 2,3 or 5.")]
        [Display(Name = "Room Capacity")]
        public int RoomCapacity { get; set; }

        public RoomPrice Price { get; set; }

        public decimal MinPrice = 20;        
    }
}