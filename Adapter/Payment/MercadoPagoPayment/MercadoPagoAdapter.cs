using Adapter.Payment.PayPalPayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Payment.MercadoPagoPayment
{
    internal class MercadoPagoAdapter : IPayPalPayment
    {
        private MercadoPago mercadoPago;
        public MercadoPagoAdapter(MercadoPago mercadoPago)
        {
            this.mercadoPago = mercadoPago;
        }

        public Token AuthToken()
        {
            return mercadoPago.AuthToken();
        }

        public void PayPalPayment()
        {
            mercadoPago.SendPaymentMP();
        }

        public void PaypalReceive()
        {
            mercadoPago.ReceivePaymentMP();
        }
    }
}
