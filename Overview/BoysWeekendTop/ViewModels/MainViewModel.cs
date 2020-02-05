using System;
using System.Collections.Generic;
using System.Text;
using BoysWeekendTop.Base;
using System.Windows.Input;
using BoysWeekendTop.Views;
using MaterialDesignThemes.Wpf;

namespace BoysWeekendTop.ViewModels
{
    public class MainViewModel : BaseNotifyPropertyChanged
    {
        public MainViewModel()
        {
            Title = "Boys weekend | Top (♥ Mitchel)";
        }

        public string Title { get;  }

        public ICommand AddCommand => new RelayCommand(() => Add());

        private void Add()
        {
            var dialog = new AddTopView
            {
                DataContext = new AddTopViewModel()
            };

            DialogHost.Show(dialog, "RootDialog");
        }
    }
}
