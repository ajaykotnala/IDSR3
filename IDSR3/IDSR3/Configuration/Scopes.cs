using System.Collections.Generic;
using IdentityServer3.Core.Models;

namespace IDSR3.Configuration
{
    public static class Scopes
    {
        public static IEnumerable<Scope> Get()
        {
            return new List<Scope> {
            StandardScopes.OpenId,
            StandardScopes.Profile,
            StandardScopes.Email
        };
        }
    }
}