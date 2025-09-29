using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace RecruitCatAlexiskh.Models;

public class Industry
{
    public int ID { get; set; }

    [Required]
    [StringLength(100)]
    [DisplayName("Industry Name")]
    public string Name { get; set; }

    [Required]
    [StringLength(100)]
    [DisplayName("Economic Sector")]
    public string Sector { get; set; }

    public List<Candidate> Candidates { get; set; } = new List<Candidate>();
    public List<Company> Companies { get; set; } = new List<Company>();
}