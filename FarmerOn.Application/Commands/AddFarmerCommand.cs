using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmerOn.Application.Commands
{
    public class AddFarmerCommand : IRequest<int>
    {
        public required string Description { get; set; }
    }
}
