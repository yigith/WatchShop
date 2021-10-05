namespace Web.ViewModels
{
    public class PaginationInfoViewModel
    {
        public int Page { get; set; }

        public int TotalPages { get; set; }

        public int TotalItems { get; set; }

        public int ItemsOnPage { get; set; }

        public bool HasPrevious { get; set; }

        public bool HasNext { get; set; }
    }
}
