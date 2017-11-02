using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ProjectApp.ViewModel.BaseModel
{
    class BaseViewModel : BasePropertyChanged
    {
        public Dictionary<string, ICommand> Commands { get; protected set; }

        public BaseViewModel()
        {
            Commands = new Dictionary<string, ICommand>();
        }
    }
}
