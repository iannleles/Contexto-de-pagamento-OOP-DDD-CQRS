using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public class PayPalPayment : Payment
    {
        public PayPalPayment(
            string trasactionCode,
            DateTime paidDate,
            DateTime expireDate,
            decimal total,
            decimal totalPaid,
            string peyer,
            Document document,
            Address address,
            Email email) : base(
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