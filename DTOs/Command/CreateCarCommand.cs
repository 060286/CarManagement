using MediatR;

namespace CarManagement.DTOs.Command
{
    public class CreateCarCommand : IRequest<int>
    {
        public string Name { get; set; }
    }
}