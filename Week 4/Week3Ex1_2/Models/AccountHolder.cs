using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;

namespace Week3Ex1_2.Models;

public class AccountHolder
{
    public int ID { get; set; }

    [Display(Name = "First Name")]
    public string FirstName { get; set; }

    [Display(Name = "Last Name")]
    public string LastName { get; set; }

    [Display(Name = "Date of Birth")]
    public DateTime DateOfBirth { get; set; }

    [EmailAddress]
    public string Email { get; set; }

    [Phone]
    [Display(Name = "Phone Number")]
    public string PhoneNumber { get; set; }

    [NotMapped]
    [Display(Name = "Account Holder")]
    public string FullName => $"{FirstName} {LastName}";

    public List<BankAccount>? BankAccounts { get; set; }
}