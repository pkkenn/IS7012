namespace Week_3_Exercise_1.Models
{
    public class Candidate
    {
        public int CandidateId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<JobTitle> JobTitles { get; set; }
    }
}
