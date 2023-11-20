using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Entities;

namespace Domain.Interfaces;

public interface ICliente : IGeneric<Cliente>
{
    Task<IEnumerable<Cliente>> CustomersWhoHaveNotMadePayments();
}
