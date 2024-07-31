using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace voedselbeheer_app.Core
{
    // class definitie en interface implementatie
    internal class RelayCommand : ICommand
    {
    
    // velden initialiseren
        private Action<object> _execute;
        private Func<object, bool> _canExecute;

    // event die triggerd als uitvoerbaarheid van het commando veranderd
        public event EventHandler? CanExecuteChanged
        {
            add {CommandManager.RequerySuggested += value;} 
            remove { CommandManager.RequerySuggested -= value;}
        }

    // constructor ( initialiseert "RelayCommand" ) 
    // met de acties voor de uitvoering 'execute' , en of het uitgevoerd kan worden 'canExecute' --> optioneel en kan null zijn. 

        public RelayCommand(Action<object> execute, Func<object, bool> canExecute = null)
        {
            _execute = execute;
            _canExecute = canExecute;
        }

    // methode die controleert of het commando uitgevoerd kan worden
        public bool CanExecute(object parameter)
        {
            return _canExecute == null || _canExecute(parameter);
        }

    // methode die het commando uitvoert
        public void Execute(object? parameter)
        {
            _execute(parameter);
        }
    }
}
