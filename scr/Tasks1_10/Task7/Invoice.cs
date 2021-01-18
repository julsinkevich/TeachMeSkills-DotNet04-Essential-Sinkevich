using System;
using System.Collections.Generic;
using System.Text;

namespace Essential.Tasks1_10.Task7
{
    class Invoice
    {
        public int account=01234567;
        public string customer= "Petr Petrov", provider= "Bober Bobrov";
        string article;
        int quantity;
        public int Quantity { get; set; }
        public string Article { get; set; }
        public Invoice(int _account, string customer, string provider )
        {
            account =_account;
            this.customer = customer;
            this.provider = provider;
            Article = "";
            Quantity = 0;
        }
    }
}
