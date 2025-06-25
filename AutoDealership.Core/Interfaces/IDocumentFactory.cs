namespace AutoDealership.Core.Interfaces
{
    public interface IDocumentFactory
    {
        IContract CreateContract();
        IInvoice CreateInvoice();
        IOffer CreateOffer();
    }
}
