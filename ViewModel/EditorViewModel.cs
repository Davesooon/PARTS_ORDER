using PARTS_ORDER.Commands;
using PARTS_ORDER.Database;
using PARTS_ORDER.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PARTS_ORDER.ViewModel
{
    public class EditorViewModel
    {
        public ICommand EditCommand { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;
        private void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        public EditorViewModel()
        {
            EditCommand = new RelayCommand(o => EditData("EditData"));
            GetData();
        }

        private int _edId;
        public int EdId
        {
            get { return _edId; }
            set
            {
                _edId = value;
                OnPropertyChanged(nameof(EdId));
            }
        }

        private string _edWydawca;
        public string EdWydawca
        {
            get { return _edWydawca; }
            set
            {
                _edWydawca = value;
                OnPropertyChanged(nameof(EdWydawca));
            }
        }

        private string _edNazwa;
        public string EdNazwa
        {
            get { return _edNazwa; }
            set
            {
                _edNazwa = value;
                OnPropertyChanged(nameof(EdNazwa));
            }
        }

        private int _edPartId;
        public int EdPartId
        {
            get { return _edPartId; }
            set
            {
                _edPartId = value;
                OnPropertyChanged(nameof(EdPartId));
            }
        }

        private int _edKluczProduktu;
        public int EdKluczProduktu
        {
            get { return _edKluczProduktu; }
            set
            {
                _edKluczProduktu = value;
                OnPropertyChanged(nameof(EdKluczProduktu));
            }
        }

        private double _edKoszt;
        public double EdKoszt
        {
            get { return _edKoszt; }
            set
            {
                _edKoszt = value;
                OnPropertyChanged(nameof(EdKoszt));
            }
        }

        private int _edIlosc;
        public int EdIlosc
        {
            get { return _edIlosc; }
            set 
            {
                _edIlosc = value;
                OnPropertyChanged(nameof(EdIlosc));
            }
        }

        private void EditData(object sender)
        {
            PARTS_SELLER_DTO partDto = new PARTS_SELLER_DTO
            {
                ID = EdId,
                WYDAWCA = EdWydawca,
                NAZWA = EdNazwa,
                ID_CZĘŚCI = EdPartId,
                KLUCZ_PRODUKTU = EdKluczProduktu,
                KOSZT = EdKoszt,
                ILOŚĆ = EdIlosc,
            };

            DatabaseFunctions.Update(partDto);
        }

        private void GetData()
        {
            EdId = SharedDataStore.Id;
            EdWydawca = SharedDataStore.Wydawca;
            EdNazwa = SharedDataStore.Nazwa;
            EdPartId = SharedDataStore.PartId;
            EdKluczProduktu = SharedDataStore.KluczProduktu;
            EdKoszt = SharedDataStore.Koszt;
            EdIlosc = SharedDataStore.Ilosc;
        }

    }
}
