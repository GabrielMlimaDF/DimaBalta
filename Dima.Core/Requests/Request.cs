namespace Dima.Core.Requests
{
    //Class abstratas não pode ser instanciadas, somente herdadas
    public abstract class Request
    {
        public string UserId { get; set; } = string.Empty;
    }
}
