using Insurance.Application.Abstractions;
using Insurance.Application.Exceptions;
using Insurance.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Insurance.Application.UseCases.Admin.Commands
{
    public class CreateCompanyCommand : ICommand<long>
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Address { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;
    }
    public class CreateCompanyCommandHandler : ICommandHandler<CreateCompanyCommand, long>
    {
        private readonly IApplicationDbContext _context;

        public CreateCompanyCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<long> Handle(CreateCompanyCommand request, CancellationToken cancellationToken)
        {            
            if(await _context.Companys.AnyAsync(x => x.Name == request.Name && x.Email == request.Email && x.Phone == request.Phone, cancellationToken))
            {
                throw new CompanyExistsException();
            }

            var company = new Company
            {
                Name = request.Name,
                Description = request.Description,
                Address = request.Address,
                Email = request.Email,
                Phone = request.Phone,
                CreatedAt = DateTime.UtcNow,
            };

            await _context.Companys.AddAsync(company, cancellationToken);
            await _context.SaveChangesAsync(cancellationToken);

            return company.Id;
        }
    }
}
