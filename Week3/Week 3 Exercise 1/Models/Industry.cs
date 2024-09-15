namespace Week_3_Exercise_1.Models
{
    public class Industry
    {
        public int IndustryId { get; set; }
        public string Name { get; set; }
        public List<JobTitle> JobTitles { get; set; }
    }
}
