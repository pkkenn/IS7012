using System.ComponentModel.DataAnnotations;

namespace RecruitCatAlexiskh.Models;
public class Company
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public int IndustryId { get; set; }
    public Industry Industry { get; set; }
    public List<Candidate> Candidates { get; set; }
}