using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using BoysWeekendTop.Base;
using MaterialDesignThemes.Wpf;

namespace BoysWeekendTop.ViewModels
{
    public class AddTopViewModel
    {
        public ICommand CloseCommand => new RelayCommand(() => Close());
        
        private void Close()
        {
            DialogHost.CloseDialogCommand.Execute(null, null);
        }
    }
}
