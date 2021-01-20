using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFabric
{
     public class iceCreamBuilder
    {
        private IceCream _iceCream;
        public iceCreamBuilder()
        {
            _iceCream = new IceCream();
        }
        public IceCream GetIceCream()
        {
            return _iceCream;
        }
        public void AddBall(string ball)
        {
            _iceCream.Balls.Add(ball);
        }
        public void SetSyrup(string syrup)
        {
            _iceCream.Syrup = syrup;
        }
        public void SetAdds(string adds)
        {
            _iceCream.Adds = adds;
        }
        public void SetPrice(int price)
        {
            _iceCream.Price = price;
        }
    }
}
