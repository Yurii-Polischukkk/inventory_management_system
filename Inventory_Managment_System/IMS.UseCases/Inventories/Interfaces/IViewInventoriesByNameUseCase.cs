using IMS.CoreBuisness;

namespace IMS.UseCases.Inventories.Interfaces
{
    public interface IViewInventoriesByNameUseCase
    {
        Task<IEnumerable<Inventory>> ExecuteAnsync(string name = "");
    }
}