using System;

namespace ApplicationCore.Exceptions
{
    public class BasketItemsNotFoundException : Exception
    {
        public BasketItemsNotFoundException(int basketId) : base($"The basket with id '${basketId}' has no items.")
        {
        }
    }
}
