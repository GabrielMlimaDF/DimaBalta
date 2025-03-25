namespace Dima.Core.Requests
{
    //Class abstratas não pode ser instanciadas, somente herdadas
    public abstract class PagedRequest : Request
    {
        public int PageNumber { get; set; } = Configuration.DefaultPageNumber;
        public int PageSize { get; set; } = Configuration.DefaultPageSize;
    }
}
