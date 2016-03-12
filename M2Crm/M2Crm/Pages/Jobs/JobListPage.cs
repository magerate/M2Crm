
using Xamarin.Forms;

using Pasasoft.Crm.Views;
using Pasasoft.Crm.Models;
using Pasasoft.Crm.ViewModels;

namespace Pasasoft.Crm.Pages
{
    public class JobListPage:ContentPage
    {
        public JobListPage()
        {
            Title = "Jobs";
            Icon = new FileImageSource { File = "sales.png" };

            var view = new JobListView();
            view.ItemSelected += ItemSelected;
            view.RowHeight = 80;
            view.ItemsSource = GetJobs();
            Content = view;
        }

        private async void ItemSelected(object sender,SelectedItemChangedEventArgs e)
        {
            var job = e.SelectedItem as Job;
            var jobDetailPage = new JobDetailPage()
            {
                BindingContext = new JobViewModel(job),
            };
            await Navigation.PushAsync(jobDetailPage);
        }


        private Job[] GetJobs()
        {
            var jobs = new[]
            {
                new Job() {Name = "Job1",Status = "Open" },
                new Job() {Name = "Job2",Status = "Open" },
                new Job() {Name = "Job3",Status = "Measured" },
                new Job() {Name = "Job4",Status = "Open" },
                new Job() {Name = "Job5",Status = "Closed" },
                new Job() {Name = "Job6",Status = "Open" },
            };
            return jobs;
        }
    }
}
