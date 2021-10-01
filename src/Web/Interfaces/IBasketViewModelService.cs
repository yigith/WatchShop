using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Web.ViewModels;

namespace Web.Interfaces
{
    public interface IBasketViewModelService
    {
        Task<BasketItemAddedViewModel> AddItemToBasketAsync(int productId, int quantity);

        Task<int> GetOrCreateBasketIdAsync();

        Task<NavbarBasketViewModel> GetNavbarBasketViewModelAsync();
    }
}
