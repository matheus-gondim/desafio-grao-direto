using System.Collections.Generic;

namespace GrainRestaurants.Core.Paginated
{
    public class Pageable
    {
        public int PageSize { get => _pageSize; set { _pageSize = value > 250 ? 250 : value; } }
        private int _pageSize = 50;
        public int Page { get => _page; set { _page = value <= 0 ? 1 : value; } }
        private int _page = 1;
        public List<string> SortString { get; set; }
    }
}
