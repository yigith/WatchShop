using ApplicationCore.Entities;
using Ardalis.Specification;
using System.Linq;

namespace ApplicationCore.Specifications
{
    public class BasketItemsSpecification : Specification<BasketItem>
    {
        public BasketItemsSpecification(int basketId)
        {
            Query.Where(x => x.BasketId == basketId);
        }
    }
}
