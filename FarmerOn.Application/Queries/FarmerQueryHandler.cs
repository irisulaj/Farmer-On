using FarmerOn.Domain.Entities;
using FarmerOn.Domain.IRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerOn.Application.Queries
{
    public class FarmerQueryHandler(IFarmerRepository farmerRepository) : IRequestHandler<FarmerQuery, List<Domain.Entities.Farmer>>
    {
        public Task<List<Farmer>> Handle(FarmerQuery request, CancellationToken cancellationToken)
        {
            return farmerRepository.GetAllFarmersAsync();
        }
    }
}
