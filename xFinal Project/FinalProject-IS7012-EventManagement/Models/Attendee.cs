using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace EventManagement.Models
{
    public class Attendee
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        [DisplayName("Attendee Name")]
        public string Name { get; set; } = string.Empty;

        [Required, EmailAddress]
        [DisplayName("Email Address")]
        public string Email { get; set; } = string.Empty;

        // Relationship: one attendee can have many registrations
        [ValidateNever]
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();

      
    }
}

