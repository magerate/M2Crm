
using Xamarin.Forms;

using Pasasoft.Crm.ViewModels;

namespace Pasasoft.Crm.Pages
{
    public partial class JobDetailPage : ContentPage
    {
        public JobViewModel JobViewModel => BindingContext as JobViewModel;

        public JobDetailPage()
        {
            InitializeComponent();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            Title = JobViewModel.Job.Name;
        }
    }
}
