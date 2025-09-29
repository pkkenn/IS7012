using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RecruitCatAlexiskh.Models;

public class JobTitle
{
    public int ID { get; set; }

    [Required]
    [StringLength(100)]
    [DisplayName("Job Title Name")]
    public string Title { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    [Range(0, (double)decimal.MaxValue, ErrorMessage = "Salary must be a positive number.")]
    [DisplayName("Minimum Salary")]
    public decimal MinSalary { get; set; }

    [Required]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")]
    [Range(0, (double)decimal.MaxValue, ErrorMessage = "Salary must be a positive number.")]
    [DisplayName("Maximum Salary")]
    public decimal MaxSalary { get; set; }

    [DisplayName("Is Remote?")]
    public bool IsRemote { get; set; }

    public List<Candidate> Candidates { get; set; } = new List<Candidate>();
}