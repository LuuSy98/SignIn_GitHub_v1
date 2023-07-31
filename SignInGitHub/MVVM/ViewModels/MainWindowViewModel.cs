using SignInGitHub.MVVM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace SignInGitHub.MVVM.ViewModels
{
    class MainWindowViewModel : PropertyChangedNotifier
    {
        #region Properties
        public string MyString
        {
            get { return _MyString; }
            set
            {
                _MyString = value;
                OnPropertyChanged();
            }
        }

        public List<UserAccount> AllUser { get; set; }

        public UserAccount CurrentUser
        {
            get { return _CurrentUser; }
            set
            {
                _CurrentUser = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Commands
        public RelayCommand SignInButtonCommand
        {
            get
            {
                return new RelayCommand((o) => {
                    int count = AllUser.Count((user) => user.UserName == CurrentUser.UserName && user.Password == CurrentUser.Password);

                    if (count == 1)
                    {
                        MessageBox.Show("Sign in success!");
                    }
                    else
                    {
                        MessageBox.Show("Check username or password!");
                    }
                });
            }
        }
        #endregion

        #region Constructors
        public MainWindowViewModel()
        {
            AllUser = new List<UserAccount>
            {
                new UserAccount{ UserName="dung1234", Password="pass1234" },
                new UserAccount{ UserName="sy200498", Password="pass200498@" },
            };
        }
        #endregion

        #region Privates
        private string _MyString = "Hello World!";
        private UserAccount _CurrentUser = new UserAccount();
        #endregion
    }
}
