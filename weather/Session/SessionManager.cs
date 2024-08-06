using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace weather
{
    public static class SessionManager 
    {
        public static bool IsAuthenticated { get; set; } = false;
        public static string LogAs { get; set; } = null;
    }
}
