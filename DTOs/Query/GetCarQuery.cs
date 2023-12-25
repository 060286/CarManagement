using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CarManagement.Entities;
using MediatR;

namespace CarManagement.DTOs.Query
{
    /// <summary>
    /// GetCarQuery :
    /// </summary>
    public class GetCarQuery : IRequest<Car>
    {
        public int Id { get; set; }
    }
}