using Insurance.Application.Abstractions;
using Insurance.Application.DTOs;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Application.UseCases.Admin.Queries
{
    public class GetAllCompaniesQuery : IQuery<List<CompanyViewModel>>
    {
    }

    public class GetAllCompaniesQueryHandler : IQueryHandler<GetAllCompaniesQuery, List<CompanyViewModel>>
    {
        private readonly IApplicationDbContext _context;

        public GetAllCompaniesQueryHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<CompanyViewModel>> Handle(GetAllCompaniesQuery request, CancellationToken cancellationToken)
        {
            return await _context.Companys
                .Select(x => new CompanyViewModel()
                {
                    Name = x.Name,
                    Description = x.Description,
                    Address = x.Address,
                    Email = x.Email,
                    Phone = x.Phone,
                    CreatedAt = x.CreatedAt

                }).ToListAsync();
        }
    }
}
