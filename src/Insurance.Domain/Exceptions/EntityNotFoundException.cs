using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Domain.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string entityName) 
            : base($"{entityName} not found")
        {
        }
    }
}
