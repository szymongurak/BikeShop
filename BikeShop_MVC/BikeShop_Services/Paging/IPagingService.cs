using System.Collections.Generic;

namespace BikeShop_Services.Paging
{
    public interface IPagingService
    {
        PagedResponse<T> GetOnePageOfProducts<T>(List<T> listOfItems, int page)  where T : class;
    }
}
