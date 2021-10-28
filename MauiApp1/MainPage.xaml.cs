using MauiApp1.ViewModels;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;
using System.ComponentModel;
using System.Windows.Input;

namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {

        public MainPage(MainViewModel viewModel)
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
}
