namespace Week_3_Exercise_1.Models
{
    public class BankAccount
    {
        public int AccountHolderId { get; set; }
        public string AccountNumber { get; set; }
        public decimal CurrentBalance { get; set; }
        public string AccountName { get; set; }
        public DateTime DateOpened { get; set; }
        public AccountHolder AccountHolder { get; set; }
    }
}
