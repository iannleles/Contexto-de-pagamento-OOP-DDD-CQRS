using System;

namespace PaymentContext.Domain.Entities
{



    public class BoletoPayment : Payment
    {
        public BoletoPayment(string barCode, string boletoNumber, DateTime paidDate,
            DateTime expireDate,
            decimal total,
            DateTime totalPaid,
            string peyer,
            string document,
            string address,
            string email
            ) : base(
                paidDate,
                expireDate,
                total,
                totalPaid,
                peyer,
                document,
                address,
                email
            )
        {
            BarCode = barCode;
            BoletoNumber = boletoNumber;
        }

        public string BarCode { get; private set; }

        public string BoletoNumber { get; private set; }

    }

}