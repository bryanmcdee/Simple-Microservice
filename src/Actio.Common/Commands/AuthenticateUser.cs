﻿namespace Actio.Common.Commands
{
    public class AuthenticateUser : ICommand
    {
        public string Email { get; set; }
        public string PassWord { get; set; }
    }
}