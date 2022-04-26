using Adapter.Payment.MercadoPagoPayment;
using Adapter.Payment.PayonnerPayment;
using Adapter.Payment.PayPalPayment;
using System;

namespace Adapter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //PayPal payment = new PayPal();
            //IPayPalPayment payment = new PayonnerAdapter(new Payonner());
            IPayPalPayment payment = new MercadoPagoAdapter(new MercadoPago());

            payment.PayPalPayment();
            payment.PaypalReceive();

            Console.ReadLine();
        }
    }
}
