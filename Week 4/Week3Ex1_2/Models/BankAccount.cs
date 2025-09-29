using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Week3Ex1_2.Models
{
    public class BankAccount
    {
        public int ID { get; set; }
        
        [Display(Name = "Account Number")]
        public string? Number { get; set; } 

        [Display(Name = "Current Balance")]
        [DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")] 
        public decimal CurrentBalance { get; set; }

        [Display(Name = "Account Nickname")]
        public string? Name { get; set; } 

        [Display(Name = "Date Opened")]
        [DataType(DataType.Date)]
        public DateTime DateOpened { get; set; }

        [Display(Name = "Account Holder")]
        public int AccountHolderId { get; set; }

        public AccountHolder? AccountHolder { get; set; } 
    }
}