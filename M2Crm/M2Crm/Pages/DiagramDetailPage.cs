using System;

using Xamarin.Forms;

namespace Pasasoft.Crm.Pages
{
    public class DiagramDetailPage : ContentPage
    {
        public DiagramDetailPage ()
        {
            Content = new StackLayout { 
                Children = {
                    new Label { Text = "Diagram content place holder" }
                }
            };

            var actionItem = new ToolbarItem () {
                Text = "Action",
            };
            actionItem.Clicked += delegate
            {
                MessagingCenter.Send<Page>(this,"ShareFez");
            };

            ToolbarItems.Add (actionItem);
        }
    }
}


