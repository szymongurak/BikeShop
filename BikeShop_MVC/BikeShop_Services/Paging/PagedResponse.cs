using System;
using System.Collections.Generic;
using System.Text;

namespace BikeShop_Services.Paging
{
    public class PagedResponse<T>
    {
        public List<T> ListOfItems { get; set; }

        public int PageCount { get; set; }

        public int CurrentPage { get; set; }
    }
}
