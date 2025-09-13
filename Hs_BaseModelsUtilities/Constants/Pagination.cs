namespace Hs_BaseModelsUtilities.Constants
{
    public static class Pagination
    {
        public const int DefaultPageSize = 20;
        public const int MaxPageSize = 100;
        public const int MinPageSize = 1;

        /// <summary>
        /// Returns a valid page size within the defined limits.
        /// </summary>
        public static int GetValidPageSize(int pageSize)
        {
            if (pageSize < MinPageSize) return MinPageSize;
            if (pageSize > MaxPageSize) return MaxPageSize;
            return pageSize;
        }

        /// <summary>
        /// Calculates the total number of pages based on total items and page size.
        /// </summary>
        public static int GetTotalPages(int totalItems, int pageSize)
        {
            pageSize = GetValidPageSize(pageSize);
            if (totalItems <= 0) return 0;
            return (totalItems + pageSize - 1) / pageSize;
        }
    }


}
