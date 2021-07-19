using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Service.Notify
{
    public abstract class Sendable
    {        
        public abstract void Send(string to, string subject, string message, int invoiceId, string invoicePath);
    }
}
