using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces;

public interface IPago : IGeneric<Pago>
{
    Task<IEnumerable<Pago>> GetPaymentsOrderedIn2008();
}
