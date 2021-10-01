using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevIO.AppModelo.Models;

namespace DevIO.AppModelo.Data
{
    public class PedidoRepository : IPedidoRepository
    {
        return new Pedido();
    }
    public interface IPedidoRepository
    {
        Pedido ObterPedido();
    }
}
