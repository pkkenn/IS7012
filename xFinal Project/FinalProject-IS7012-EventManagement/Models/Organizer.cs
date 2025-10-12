using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace EventManagement.Models
{
    public class Organizer
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        [DisplayName("Organizer Name")]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress]
        [DisplayName("Email Address")]
        public string Email { get; set; } = string.Empty;

        // ValidateNever to prevent circular validation during scaffolding
        [ValidateNever]
        [DisplayName("Events Organized")]
        public ICollection<Event> Events { get; set; } = new List<Event>();


    }
}


