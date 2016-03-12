
using Xamarin.Forms;

namespace Pasasoft.Crm
{
    public class RootPage:NavigationPage
    {
        public RootPage()
        {
            var page = new RootTabbedPage();
            PushAsync(page,false);
            Title = page.Children[0].Title;
        }
    }
}
