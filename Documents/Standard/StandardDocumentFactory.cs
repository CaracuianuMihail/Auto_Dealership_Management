using AutoDealership.Core.Interfaces;
using AutoDealership.Infrastructure.Documents.Standard;

namespace Auto_Dealership_Management.Documents.Standard
{
    public class StandardDocumentFactory : IDocumentFactory
    {
        public IContract CreateContract() => new StandardContract();
        public IInvoice CreateInvoice() => new StandardInvoice();
        public IOffer CreateOffer() => new StandardOffer();
    }
}
