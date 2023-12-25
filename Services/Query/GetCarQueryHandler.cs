using CarManagement.DTOs.Query;
using CarManagement.Entities;
using MediatR;

namespace CarManagement.Services.Query
{
    public class GetCarQueryHandler : IRequestHandler<GetCarQuery, Car>
    {
        public Task<Car> Handle(GetCarQuery request, CancellationToken cancellationToken)
        {
            var result = new Car
            {
                Id = 1,
                Name = "Porcher"
            };

            return Task.FromResult(result);
        }
    }
}