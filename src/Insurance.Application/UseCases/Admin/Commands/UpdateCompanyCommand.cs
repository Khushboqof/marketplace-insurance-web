﻿using Insurance.Application.Abstractions;
using Insurance.Application.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insurance.Application.UseCases.Admin.Commands
{
    public class UpdateCompanyCommand : ICommand<Unit>
    {
        public long Id { get; set; }
        public string Name { get; set; } 
        public string Description { get; set; }
        public string Address { get; set; } 
        public string Email { get; set; } 
        public string Phone { get; set; }
        public DateTime CreatedAt { get; set; }
    }

    public class UpdateCompanyCommandHandler : ICommandHandler<UpdateCompanyCommand, Unit>
    {
        private readonly IApplicationDbContext _context;

        public UpdateCompanyCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(UpdateCompanyCommand request, CancellationToken cancellationToken)
        {
            var company = await _context.Companys.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if(company == null)
            {
                throw new CompanyNotFoundException();
            }

            company.Name = request.Name ?? company.Name;
            company.Description = request.Description ?? company.Description;
            company.Address = request.Address ?? company.Address;
            company.Email = request.Email ?? company.Email;
            company.Phone = request.Phone ?? company.Phone;
            company.CreatedAt = request.CreatedAt;

            _context.Companys.Update(company);
            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
