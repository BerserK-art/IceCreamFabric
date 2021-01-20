using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFabric
{
    public class BananaLend : IDirector
    {
        public IceCream MakeIceCream()
        {
            iceCreamBuilder iceCream = new iceCreamBuilder();
            iceCream.SetAdds("шоколадная стружка");
            iceCream.SetSyrup("банановый сироп");
            iceCream.SetPrice(170);
            iceCream.AddBall("банановый шарик");
            iceCream.AddBall("ананасовый шарик");
            iceCream.AddBall("клубничный шарик");
            return iceCream.GetIceCream();
        }
    }
}
