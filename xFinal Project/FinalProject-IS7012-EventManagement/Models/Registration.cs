using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace EventManagement.Models
{
    public class Registration
    {
        public int Id { get; set; }

        [DisplayName("Event")]
        public int EventId { get; set; }

        [ValidateNever]
        public Event Event { get; set; } = default!;

        [DisplayName("Attendee")]
        public int AttendeeId { get; set; }

        [ValidateNever]
        public Attendee Attendee { get; set; } = default!;

        [DataType(DataType.DateTime)]
        [DisplayName("Registered At")]
        public DateTime RegisteredAt { get; set; } = DateTime.Now;
    }
}

