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
        private DatabaseFunctions _dbFun;
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainViewModel()
        {
        }

        private List<string> _manufacturer;
        public List<string> Manufacturer
        {
            get { return _manufacturer; }
            set
            {
                _manufacturer = value;
                _dbFun.GetManufacturers();
                OnPropertyChanged();
            }
        }


    }
}
