using Insurance.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Application.Exceptions
{
    public class CompanyNotFoundException : EntityNotFoundException
    {
        private const string _message = "Company";
        public CompanyNotFoundException() : base(_message) {}
    }
}
