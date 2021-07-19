using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsProject.Service.Notify
{
    public abstract class Sender : Sendable
    {
        protected Sendable _sendable;

        public Sender(Sendable sendable)
        {
            this._sendable = sendable;
        }

        public void SetSendable(Sendable sendable)
        {
            this._sendable = sendable;
        }

        public override void Send(string to, string subject, string message, int invoiceId, string invoicePath)
        {
            if (this._sendable != null)
            {
                this._sendable.Send(to,subject,message,invoiceId,invoicePath);
            }
        }
    }
}
