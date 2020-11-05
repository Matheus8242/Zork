using InventoryManager.Data;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Zork.Builder.WinForms.ViewModels
{
    public class WorldViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Filename { get; set; }
        public BindingList<Player> Player { get; set; }
        public BindingList<Item> Items { get; set; }
        public World World { get; set; }
    }
}
