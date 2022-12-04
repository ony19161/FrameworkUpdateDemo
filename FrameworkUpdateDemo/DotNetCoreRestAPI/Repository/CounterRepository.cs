namespace DotNetCoreRestAPI.Repository
{
    public class CounterRepository : ICounterRepository
    {
        public int count { get; set; }

        public int GetCount()
        {
            return count++;
        }
    }
}
