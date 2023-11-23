using Domain.Entities;
using Domain.Interfaces;
using Persistence.Data;

namespace Application.Repository;

public class PedidoRepository : GenericRepository<Pedido>, IPedido
{
    private readonly GardenContext _context;

    public PedidoRepository(GardenContext context)
        : base(context)
    {
        _context = context;
    }
}
