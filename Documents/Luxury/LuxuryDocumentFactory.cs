using AutoDealership.Core.Interfaces;

namespace Auto_Dealership_Management.Documents.Luxury
{
    public class LuxuryDocumentFactory : IDocumentFactory
    {
        public IContract CreateContract() => new LuxuryContract();
        public IInvoice CreateInvoice() => new LuxuryInvoice();
        public IOffer CreateOffer() => new LuxuryOffer();
    }
}
