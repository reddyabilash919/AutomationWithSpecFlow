using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFrameworkWithSpecFlow.Models.Data
{
    public class Register
    {

        public string? Email { get; set; }
        public string? Password { get; set; }

        public int? Id { get; set; }
        public string? Token { get; set; }

        public string? Error { get; set; }
    }
}
