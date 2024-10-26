using FarmerOn.Domain.Entities;
using FarmerOn.Domain.IRepositories;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerOn.Application.Commands
{
    public class AddFarmerCommandHandler(IFarmerRepository farmerRepository) : IRequestHandler<AddFarmerCommand, int>
    {
        public Task<int> Handle(AddFarmerCommand request, CancellationToken cancellationToken)
        {
            var farmer = new Farmer
            {
                Description = request.Description
            };

            return farmerRepository.AddFarmerAsync(farmer);
        }
    }

}
