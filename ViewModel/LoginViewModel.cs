using PARTS_ORDER.Database;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace PARTS_ORDER.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        private PARTS_ORDER_DB _dbContext;
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public LoginViewModel()
        {
        }

        private string _tbUserText;
        public string TextBoxUserText
        {
            get { return _tbUserText; }
            set
            {
                _tbUserText = value;
                OnPropertyChanged();
            }
        }

        private string _tbPassText;
        public string TextBoxPassText
        {
            get { return _tbPassText; }
            set
            {
                _tbPassText = value;
                OnPropertyChanged();
            }
        }


    }
}
