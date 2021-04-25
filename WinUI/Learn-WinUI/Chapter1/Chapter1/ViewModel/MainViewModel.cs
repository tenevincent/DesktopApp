using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter1.ViewModel
{
    public class MainViewModel : BindableBase
    {
      
        private string _name;

        public MainViewModel()
        {
            Name = "Bob Jones";
        }

        public string Name
        {
            get => _name;
            set => this.SetProperty(ref _name, value, nameof(Name));

        }
    }
}
