﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MoneyNote.Models
{
    public class Transaction
    {
        [Key]
        public int TransactionId { get; set; }

        [Range(1,int.MaxValue, ErrorMessage = "Por favor, selecione uma categoria.")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "O valor deve ser maior que 0.")]
        public int Amount { get; set; }

        [Column(TypeName = "nvarchar(80)")]
        public string? Note { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        [NotMapped]
        public string? CategoryTitleWithIcon
        {
            get
            {
                return Category == null ? "" : Category.Icon + " " + Category.Title;
            }
        }

        [NotMapped]
        public string? FormattedAmount
        {
            get
            {
                return ((Category == null || Category.Type == "Expense") ? "- " : "+ ") + Amount.ToString("C0");
            }
        }
    }
}
