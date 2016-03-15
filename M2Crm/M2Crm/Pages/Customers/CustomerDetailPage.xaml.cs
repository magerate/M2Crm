using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Pasasoft.Crm.ViewModels;

namespace Pasasoft.Crm
{
    public partial class CustomerDetailPage : ContentPage
    {
        public CustomerViewModel CustomerViewModel {
            get{ return BindingContext as CustomerViewModel; }
        }

        public CustomerDetailPage ()
        {
            InitializeComponent ();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            Title = CustomerViewModel.Customer.Company.Name;
        }
    }
}

