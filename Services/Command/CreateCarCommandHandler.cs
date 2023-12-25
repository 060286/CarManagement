using CarManagement.DTOs.Command;
using MediatR;

namespace CarManagement.Services.Command
{
    public class CreateCarCommandHandler : IRequestHandler<CreateCarCommand, int>
    {
        public Task<int> Handle(CreateCarCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(1);
        }
    }
}