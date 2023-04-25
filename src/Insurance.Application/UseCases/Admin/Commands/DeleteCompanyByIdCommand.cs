using Insurance.Application.Abstractions;
using Insurance.Application.Exceptions;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Insurance.Application.UseCases.Admin.Commands
{
    public class DeleteCompanyByIdCommand : ICommand<Unit>
    {
        public long Id { get; set; }
    }

    public class DeleteCompanyByIdCommandHandler : ICommandHandler<DeleteCompanyByIdCommand, Unit>
    {
        private readonly IApplicationDbContext _context;

        public DeleteCompanyByIdCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteCompanyByIdCommand request, CancellationToken cancellationToken)
        {
            var company = await _context.Companys.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);

            if (company == null)
            {
                throw new CompanyNotFoundException();
            }

            _context.Companys.Remove(company);
            await _context.SaveChangesAsync();

            return Unit.Value;
        }
    }
}
