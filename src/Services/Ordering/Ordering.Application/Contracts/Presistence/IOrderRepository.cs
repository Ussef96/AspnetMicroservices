using Ordering.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Application.Contracts.Presistence
{
    public interface IOrderRepository : IAsyncRepository<Order>
    {
        //custom operations beside inherited

        Task<IEnumerable<Order>> GetOrdersByUserName(string userName);
    }
}
