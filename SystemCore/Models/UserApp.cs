using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace System.Core.Models
{
    public class UserApp : IdentityUser
    {
        public string City { get; set; }
    }
}