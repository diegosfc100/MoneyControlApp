using System.ComponentModel.DataAnnotations;

namespace MoneyNote.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        //CategoryId
        public int Amount { get; set; }
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
    }
}
