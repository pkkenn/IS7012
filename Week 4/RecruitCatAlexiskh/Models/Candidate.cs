using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace RecruitCatAlexiskh.Models;

public class Candidate
{
    public int ID { get; set; }

    [DisplayName("First Name")]
    [Required]
    [StringLength(50)]
    public string FirstName { get; set; }

    [DisplayName("Last Name")]
    [Required]
    [StringLength(50)]
    public string LastName { get; set; }

    [Required]
    [EmailAddress]
    [StringLength(100)]
    public string Email { get; set; }

    [DisplayName("Target Salary")]
    [DataType(DataType.Currency)]
    [Column(TypeName = "decimal(18, 2)")] 
    [Range(0, (double)decimal.MaxValue, ErrorMessage = "Salary must be a positive number.")]
    public decimal TargetSalary { get; set; }

    [DisplayName("Start Date")]
    [DataType(DataType.Date)]
    public DateTime? StartDate { get; set; }

    [DisplayName("Company")]
    public int? CompanyId { get; set; }
    public Company Company { get; set; }

    [DisplayName("Job Title")]
    public int JobTitleId { get; set; }
    public JobTitle JobTitle { get; set; }

    [DisplayName("Industry")]
    public int IndustryId { get; set; }
    public Industry Industry { get; set; }
}