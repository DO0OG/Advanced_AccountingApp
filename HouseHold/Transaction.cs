using System;

namespace AccountingApp
{
    public class Transaction
    {
        public DateTime Date { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public double Amount { get; set; }  // decimal에서 double로 변경
        public string? Category { get; set; }
        public string? PaymentMethod { get; set; }
    }
}