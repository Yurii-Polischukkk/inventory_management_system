using IMS.CoreBuisness;
using IMS.UseCases.Interfaces;

namespace IMS.Plugins.InMemory
{
    public class InventoryRepository : IInventoryRepository
    {
        private List<Inventory> _inventories;
        public InventoryRepository() 
        {
            _inventories = new List<Inventory>()
            {
                new Inventory() { InventoryId = 1, InventoryName = "Laptop Hp", Quantity = 60, Price = 41999 },
                new Inventory() { InventoryId = 2, InventoryName = "Pc Hp", Quantity = 60, Price = 30999 },
                new Inventory() { InventoryId = 3, InventoryName = "phone Iphone", Quantity = 20, Price = 16999 }
                
            };
        }

        public Task AddInventoryAsync(Inventory inventory)
        {
            if (_inventories.Any(x=>x.InventoryName.Equals(inventory.InventoryName, StringComparison.OrdinalIgnoreCase))) 
                return Task.CompletedTask;

            var maxId = _inventories.Max(x => x.InventoryId);
            inventory.InventoryId = maxId+1;

            _inventories.Add(inventory);

            return Task.CompletedTask;
        }

        public Task<bool> ExistsAsync(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Inventory>> GetInventoriesByNameAsync(string name)
        {
            if (string.IsNullOrWhiteSpace(name)) return await Task.FromResult(_inventories);

            return _inventories.Where(x=> x.InventoryName.Contains(name, StringComparison.OrdinalIgnoreCase));
        }

        public Task UpdateInventoryAsync(Inventory inventory)
        {
            throw new NotImplementedException();
        }

        void IInventoryRepository.AddInventoryAsync(Inventory inventory)
        {
            throw new NotImplementedException();
        }
    }
}