using Prism.Commands;
using Prism.Mvvm;
using SoftPhone.Windows.Phone;
using System;
using System.Collections.Generic;
using System.Text;

namespace SoftPhone.Windows
{
    public class MainWindowViewModel : BindableBase
    {
        private PhoneViewModel phoneViewModel;

        public MainWindowViewModel()
        {
            LoadedCommand = new DelegateCommand(OnLoaded);

            this.phoneViewModel = new PhoneViewModel();
        }

        private BindableBase _currentViewModel;
        public BindableBase CurrentViewModel
        {
            get { return _currentViewModel; }
            set { SetProperty(ref _currentViewModel, value); }
        }

        public DelegateCommand LoadedCommand { get; private set; }

        private void OnLoaded()
        {
            CurrentViewModel = this.phoneViewModel;
        }
    }
}
