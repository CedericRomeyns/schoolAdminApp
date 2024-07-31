using System.ComponentModel;
using System.Runtime.CompilerServices;
namespace Cedric_oma_app.Core {

        // class definitie en intergfave implementatie
 internal class ObservableObject : INotifyPropertyChanged
    {
        // event die triggerd als eigenschap van object veranderd
        public event PropertyChangedEventHandler PropertyChanged;

        // methode die event aanroept
        protected void OnPropertyChanged([CallerMemberName] string name = null)
        {
        // event wordt geactiveerd tenzij het het null is
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}

