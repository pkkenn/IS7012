using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatAlexiskh.Models;

public class Company
{
    public int ID { get; set; }

    [Required]
    [StringLength(100)]
    [DisplayName("Company Name")]
    public string Name { get; set; }

    [Required]
    [StringLength(500, MinimumLength = 10)]
    [DataType(DataType.MultilineText)]
    public string Address { get; set; }

    [DisplayName("Is Recruiting?")]
    public bool IsRecruiting { get; set; }

    [DisplayName("Industry")]
    public int IndustryId { get; set; }
    public Industry Industry { get; set; }

    public List<Candidate> Candidates { get; set; } = new List<Candidate>();
}