using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace To_Do_List.Model
{
    public class Zadanie : INotifyPropertyChanged
    {
        private int _amount;
        public int Id { get; set; }
        public string? Title { get; set; }
        public DateTime Datetime { get; set; }

        public int Amount
        {
            get => _amount;
            set
            {
                _amount = value;
                OnPropertyChanged(nameof(Amount));
            }
        }

        public Zadanie()
        {
            Datetime = DateTime.Now;
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
