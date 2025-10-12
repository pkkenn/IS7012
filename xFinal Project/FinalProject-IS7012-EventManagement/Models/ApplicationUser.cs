using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace EventManagement.Models
{
    // ApplicationUser inherits all necessary Identity fields
    public class ApplicationUser : IdentityUser
    {
        // Navigation Properties to Application Profiles
        public int? OrganizerId { get; set; } 
        public Organizer? OrganizerProfile { get; set; } 

        public int? AttendeeId { get; set; }
        public Attendee? AttendeeProfile { get; set; }
    }
}