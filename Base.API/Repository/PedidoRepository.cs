using Base.API.Data;
using Base.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace Base.API.Repository
{
    public class PedidoRepository
    {
        private BaseContext _db;

        public PedidoRepository(BaseContext context)
        {
            _db = context;
        }

        public async Task<Pedido> AddPedido(Pedido pedidoObj)
        {
            _db.Pedidos.Add(pedidoObj);
            await _db.SaveChangesAsync();
            return pedidoObj;
        }

        public async Task<List<Pedido>> BuscarPedidos()
        {
            var pedidos = await (from pedi in _db.Pedidos
                                where pedi.DataPedido.Date == DateTime.Now.Date
                                select pedi).ToListAsync();                
                
            return pedidos;
        }
    }
}
