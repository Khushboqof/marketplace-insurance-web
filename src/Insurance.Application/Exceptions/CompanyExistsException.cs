using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Application.Exceptions
{
    public class CompanyExistsException : Exception
    {
        private const string _message = "Company Exists!";

        public CompanyExistsException() : base(_message) { }
    }
}
