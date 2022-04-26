using Adapter.Payment.PayPalPayment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Payment.PayonnerPayment
{
    internal class PayonnerAdapter : IPayPalPayment
    {
        private Payonner payonner;
        public PayonnerAdapter(Payonner payonner)
        {
            this.payonner = payonner; 
        }

        public Token AuthToken()
        {
            return this.payonner.AuthToken();
        }

        public void PayPalPayment()
        {
            this.payonner.SendPayment();
        }

        public void PaypalReceive()
        {
            this.payonner.ReceivePayment();
        }
    }
}
