using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;

public class ClienteRepository : GenericRepository<Cliente>, ICliente
{
    private readonly GardenContext _context;

    public ClienteRepository(GardenContext context)
        : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Cliente>> CustomersWhoHaveNotMadePayments()
    {
        var r = await _context.Clientes.Where(c => c.Pagos.Count == 0).ToListAsync();
        return r;
    }
}
