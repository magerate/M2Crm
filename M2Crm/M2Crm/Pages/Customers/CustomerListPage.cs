using Xamarin.Forms;

using Pasasoft.Crm.Views;
using Pasasoft.Crm.Models;
using Pasasoft.Crm.ViewModels;


namespace Pasasoft.Crm
{
    public class CustomerListPage:ContentPage
    {
        public CustomerListPage ()
        {
            Title = "Customer";
            Icon = new FileImageSource { File = "customers.png" };

            var view = new CustomerListView();
            view.ItemSelected += ItemSelected;
//            view.RowHeight = 80;
            view.ItemsSource = GetCustomers();
            Content = view;
        }

        private async void ItemSelected(object sender,SelectedItemChangedEventArgs e)
        {
            var customer = e.SelectedItem as Customer;
            var customDetailPage = new CustomerDetailPage()
            {
                BindingContext = new CustomerViewModel(customer),
            };
            await Navigation.PushAsync(customDetailPage);
        }


        private Customer[] GetCustomers()
        {
            var customers = new[] {
                new Customer (){ Contact = new Contact(){ FirstName = "Contact"}, Company = new Company{Name = "Xamarin"}, Address = new Address(){ Country = "USA"} },
                new Customer (){ Contact = new Contact(){ FirstName = "Contact1"}, Company = new Company{Name = "Microsoft"}, Address = new Address(){ Country = "USA"}  },
                new Customer (){ Contact = new Contact(){ FirstName = "Contact2"}, Company = new Company{Name = "Xamarin"}, Address = new Address(){ Country = "USA"}  },
                new Customer (){ Contact = new Contact(){ FirstName = "Contact3"}, Company = new Company{Name = "Microsoft"}, Address = new Address(){ Country = "USA"}  },
            };
            return customers;
        }
    }
}

