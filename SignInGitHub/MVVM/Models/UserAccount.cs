using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignInGitHub.MVVM.Models
{
    public class UserAccount
    {
        #region Properties
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }

        public string Password
        {
            get { return _Password; }
            set { _Password = value; }
        }
        #endregion

        public override string ToString()
        {
            return $"ID: {UserName}, PW: {Password}";
        }

        #region Privates
        private string _UserName;
        private string _Password;
        #endregion
    }
}
