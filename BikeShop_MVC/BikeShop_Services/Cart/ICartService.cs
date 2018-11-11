using BikeShop_Services.Infrastructure;
using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.Cart
{
    public interface ICartService
    {
        OperationResult AddProductToCart(string userId, int productId, int selectedQuantity);

        OperationResult<CartResponse> GetListOfProductsInCart(string userId);

        OperationResult RemoveProductFromCart(int productId);

        int GetCountOfOrderPositionsInCart(string userId);

        OperationResult<CartResponse> UpadteSelectedQuantity(int orderPositionId, int selectedQuantity);

        int? GetIdOfOrderWithInProgressStatus(string userId);
    }
}
