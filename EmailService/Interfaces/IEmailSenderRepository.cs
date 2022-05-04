﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailService.Interfaces
{
    public interface IEmailSenderRepository
    {
        void SendEmail(Message message);

        Task SendEmailAsync(Message message);
    }
}
