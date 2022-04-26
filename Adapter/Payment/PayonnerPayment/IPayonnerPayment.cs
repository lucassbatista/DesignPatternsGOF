using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Payment.PayonnerPayment
{
    internal interface IPayonnerPayment
    {
        Token AuthToken();

        void SendPayment();

        void ReceivePayment();
    }
}
