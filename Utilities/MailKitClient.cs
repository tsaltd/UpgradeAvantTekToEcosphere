using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MailKit.Net.Smtp;
using MimeKit;

namespace Workspace.Utilities
{
    public class MailKitClient
    {
        private MimeMessage message = new MimeMessage();
        MailboxAddress from = new MailboxAddress("Admin", "admin@example.com");
        message.From.Add(from);
    }
}
