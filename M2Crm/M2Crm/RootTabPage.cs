
using Xamarin.Forms;

using Pasasoft.Crm.Pages;

namespace Pasasoft.Crm
{
    public class RootTabbedPage : TabbedPage
    {
        public RootTabbedPage()
        {
            Initialize();
            //Navigation
        }

        protected override void OnCurrentPageChanged()
        {
            base.OnCurrentPageChanged();
            Title = CurrentPage.Title;
        }

        private void Initialize()
        {
            Children.Add(new JobListPage());
           
            Children.Add(new PlaceholderPage()
            {
                Title = "Customers",
                Icon = new FileImageSource { File = "customers.png" },
            });

            Children.Add(new PlaceholderPage()
            {
                Title = "Orders",
                Icon = new FileImageSource { File = "products.png" },
            });

            Children.Add(new PlaceholderPage()
            {
                Title = "Me",
                Icon = new FileImageSource { File = "sales.png" },
            });
        }
    }
}
