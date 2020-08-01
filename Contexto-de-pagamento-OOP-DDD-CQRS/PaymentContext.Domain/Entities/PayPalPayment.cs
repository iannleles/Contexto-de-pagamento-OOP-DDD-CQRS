using System;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(
            string trasactionCode,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            DateTime totalPaid,
            string peyer,
            string document,
            string address,
            string email) : base(                
                paidDate,
                expireDate,
                total,
                totalPaid,
                peyer,
                document,
                address,
                email)
        {
            TrasactionCode = trasactionCode;
        }

        public string TrasactionCode { get; private set; }
    }
}