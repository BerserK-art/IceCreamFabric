using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace IceCreamFabric
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private IceCream _iceCream;
        IceCreamFabrice iceCreamFab;
        public MainWindowViewModel()
        {
            Dictionary<string, IDirector> dict = new Dictionary<string, IDirector>();
            dict.Add("bananalend", new BananaLend());
            dict.Add("chocolate", new ChocolateClassicDirector());
             iceCreamFab =IceCreamFabrice.GetFabric(dict);
            Buy = new MyCommand(BuyCream);
        }
        public MyCommand Buy { get; set; }
        public void BuyCream()
        {
            if(IceCream!=null)
            MessageBox.Show(IceCream.ToString());
            else MessageBox.Show("Мороженное не выбрано!");
        }
        public MyCommand BananaLendIceCream { get; set; }
        public void MakeBananaLend()
        {

            IceCream = iceCreamFab.CreateIceCream("bananalend");
        }
        public MyCommand ChocolateIceCream { get; set; }
        public void MakeChocolate()
        {
            IceCream = iceCreamFab.CreateIceCream("chocolate");
        }
        public IceCream IceCream
        {
            get
            {
                return _iceCream;
            }
            set
            {
                _iceCream = value;
                PropertyChanged?.Invoke(this,new PropertyChangedEventArgs("IceCream"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
