using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence.Data;

namespace Application.Repository;

public class PagoRepository : GenericRepository<Pago>, IPago
{
    private readonly GardenContext _context;

    public PagoRepository(GardenContext context)
        : base(context)
    {
        _context = context;
    }

    public async Task<IEnumerable<Pago>> GetPaymentsOrderedIn2008()
    {
        var r = await _context
            .Pagos
            .Where(p => p.FechaPago.Year == 2008 && p.FormaPago.ToLower() == "paypal")
            .OrderBy(p => p.Total)
            .ToListAsync();
        return r;
    }
}
