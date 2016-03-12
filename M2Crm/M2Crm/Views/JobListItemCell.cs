using System;
using Xamarin.Forms;

using Pasasoft.Crm.Models;

namespace Pasasoft.Crm.Views
{
    public class JobListItemCell:ViewCell
    {
        private static double margin = 8;
        private static double rightWidth = 200;

        public Image Image { get; private set; }
        public Label NameLabel { get; private set; }
        public Label StatusLabel { get; private set; }
        public Label CreateTimeLabel { get; private set; }
        public Label LocationLabel { get; private set; }

        public JobListItemCell()
        {
            StyleId = "disclosure";

            Image = new Image();
            Image.Source = ImageSource.FromFile("floorplan.jpg");

            NameLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalTextAlignment = TextAlignment.Center,
                LineBreakMode = LineBreakMode.TailTruncation
            };
            NameLabel.SetBinding(
                Label.TextProperty,
                new Binding("Name"));

            StatusLabel = new Label()
            {
                TextColor = Color.Silver,
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.End,
                LineBreakMode = LineBreakMode.TailTruncation,
            };
            StatusLabel.SetBinding(
                Label.TextProperty,
                new Binding("Status"));

            CreateTimeLabel = new Label()
            {
                TextColor = Color.Silver,
                FontSize = Device.GetNamedSize(NamedSize.Small, typeof(Label)),
                VerticalTextAlignment = TextAlignment.Center,
                HorizontalTextAlignment = TextAlignment.End,
                LineBreakMode = LineBreakMode.TailTruncation
            };
            //CreateTimeLabel.SetBinding(
            //    Label.TextProperty,
            //    new Binding(path: "CreateTime",stringFormat:"g"));

            LocationLabel = new Label()
            {
                TextColor = Color.Silver,
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                VerticalTextAlignment = TextAlignment.Start,
                LineBreakMode = LineBreakMode.WordWrap,
            };
            //LocationLabel.SetBinding(
            //    Label.TextProperty,
            //    new Binding("Location"));

            var contentView = new ContentView();
            contentView.Padding = new Thickness(8, 8, 16, 0);

            RelativeLayout layout = new RelativeLayout();

            layout.Children.Add(
                view: Image,
                xConstraint: Constraint.RelativeToParent(parent => 0),
                yConstraint: Constraint.RelativeToParent(parent => 0),
                widthConstraint: Constraint.RelativeToParent(parent => parent.Height),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height));

            layout.Children.Add(
                view:NameLabel,
                xConstraint: Constraint.RelativeToView(Image, (rl, v) => v.Bounds.Right + margin),
                yConstraint: Constraint.RelativeToParent(parent => 0),
                widthConstraint: Constraint.RelativeToView(Image, (rl, v) => rl.Width - v.Width - rightWidth),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height / 2));


            layout.Children.Add(
                view: StatusLabel,
                xConstraint: Constraint.RelativeToParent(parent => parent.Bounds.Right - rightWidth),
                yConstraint: Constraint.RelativeToParent(parent => 0),
                widthConstraint: Constraint.RelativeToParent(parent => rightWidth),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height / 2));


            layout.Children.Add(
                view: LocationLabel,
                xConstraint: Constraint.RelativeToView(Image, (rl, v) => v.Bounds.Right + margin),
                yConstraint: Constraint.RelativeToParent(parent => parent.Height / 2),
                widthConstraint: Constraint.RelativeToView(Image, (rl, v) => rl.Width - v.Width - 120),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height / 2));

            layout.Children.Add(
                view: CreateTimeLabel,
                xConstraint: Constraint.RelativeToParent(parent => parent.Bounds.Right - 120),
                yConstraint: Constraint.RelativeToParent(parent => parent.Height / 2),
                widthConstraint: Constraint.RelativeToParent(parent => 120),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height / 2));

            // Assign the relativeLayout to Content of contentView
            // This lets us take advantage of ContentView's padding.
            contentView.Content = layout;

            // assign contentView to the View property
            View = contentView;
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();
            var job = BindingContext as Job;
            LocationLabel.Text = job.Location.ToString();
            CreateTimeLabel.Text = job.CreateTime.ToString("d");
        }
    }
}
