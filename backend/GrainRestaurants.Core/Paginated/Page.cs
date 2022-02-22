using System;
using System.Collections.Generic;

namespace GrainRestaurants.Core.Paginated
{
    public class Page<T> where T : class
    {
        public Page(List<T> items, int currentPage, int pageSize, int totalItems)
        {
            Items = items;
            CurrentPage = currentPage;
            PageSize = pageSize;
            TotalItems = totalItems;
        }

        public List<T> Items { get; set; }
        public int CurrentPage { get; set; }
        public int PageSize { get; set; }
        public int TotalItems { get; set; }
        public int TotalPages
        {
            get
            {
                var totalPages = (int)Math.Ceiling((float)TotalItems / PageSize);
                return totalPages == 0 ? 1 : totalPages;
            }
        }
    }
}
