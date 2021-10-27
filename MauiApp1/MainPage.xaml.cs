using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage(CounterViewModel viewModel)
        {
            InitializeComponent();
            BindingContext = viewModel;
        }


        protected void ModifyEntryText_Clicked(object sender, EventArgs args)
        {
            CountEntry.Text = "123";
            WordEntry.Text = "Done";
        }
    }

    public class CounterViewModel : BindableObject
    {
        ICommand clickedCommand;
        public ICommand IncrementCommand => clickedCommand ??= new Command(IncrementCount);
        ICommand populateCommand;
        public ICommand PopulateCommand => populateCommand ??= new Command(Populate);

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
    }
}
