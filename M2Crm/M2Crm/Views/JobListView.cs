
using Xamarin.Forms;

namespace Pasasoft.Crm.Views
{
    public class JobListView:ListView
    {
        public JobListView()
        {
            ItemTemplate = new DataTemplate(typeof(JobListItemCell));
        }
    }
}
