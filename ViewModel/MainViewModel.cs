using PARTS_ORDER.Database;
using PARTS_ORDER.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace PARTS_ORDER.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        private PARTS_ORDER_DB _dbContext;
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainViewModel()
        {
            new Login();
        }

        private string _screenVal;
        public string ScreenVal
        {
            get { return _screenVal; }
            set
            {
                _screenVal = value;
                OnPropertyChanged();
            }
        }

        private string _gridValues;
        public string GridValues
        {
            get { return _gridValues; }
            set
            { 
                _gridValues = value;
                OnPropertyChanged();
            }
        }
    }
}
