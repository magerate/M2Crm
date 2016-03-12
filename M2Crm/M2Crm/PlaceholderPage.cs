
using Xamarin.Forms;

namespace Pasasoft.Crm
{
    public class PlaceholderPage : ContentPage
    {
        public PlaceholderPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}
