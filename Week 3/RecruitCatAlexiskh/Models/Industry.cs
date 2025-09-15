using System.ComponentModel.DataAnnotations;

namespace RecruitCatAlexiskh.Models;
public class Industry
{
    public int ID { get; set; }
    public string Name { get; set; }
    public List<Candidate> Candidates { get; set; }
    public List<Company> Companies { get; set; }
}