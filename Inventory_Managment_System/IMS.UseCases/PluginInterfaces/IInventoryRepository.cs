using IMS.CoreBuisness;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMS.UseCases.Interfaces
{
    public interface IInventoryRepository
    {
        void AddInventoryAsync(Inventory inventory);
        Task<bool> ExistsAsync(Inventory inventory);
        Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name);
        Task UpdateInventoryAsync(Inventory inventory);
    }
}
