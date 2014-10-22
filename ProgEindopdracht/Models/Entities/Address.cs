using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace EindProgOPdracht5.Models.Entities
{
    public class Address
    {
        [Key]
        public int AddressId { get; set; }
        public String Street { get; set; }
        public String HouseNumber { get; set; }
        public String Zip { get; set; }
        public String Residence { get; set; }
        public String Email { get; set; }

    }
}