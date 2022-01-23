using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using uppgift1Datalagring.Helpers;

namespace uppgift1Datalagring.Models.VieModels
{
    internal class MainWindowViewModel:ObservableObject
    {

        public RelayCommand CustomersViewCommand { get; set; }
        public RelayCommand CreatCustomerViewCommand { get; set; }
        public RelayCommand CasesViewCommand { get; set; } 
        public RelayCommand CreatCaseViewCommand { get; set; }



        public CustomersViewModel CustomersViewModel { get; set; }
        public CreateCustomerViewModel CreateCustomerViewModel { get; set; }
        public CasesViewModel CasesViewModel { get; set; }
        public CreateCaseViewModel CreateCaseViewModel { get; set; }
        
        
        

        private object _currentView;
        public object CurrentView
        {
            get { return _currentView; }
            set
            { _currentView = value; 
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            CustomersViewModel = new CustomersViewModel();
            CreateCustomerViewModel = new CreateCustomerViewModel();
            CasesViewModel = new CasesViewModel();
            CreateCaseViewModel = new CreateCaseViewModel();

            CurrentView = CreateCaseViewModel;

            CustomersViewCommand = new RelayCommand(x => CurrentView = CustomersViewModel);
            CreatCustomerViewCommand = new RelayCommand(x => CurrentView = CreateCustomerViewModel);
            CasesViewCommand = new RelayCommand(x => CurrentView = CasesViewModel);
            CreatCaseViewCommand = new RelayCommand(x => CurrentView = CreateCaseViewModel);

        }

    }
}
