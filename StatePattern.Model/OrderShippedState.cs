using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern.Model
{
    public class OrderShippedState : IOrderState
    {
        public bool CanShip(Order order) { return false; }
        public void Ship(Order order) 
        {
            throw new NotImplementedException("ìYou can’t ship a shipped order!");
        }

        public bool CanCancel(Order order)
        {
            return false;
        }

        public void Cancel(Order order)
        {
            throw new NotImplementedException("You can’t cancel a shipped order!”");
        }

        public OrderStatus Status { get { return OrderStatus.Shipped; } }
    }
}
