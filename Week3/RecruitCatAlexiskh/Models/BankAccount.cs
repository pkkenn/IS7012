namespace Week_3_Exercise_1.Models
{
    public class BankAccount
    {
        public int ID { get; set; }
        public string Number { get; set; }
        public decimal CurrentBalance { get; set; }
        public string Name { get; set; }
        public DateTime DateOpened { get; set; }
        public AccountHolder AccountHolder { get; set; }
    }
}
