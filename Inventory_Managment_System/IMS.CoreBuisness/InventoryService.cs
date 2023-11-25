using IMS.CoreBuisness;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

public class InventoryService
{
    private List<Inventory> inventoryList; // Assume this list holds inventory items

    public InventoryService()
    {
        // Initialize the inventory list or fetch data from a database/API
        inventoryList = new List<Inventory>
        {
            // Populate inventory items as needed
            new Inventory { InventoryId = 1, InventoryName = "Item 1", Quantity = 10, Price = 25.99 },
            new Inventory { InventoryId = 2, InventoryName = "Item 2", Quantity = 20, Price = 15.49 },
            // Add more items here if required
        };
    }

    public Task<Inventory> GetInventoryByIdAsync(int inventoryId)
    {
        return Task.FromResult(inventoryList.Find(i => i.InventoryId == inventoryId));
    }

    public void UpdateInventory(Inventory updatedInventory)
    {
        Inventory existingInventory = inventoryList.Find(i => i.InventoryId == updatedInventory.InventoryId);
        if (existingInventory != null)
        {
            // Update the existing inventory with the new details
            existingInventory.InventoryName = updatedInventory.InventoryName;
            existingInventory.Quantity = updatedInventory.Quantity;
            existingInventory.Price = updatedInventory.Price;
            // You might need to save changes to a database or perform other actions here
        }
    }
}
