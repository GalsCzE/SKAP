using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skap.Entity;

namespace Skap.Interface
{
    interface IWebClient
    {
        Task<List<User>> GetUserListAsync();
    }
}
