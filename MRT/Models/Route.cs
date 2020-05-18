using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MRT.Models
{
    public class Route
    {     
        [Required(ErrorMessage = "Please select your trip type")]
        public string tripType { get; set; }

        [Required(ErrorMessage = "Please select your category")]
        public string LevelCategory { get; set; }

        [Required(ErrorMessage = "Please select your first station")]
        public string StationFrom { get; set; }

        [Required(ErrorMessage = "Please select your second station")]
        public string StationTo { get; set; }

        [Required(ErrorMessage = "Please select your number of tickets")]
        public string NumTicket { get; set; }

        [Required(ErrorMessage = "Please enter your name")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter your NRIC or Passport No")]
        public string idNo { get; set; }

        [Required(ErrorMessage = "Please enter your Email Address")]
        public string Email { get; set; }
    }
}