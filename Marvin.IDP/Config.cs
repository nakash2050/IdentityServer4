using IdentityServer4.Models;
using IdentityServer4.Test;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Marvin.IDP
{
    public static class Config
    {
        public static List<TestUser> GetUsers()
        {

            return new List<TestUser>
            {
                new TestUser
                {
                    SubjectId = "64971e95-29d5-45ea-be55-a12ddc388110",
                    Username = "nakash",
                    Password = "password",

                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "nakash"),
                        new Claim("family_name", "sheikh")
                    }
                },
                new TestUser
                {
                    SubjectId = "8174afc1-3a1c-4183-a7e6-bf0f1c3ea4bc",
                    Username = "sabina",
                    Password = "password",

                    Claims = new List<Claim>
                    {
                        new Claim("given_name", "sabina"),
                        new Claim("family_name", "hameed")
                    }
                }
            };
        }

        public static IEnumerable<IdentityResource> GetIdentityResources()
        {
            return new List<IdentityResource>
            {
                new IdentityResources.OpenId(),
                new IdentityResources.Profile()
            };
        }

        public static IEnumerable<Client> GetClients()
        {
            return new List<Client>();
        }
    }
}
