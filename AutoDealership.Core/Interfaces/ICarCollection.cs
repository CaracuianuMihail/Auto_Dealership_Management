namespace AutoDealership.Core.Interfaces
{
    public interface ICarCollection
    {
        ICarIterator GetIterator(string makeFilter);
    }
}
