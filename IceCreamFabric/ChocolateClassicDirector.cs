using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFabric
{
    public class ChocolateClassicDirector : IDirector
    {
        public IceCream MakeIceCream()
        {
            iceCreamBuilder iceCream = new iceCreamBuilder();
            iceCream.SetAdds("шоколадная стружка");
            iceCream.SetPrice(120);
            iceCream.AddBall("шоколадный шарик");
            iceCream.AddBall("шоколадный шарик");
            iceCream.AddBall("шоколадный шарик");
            return iceCream.GetIceCream();
        }
    }
}
