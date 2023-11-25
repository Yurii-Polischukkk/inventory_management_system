using IMS.CoreBuisness;
using IMS.UseCases.Interfaces;
using IMS.UseCases.Inventories.Interfaces;
using System.Threading.Tasks;

namespace IMS.UseCases.Inventories
{
    public class EditInventoryUseCase : IEditInventoryUseCase
    {
        private readonly IInventoryRepository inventoryRepository;

        public EditInventoryUseCase(IInventoryRepository inventoryRepository)
        {
            this.inventoryRepository = inventoryRepository;
        }

        public async Task ExecuteAsync(Inventory inventory)
        {
            // Assuming your repository has a method to update inventory asynchronously
            await this.inventoryRepository.UpdateInventoryAsync(inventory);
        }
    }
}
