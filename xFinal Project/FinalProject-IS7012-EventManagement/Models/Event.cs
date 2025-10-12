using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace EventManagement.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required, StringLength(150)]
        [DisplayName("Event Title")]
        public string Title { get; set; } = string.Empty;

        [StringLength(500)]
        [DisplayName("Event Description")]
        public string? Description { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [DisplayName("Event Date")]
        public DateTime Date { get; set; }

        [StringLength(100)]
        [DisplayName("Event Location")]
        public string? Location { get; set; }

        // Organizer Relationship
        [ForeignKey("Organizer")]
        [DisplayName("Organizer")]
        public int OrganizerId { get; set; }

        [ValidateNever]
        public Organizer Organizer { get; set; } = default!;

        // ✅ Registration Relationship (One-to-Many)
        [ValidateNever]
        public ICollection<Registration> Registrations { get; set; } = new List<Registration>();
    }
}


