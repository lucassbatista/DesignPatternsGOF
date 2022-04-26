using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter.Payment
{
    internal class Token
    {
        private string _token = "NAQLwFEO0lixrrUaezAvYE00q0lUyQ0d5ZEK9XFVQoSKnbOlScjEzXFEdmBF";

        public string GetToken() 
        { 
            return _token; 
        }
    }
}
