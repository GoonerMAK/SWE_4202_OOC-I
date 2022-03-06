using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_9_task_2
{
    internal class Account
    {
        string accountNo;

        public void set_accoount(string accountNo)
        {
            this.accountNo = accountNo;
        }

        public string get_account()
        {
            return accountNo;
        }
    }
}
