using System.ComponentModel.DataAnnotations;

namespace RecruitCatAlexiskh.Models;
public class Company
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public List<JobTitle> JobTitles { get; set; }
}