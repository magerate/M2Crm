using System;
using System.Windows.Input;

using Xamarin.Forms;
using Plugin.Messaging;

using Pasasoft.Crm.Models;

namespace Pasasoft.Crm.ViewModels
{
    public class CustomerViewModel
    {
        public Customer Customer{ get; set;}

        public CustomerViewModel (Customer customer)
        {
            Customer = customer;
        }
    }
}

