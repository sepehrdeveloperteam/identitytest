using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace identitytest.Data
{
    public class ApplicationUser : IdentityUser

    {

        public string CustomProp { get; set; }

    }
}
