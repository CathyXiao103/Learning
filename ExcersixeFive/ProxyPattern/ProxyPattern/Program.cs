namespace ProxyPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IChangeTracking IListing = new ProxyListing();
            IListing.GetDiff("Pending", "Active");
        }
    }
}