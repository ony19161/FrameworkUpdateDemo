namespace DotNetCoreRestAPI.Repository
{
    public interface ICounterRepository
    {
        int count { get; set; }

        int GetCount();

    }
}
