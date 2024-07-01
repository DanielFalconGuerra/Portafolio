using Portafolio.Models.APIFutbol;

namespace Portafolio.Repositories
{
    public interface IApiFutbolRepository
    {
        Task<ResponseTotals> getTotals();
    }
}
