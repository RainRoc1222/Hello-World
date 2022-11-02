using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello_WPF
{
   public class ChangeProperty : INotifyPropertyChanged
    {
        private string myHelloText, myCountText, myTimeText;

        //value就是剛剛指派的"Hello WPF!"字串，會先set，最後在get
        public string HelloText
        {
            get
            {
                return myHelloText;
            }
            set
            {
                myHelloText = value;
                NotifyPropertyChanged();
            }
        }
        public string CountText
        {
            get
            {
                return myCountText;
            }

            set
            {
                myCountText = value;
                NotifyPropertyChanged();
            }
        }
        public string TimeText
        {
            get
            {
                return myTimeText;
            }
            set
            {
                myTimeText = value;
                NotifyPropertyChanged();
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
