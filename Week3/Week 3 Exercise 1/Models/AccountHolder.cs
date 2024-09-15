namespace Week_3_Exercise_1.Models
{
    public class AccountHolder
    {
        public int AccountHolderId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<BankAccount>? BankAccounts { get; set; }
    }
}
