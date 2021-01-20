using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IceCreamFabric
{
    public  class IceCreamFabrice
    {
        static private IceCreamFabrice _fabric;
        private Dictionary<string, IDirector> _dict;
        private IceCreamFabrice(Dictionary<string, IDirector> dict)
        {
            _dict = dict;
        }
        public static IceCreamFabrice GetFabric(Dictionary<string, IDirector> dict)
        {
            if (_fabric == null)
                _fabric = new IceCreamFabrice(dict);
            return _fabric;
        }
        public IceCream CreateIceCream(string icecream)
        {
            IceCream iceCream = new IceCream();
            if (_dict.ContainsKey(icecream))
                iceCream = _dict[icecream].MakeIceCream();
            else throw new IndexOutOfRangeException("No this Kind of Ice Cream");
            return iceCream;
        }
    }
}
