using System;

using UIKit;
using Foundation;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

using Pasasoft.Crm;
using Pasasoft.Crm.Statics;

namespace M2Crm.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the 
    // User Interface of the application, as well as listening (and optionally responding) to 
    // application events from iOS.
    [Register("AppDelegate")]
    public partial class AppDelegate : FormsApplicationDelegate
    {
        //
        // This method is invoked when the application has loaded and is ready to run. In this 
        // method you should instantiate the window, load the UI into it and then make the window
        // visible.
        //
        // You have 17 seconds to return from this method, or iOS will terminate your application.
        //
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            global::Xamarin.Forms.Forms.Init();
            LoadApplication(new App());

            ConfigureApplicationTheming();
            CopySampleToDocmentPath ();

            MessagingCenter.Subscribe<Page> (this, "ShareFez", ShareFez, null);
            return base.FinishedLaunching(app, options);
        }

        private void ShareFez(Page page)
        {
            var dstPath = System.IO.Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments), "sample.fez");
            var url = new NSUrl (dstPath);

            var item = NSObject.FromObject (url);
            var activityItems = new[] { item }; 
            var activityController = new UIActivityViewController (activityItems, null);

            var topController = UIApplication.SharedApplication.KeyWindow.RootViewController;

            while (topController.PresentedViewController != null) {
                topController = topController.PresentedViewController;
            }

            topController.PresentViewController (activityController, true, null);
        }

        private void CopySampleToDocmentPath()
        {
            var path = NSBundle.MainBundle.PathForResource ("SampleDiagram.fez", null);
            var dstPath = System.IO.Path.Combine (Environment.GetFolderPath (Environment.SpecialFolder.MyDocuments), "sample.fez");
            if (!System.IO.File.Exists (dstPath))
            {
                System.IO.File.Copy (path, dstPath);
            }
        }

        private void ConfigureApplicationTheming()
        {
            UINavigationBar.Appearance.TintColor = UIColor.White;
            UINavigationBar.Appearance.BarTintColor = Palette._001.ToUIColor();
            UINavigationBar.Appearance.TitleTextAttributes = new UIStringAttributes { ForegroundColor = UIColor.White };
            UIBarButtonItem.Appearance.SetTitleTextAttributes(new UITextAttributes { TextColor = UIColor.White }, UIControlState.Normal);

            UITabBar.Appearance.TintColor = UIColor.White;
            UITabBar.Appearance.BarTintColor = UIColor.White;
            UITabBar.Appearance.SelectedImageTintColor = Palette._003.ToUIColor();
            UITabBarItem.Appearance.SetTitleTextAttributes(new UITextAttributes { TextColor = Palette._003.ToUIColor() }, UIControlState.Selected);

            UIProgressView.Appearance.ProgressTintColor = Palette._003.ToUIColor();
        }
    }
}
