using PARTS_ORDER.Commands;
using PARTS_ORDER.Database;
using PARTS_ORDER.Database.Tables;
using PARTS_ORDER.Models;
using PARTS_ORDER.View;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace PARTS_ORDER.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public ICommand AddPartCommand { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;

        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainViewModel()
        {
            UserLogged = LoginViewModel.user;
            UserRole = LoginViewModel.isAdmin ? "Admin" : "Użytkownik";
            AddPartCommand = new RelayCommand(o => AddNewPart("AddNewPart"));
            RefreshDataGrid();
        }

        private List<PARTS_SELLER_DTO> _partsSellersTable;
        public List<PARTS_SELLER_DTO> PartsSellersTable
        {
            get { return _partsSellersTable; }
            set
            {
                _partsSellersTable = value;
                OnPropertyChanged(nameof(PartsSellersTable));
            }
        }

        private string wydawca;
        public string Wydawca
        {
            get { return wydawca; }
            set
            {
                wydawca = value;
                OnPropertyChanged(nameof(Wydawca));
            }
        }

        private List<string> wydawcy;
        public List<string> Wydawcy
        {
            get { return wydawcy; }
            set
            {
                wydawcy = value;
                OnPropertyChanged(nameof(Wydawcy));
            }
        }

        private string partName;
        public string PartName
        {
            get { return partName; }
            set
            {
                partName = value;
                OnPropertyChanged(nameof(PartName));
            }
        }

        private int qty;
        public int Qty
        {
            get { return qty; }
            set
            {
                qty = value;
                OnPropertyChanged(nameof(Qty));
            }
        }

        private double price;
        public double Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged(nameof(Price));
            }
        }

        private int productKey;
        public int ProductKey
        {
            get { return productKey; }
            set
            {
                productKey = value;
                OnPropertyChanged(nameof(ProductKey));
            }
        }

        private string userLogged;
        public string UserLogged
        {
            get { return userLogged; }
            set
            {
                userLogged = value;
                OnPropertyChanged(nameof(UserLogged));
            }
        }

        private string userRole;
        public string UserRole
        {
            get { return userRole; }
            set
            {
                userRole = value;
                OnPropertyChanged(nameof(UserRole));
            }
        }

        private void AddNewPart(object sender)
        {
            DatabaseFunctions.AddPart(new CHECK_PARTS
            {
                NAZWA = PartName,
                KLUCZ_PRODUKTU = ProductKey,
                WYDAWCA = Wydawca,
                ILOŚĆ = Qty
            },
            new PARTS_SELLER
            {
                WYDAWCA = Wydawca,
                KOSZT = Price
            });
            RefreshDataGrid();
        }

        private void RefreshDataGrid()
        {
            Wydawcy = DatabaseFunctions.GetManufacturers();
            PartsSellersTable = DatabaseFunctions.GetTable();
        }
    }
}
