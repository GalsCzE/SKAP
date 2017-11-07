using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skap.Entity
{
    public class User
        {
            public int ID { get; set; }
            public string slovo { get; set; }

            public override string ToString()
            {
            return "ID = "+ ID + " " + slovo;
            }
        }
}
