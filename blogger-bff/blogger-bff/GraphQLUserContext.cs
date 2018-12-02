using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace blogger_bff
{
    public class GraphQLUserContext
    {
        public ClaimsPrincipal User { get; set; }
    }
}
