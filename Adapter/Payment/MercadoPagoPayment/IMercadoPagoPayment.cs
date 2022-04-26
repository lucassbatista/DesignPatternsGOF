using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Payment.MercadoPagoPayment
{
    internal interface IMercadoPagoPayment
    {
        Token AuthToken();

        void SendPaymentMP();

        void ReceivePaymentMP();
    }
}
