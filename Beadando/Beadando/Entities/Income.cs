using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beadando.Entities
{
    public class Income
    {
        public Month Month { get; set; }
        public Incometype Incometype { get; set; }
        public int Value { get; set; }
    }
}
