using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
namespace WpfApp4
{
    class Board : INotifyPropertyChanged
    {
        private int colour = 5;
        public event PropertyChangedEventHandler PropertyChanged;
        public Board()
        {

        }

        public void ChangeSomething()
        {

            col = col + 1;
        }
        public int col
        {
            get { return colour; }
            set { colour = value; OnPropertyChanged("col"); }
        }

        protected void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }


        }
    }
}
