using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cedric_oma_app.Core;


namespace Cedric_oma_app.MVVM.ViewModel
{ 

    // klasse definitie
    class MainViewModel : ObservableObject
    {

    // eigenschap HomeViewModel
        public HomeViewModel homeViewModel { get; set; }

    // eigenschap CurrentView
        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }
    
    // constructor
        public MainViewModel()
    
        {
        homeViewModel = new HomeViewModel();
        CurrentView = homeViewModel;
    
        }
    }
}
