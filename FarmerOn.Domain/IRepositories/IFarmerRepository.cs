using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmerOn.Domain.Entities;

namespace FarmerOn.Domain.IRepositories
{
    public interface IFarmerRepository
    {
        Task<List<Farmer>> GetAllFarmersAsync();
        Task<int> AddFarmerAsync(Farmer farmer);

    }
}
