using System.ComponentModel.DataAnnotations;

namespace RecruitCatAlexiskh.Models;

public class Candidate
{
    public int ID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public List<JobTitle> JobTitles { get; set; }
}