using System.ComponentModel.DataAnnotations;

namespace RecruitCatAlexiskh.Models;
public class Industry
{
    public int ID { get; set; }
    public string Name { get; set; }
    public List<JobTitle> JobTitles { get; set; }
}