using Xamarin.Forms;

namespace Pasasoft.Crm.Views
{
    public class CustomerListView:ListView
    {
        private const int RowHeightInt = 60;
        public CustomerListView ()
        {
            
            HasUnevenRows = false; // Circumvents calculating heights for each cell individually. The rows of this list view will have a static height.
            RowHeight = RowHeightInt; // set the row height for the list view items
            SeparatorVisibility = SeparatorVisibility.None; // make the row separators invisible, per the intended design of this app

            ItemTemplate = new DataTemplate(typeof(CustomerListItemCell));
        }
    }
}

