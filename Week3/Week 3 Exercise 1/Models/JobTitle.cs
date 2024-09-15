namespace Week_3_Exercise_1.Models
{
    public class JobTitle
    {
        public int JobTitleId { get; set; } // Primary key
        public string Title { get; set; }
        public List<Candidate> Candidates { get; set; }
    }
}
