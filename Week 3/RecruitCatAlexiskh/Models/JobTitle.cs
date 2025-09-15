using System.ComponentModel.DataAnnotations;

namespace RecruitCatAlexiskh.Models;
public class JobTitle
{
    public int ID { get; set; } // Primary key
    public string Title { get; set; }
    public decimal MinSalary { get; set; }
    public decimal MaxSalary { get; set; }
    public bool IsRemote { get; set; }
    public List<Candidate> Candidates { get; set; }
}