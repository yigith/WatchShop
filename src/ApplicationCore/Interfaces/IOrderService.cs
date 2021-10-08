using ApplicationCore.Entities;
using System.Threading.Tasks;

namespace ApplicationCore.Interfaces
{
    public interface IOrderService
    {
        Task<int> CreateOrderAsync(int basketId, Address address); 
    }
}
