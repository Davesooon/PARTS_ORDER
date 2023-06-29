using PARTS_ORDER.Commands;
using PARTS_ORDER.Database;
using PARTS_ORDER.Models;
using PARTS_ORDER.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Xml.Linq;

namespace PARTS_ORDER.ViewModel
{
    public class LoginViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public ICommand btnLoginCommand { get; set; }

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public LoginViewModel()
        {
            LoginVisibility = true;
            btnLoginCommand = new RelayCommand(o => LoginClick("btnLogin"));
        }

        private string _tbUserText;
        public string TextBoxUserText
        {
            get { return _tbUserText; }
            set
            {
                _tbUserText = value;
                OnPropertyChanged(nameof(TextBoxUserText));
            }
        }

        private string _tbPassText;
        public string TextBoxPassText
        {
            get { return _tbPassText; }
            set
            {
                _tbPassText = value;
                OnPropertyChanged(nameof(TextBoxPassText));
            }
        }

        private bool _loginVisibility;
        public bool LoginVisibility
        {
            get { return _loginVisibility; }
            set 
            {
                _loginVisibility = value;
                OnPropertyChanged(nameof(LoginVisibility));
            }
        }

        public string Password { private get; set; }

        private void LoginClick(object sender)
        {
            if (!string.IsNullOrEmpty(_tbUserText) || !string.IsNullOrEmpty(_tbPassText))
            {
                try
                {
                    _tbUserText = _tbUserText.ToUpper();
                    using (var ctx = new DatabaseInitializer())
                    {
                        bool exists = ctx.loginUsers.Any(x => x.LOGIN == _tbUserText);

                        if (exists)
                        {
                            var result = ctx.loginUsers.FirstOrDefault(x => x.LOGIN == _tbUserText && x.HASŁO == _tbPassText);

                            if (result != null)
                            {
                                if (result.ADMIN == "YES") LoginSharedData.Admin = true;
                                else LoginSharedData.Admin = false;
                                LoginSharedData.User = TextBoxUserText;
                                MainWindow mainWindow = new MainWindow();
                                mainWindow.Show();
                                LoginVisibility = false;
                            }
                            else
                            {
                                MessageBox.Show("Nie udało się zalogować, spróbuj ponownie!");
                            }
                        }
                        else MessageBox.Show("Podany użytkownik nie istnieje!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Pole użytkownika lub hasło nie może być puste!");
            }
        }
    }
}
