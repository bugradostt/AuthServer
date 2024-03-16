using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuthServer.Core.Entity
{
    public class UserRefreshToken
    {
        public string UserId { get; set; }
        public string Code { get; set; } // token code
        public DateTime Expiration { get; set; } // tokenin ömrü
    }
}
