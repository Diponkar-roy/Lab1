using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Lab6
{
    class Coustomer
    {
        public string accName
        {
            get { return accName; }
            set { accName = value; }
        }
        private string name;

        public string accid
        {
            get { return accid; }
            set { accid = value; }
        }

        public int balance
        {
            get { return balance; }
            set { balance = value; }
        }
        publicCustomer() { }
        public CustomErrorsModes (string name, string id, int balance)
        {
            this.name = name;
            this.id = id;
            this.balance = balance;
        }

        public void ShowInfo()
        {
            Console.WriteLine("name: " + name);
            Console.WriteLine("id: " + id);
            Console.WriteLine("balance: " + balance);
        }

    }
}
