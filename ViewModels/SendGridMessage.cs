using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using Messages;

namespace Workspace.ViewModels
{
    public class SendGridAlphaInterestedMessage : Email, IEmail
    {
        public string SendTo { get; set; }
        
        SendGridAlphaInterestedMessage(IEmail msg)
        {
            From = "stevem@avanttek.com";
            To = "alphauser@avanttek.com";
            Subject = "ToSAlphaInterested" + DateTime.Now.ToString("d");
            Text = msg.Text;
            SendTo = To;
        }

    }
}
