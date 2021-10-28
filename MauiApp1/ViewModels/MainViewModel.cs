using Microsoft.Maui.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MauiApp1.ViewModels
{
    public class MainViewModel : BindableObject
    {
        ICommand clickedCommand;
        public ICommand IncrementCommand => clickedCommand ??= new Command(IncrementCount);
        ICommand populateCommand;
        public ICommand PopulateCommand => populateCommand ??= new Command(Populate);
        ICommand getBusyCommand;
        public ICommand GetBusyCommand => getBusyCommand ??= new Command(GetBusy);

        private void IncrementCount()
        {
            Random r = new();
            Count += r.Next(1, 10);
        }

        private int count = 0;
        //[System.ComponentModel.TypeConverter(typeof(int))]
        public int Count
        {
            get => count;
            set
            {
                count = value;
                OnPropertyChanged();
            }
        }

        private void Populate()
        {
            Random r = new();
            Word += (char)r.Next('A', 'Z');
        }

        private string word = "init";
        public string Word
        {
            get => word;
            set
            {
                word = value;
                OnPropertyChanged();
            }
        }

        private bool isBusy;
        public bool IsBusy
        {
            get => isBusy;
            set
            {
                isBusy = value;
                OnPropertyChanged();
            }
        }
        private async void GetBusy()
        {
            IsBusy = true;
            await Task.Delay(3000);
            IsBusy = false;
        }
    }
}
