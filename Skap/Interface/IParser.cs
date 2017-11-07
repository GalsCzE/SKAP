using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skap.Interface
{
    interface IParser
    {
        Task<T> ParseStringAsync<T>(string response);
    }
}
