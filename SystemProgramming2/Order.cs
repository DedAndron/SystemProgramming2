using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace SystemProgramming2
{
    public class Order
    {
        public required int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
    }
}
