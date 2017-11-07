using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skap.Interface;
using Newtonsoft.Json;

namespace Skap.Jsson
{
    class JsonParse : IParser
    {
        public async Task<T> ParseStringAsync<T>(string response)
        {
            return await Task.Factory.StartNew(() => JsonConvert.DeserializeObject<T>(response));
        }
    }
}
