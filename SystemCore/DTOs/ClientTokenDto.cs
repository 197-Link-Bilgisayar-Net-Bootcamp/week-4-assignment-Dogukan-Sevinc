using System;
using System.Collections.Generic;
using System.Text;

namespace System.Core.DTOs
{
    public class ClientTokenDto
    {
        public string AccessToken { get; set; }

        public DateTime AccessTokenExpiration { get; set; }
    }
}