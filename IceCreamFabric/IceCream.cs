using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFabric
{
    public class IceCream
    {
       public List<string> Balls { get; set; }
       public  string Syrup { get; set; }
        public string Adds { get; set; }
         public int Price { get; set; }
        public IceCream ()
        {
            Balls = new List<string>();
        }

        public IceCream(List<string> balls, string syrup, string adds, int price)
        {
            Balls = balls;
            Syrup = syrup;
            Adds = adds;
            Price = price;
        }

        public IceCream Clone()
        {
            IceCream iceCream = new IceCream();
            iceCream.Adds = this.Adds;
            iceCream.Balls = new List<string>(this.Balls);
            iceCream.Syrup = Syrup;
            iceCream.Price = Price;
            return iceCream;
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("Ice Cream: \n");
            for (int i = 0; i < Balls.Count; i++)
                stringBuilder.Append($"{Balls[i]} \n");
            if(Syrup != null)
            stringBuilder.Append($"with {Syrup}\n");
            if (Adds != null)
                stringBuilder.Append($" Add: {Adds}\n");
            stringBuilder.Append($"COST: {Price}");
            return stringBuilder.ToString();
        }

    }
}
