using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Application.DTOs
{
    public class CompanyViewModel
    {
        public string Name { get; set; } 
        public string Description { get; set; } 
        public string Address { get; set; } 
        public string Email { get; set; } 
        public string Phone { get; set; } 
        public DateTime CreatedAt { get; set; }
    }
}
