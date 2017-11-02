using ProjectApp.DTOClasses;
using ProjectApp.REST;
using ProjectApp.ViewModel.BaseModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace ProjectApp.ViewModel
{
    class LoginViewModel : BaseViewModel
    {
        String username;
        String password;

        public ICommand CreateCommand { get; private set; }

        public INavigation navigation;

        public LoginViewModel()
        {
            CreateCommand = new Command(() => Create());
        }

        public async void Create()
        {
            UserHandler handler = new UserHandler();
            UserDTO a = new UserDTO("odisnfds@asipdmas.dk", "123456", "123456");
            await handler.CreateUser(a);
        }

        public String Username
        {
            get { return username; }
            set
            {
                username = value;
                OnPropertyChanged();
            }
        }
        public String Password
        {
            get { return password; }
            set
            {
                password = value;
                OnPropertyChanged();
            }
        }
    }
}
