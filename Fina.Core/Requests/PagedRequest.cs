namespace Fina.Core.Requests
{
    public abstract class PagedRequest : Request
    {
        public int PageSize { get; set; } = 25;

        public int PageNumbert { get; set; } = 1;
    }
}
