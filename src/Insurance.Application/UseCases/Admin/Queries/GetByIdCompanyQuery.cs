using Insurance.Application.Abstractions;
using Insurance.Application.DTOs;
using Insurance.Application.Exceptions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Application.UseCases.Admin.Queries
{
    public class GetByIdCompanyQuery : IQuery<CompanyViewModel>
    {
        public long Id { get; set; }
    }

    public class GetByIdCompanyQueryHandler : IQueryHandler<GetByIdCompanyQuery, CompanyViewModel>
    {
        private readonly IApplicationDbContext _context;

        public GetByIdCompanyQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<CompanyViewModel> Handle(GetByIdCompanyQuery request, CancellationToken cancellationToken)
        {
            var company = await _context.Companys.FirstOrDefaultAsync(x => x.Id == request.Id);

            if(company == null)
            {
                throw new CompanyNotFoundException();
            }

            return new CompanyViewModel()
            {
                Name = company.Name,
                Description = company.Description,
                Address = company.Address,
                Email = company.Email,
                Phone = company.Phone,
                CreatedAt = company.CreatedAt
            };
        }
    }
}
