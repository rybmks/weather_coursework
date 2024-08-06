using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather
{
    public class Weather
    {
        public string City { get; set; }
        public string Date { get; set; }
        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}
