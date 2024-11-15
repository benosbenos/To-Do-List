using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Windows.Input;
using To_Do_List.Model;

namespace To_Do_List.ViewModel
{
    class MainPageViewModel : INotifyPropertyChanged
    {
        public ObservableCollection<Zadanie> Zadania { get; set; }

        public Zadanie NewZadanie { get; set; }

        public ICommand AddZadanieCmd { get; }

        public MainPageViewModel()
        {
            Zadania = new ObservableCollection<Zadanie>
            {
                new Zadanie {Id = 1, Title = "zadania"}
            };

            AddZadanieCmd = new Command(AddZadanie);
        }

        private void AddZadanie()
        {
            NewZadanie.Id = Zadania.Count + 1;
            Zadania.Add(new Zadanie
            {
                Id = NewZadanie.Id,
                Title = NewZadanie.Title
            });
            NewZadanie = new Zadanie();
            OnPropertyChanged(nameof(NewZadanie));
        }

        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
