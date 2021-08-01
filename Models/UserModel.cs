using Br_MES.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Br_MES.Models
{
    public class UserModel : NotifyBase
    {
        /// <summary>
        /// 登录名
        /// </summary>
        private string _userName="1";

        public string UserName
        {
            get { return _userName; }
            set
            {
                _userName = value;
                this.NotifyChanged();
            }
        }

        /// <summary>
        /// 密码
        /// </summary>
        private string _password = "1";

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;
                this.NotifyChanged();
            }
        }
    }
}
