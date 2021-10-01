using ApplicationCore.Entities;
using ApplicationCore.Exceptions;
using ApplicationCore.Interfaces;
using ApplicationCore.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class BasketService : IBasketService
    {
        private readonly IAsyncRepository<Basket> _basketRepository;
        private readonly IAsyncRepository<BasketItem> _basketItemRepository;

        public BasketService(IAsyncRepository<Basket> basketRepository, IAsyncRepository<BasketItem> basketItemRepository)
        {
            _basketRepository = basketRepository;
            _basketItemRepository = basketItemRepository;
        }

        public async Task AddItemToBasketAsync(int basketId, int productId, int quantity)
        {
            var spec = new BasketWithItemsSpecification(basketId);
            Basket basket = await _basketRepository.FirstOrDefaultAsync(spec);

            if (basket == null)
                throw new BasketNotFoundException(basketId);

            BasketItem item = basket.Items.FirstOrDefault(x => x.ProductId == productId);

            if (item != null)
            {
                item.Quantity += quantity;
            }
            else
            {
                item = new BasketItem()
                {
                    BasketId = basketId,
                    ProductId = productId,
                    Quantity = quantity
                };
                basket.Items.Add(item);
            }

            await _basketRepository.UpdateAsync(basket);
        }

        public async Task<int> BasketItemsCountAsync(int basketId)
        {
            var spec = new BasketItemsSpecification(basketId);
            return await _basketItemRepository.CountAsync(spec);
        }
    }
}
