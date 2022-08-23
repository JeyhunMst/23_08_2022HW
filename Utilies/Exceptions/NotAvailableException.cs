using System;
using System.Collections.Generic;
using System.Text;

namespace _23_08_2022Task.Utilies.Exceptions
{
    class NotAvailableException:Exception
    {
        public NotAvailableException(string message):base(message)
        {

        }
    }
}
