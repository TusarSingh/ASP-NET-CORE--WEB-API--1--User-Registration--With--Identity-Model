using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


using Microsoft.AspNetCore.Identity;                //       : IdentityUser

namespace Radhey.DAL.IdentityTables
{
    public class TblApplicationUser : IdentityUser
    {
        #nullable disable


        public string FirstName { get; set; }

        public string LastName { get; set; }


    }
}
