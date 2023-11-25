﻿using IMS.CoreBuisness;

namespace IMS.UseCases.Inventories.Interfaces
{
    public interface IEditInventoryUseCase
    {
        Task ExecuteAsync(Inventory inventory);
    }
}