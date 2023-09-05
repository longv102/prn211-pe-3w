using System;
using System.Collections.Generic;

#nullable disable

namespace BusinessObjects
{
    public partial class AccountMember
    {
        public int AccountId { get; set; }
        public string Password { get; set; }
        public string FullName { get; set; }
        public string EmailAddress { get; set; }
        public int? Role { get; set; }
    }
}
