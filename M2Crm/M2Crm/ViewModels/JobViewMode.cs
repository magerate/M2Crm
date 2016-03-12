using System;
using System.Windows.Input;

using Xamarin.Forms;
using Plugin.Messaging;

using Pasasoft.Crm.Models;

namespace Pasasoft.Crm.ViewModels
{
    public class JobViewModel
    {
        ICommand _PhoneIconTappedCommand;

        public Job Job { get; set; }

        public JobViewModel(Job job)
        {
            Job = job;
        }


        public ICommand PhoneIconTappedCommand
        {
            get
            {
                return _PhoneIconTappedCommand ?? (_PhoneIconTappedCommand = new Command<Label>(ExecutePhoneIconTappedCommand));
            }
        }

        void ExecutePhoneIconTappedCommand(Label label)
        {
            if (label == null)
                return;

            string phoneNumber = label.Text;

            if (String.IsNullOrWhiteSpace(phoneNumber))
                return;

            //if (await CurrentPage.DisplayAlert(
            //        title: TextResources.Customers_Detail_CallDialog_Title,
            //        message: TextResources.Customers_Detail_CallDialog_Message + phoneNumber + "?",
            //        accept: TextResources.Customers_Detail_CallDialog_Accept,
            //        cancel: TextResources.Customers_Detail_CallDialog_Cancel))
            //{
                var phoneCallTask = MessagingPlugin.PhoneDialer;
                if (phoneCallTask.CanMakePhoneCall)
                    phoneCallTask.MakePhoneCall(phoneNumber.Replace("-", ""));
            //}
        }
    }
}
