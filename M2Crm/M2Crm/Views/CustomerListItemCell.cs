using System;
using Xamarin.Forms;

using Pasasoft.Crm.Models;

namespace Pasasoft.Crm.Views
{
    public class CustomerListItemCell:ViewCell
    {
        private static double margin = 8;

        public Image Image { get; private set; }
        public Label CompayNameLabel { get; private set; }
        public Label ContactNameLabel { get; private set; }
        public Label LocationLabel { get; private set; }

        public CustomerListItemCell ()
        {
            StyleId = "customer";

            Image = new Image();
            Image.Source = ImageSource.FromFile("Icon-60.png");

            CompayNameLabel = new Label()
            {
                FontSize = Device.GetNamedSize(NamedSize.Medium, typeof(Label)),
                VerticalTextAlignment = TextAlignment.Start,
                HorizontalTextAlignment = TextAlignment.Start,
                LineBreakMode = LineBreakMode.TailTruncation
            };

            CompayNameLabel.SetBinding(
                Label.TextProperty, "Company.Name", BindingMode.TwoWay);

            LocationLabel = new Label()
            {
                TextColor = Color.Silver,
                FontSize = Device.GetNamedSize(NamedSize.Micro, typeof(Label)),
                VerticalTextAlignment = TextAlignment.End,
                HorizontalTextAlignment = TextAlignment.Start,
                LineBreakMode = LineBreakMode.WordWrap,
            };
            LocationLabel.SetBinding(
                Label.TextProperty, "Address.Country", BindingMode.TwoWay);

            ContactNameLabel = new Label () {
                TextColor = Color.Silver,
                FontSize = Device.GetNamedSize (NamedSize.Micro, typeof(Label)),
                VerticalTextAlignment = TextAlignment.End,
                HorizontalTextAlignment = TextAlignment.End,
            };
            ContactNameLabel.SetBinding(
                Label.TextProperty, "Contact.FullName", BindingMode.TwoWay);

            var contentView = new ContentView();
            contentView.Padding = new Thickness(8, 4, 8, 4);

            RelativeLayout layout = new RelativeLayout();

            layout.Children.Add(
                view: Image,
                xConstraint: Constraint.RelativeToParent(parent => 0),
                yConstraint: Constraint.RelativeToParent(parent => 0),
                widthConstraint: Constraint.RelativeToParent(parent => parent.Height),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height));

            layout.Children.Add(
                view:CompayNameLabel,
                xConstraint: Constraint.RelativeToView(Image, (rl, v) => v.Bounds.Right + margin),
                yConstraint: Constraint.RelativeToParent(parent => 0),
                widthConstraint: Constraint.RelativeToParent(parent => parent.Width - parent.Height - margin * 3),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height / 2));
            
            layout.Children.Add(
                view: LocationLabel,
                xConstraint: Constraint.RelativeToView(Image, (rl, v) => v.Bounds.Right + margin),
                yConstraint: Constraint.RelativeToParent(parent => parent.Height / 2),
                widthConstraint: Constraint.RelativeToParent(parent => parent.Width / 3),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height / 2));

            layout.Children.Add(
                view: ContactNameLabel,
                xConstraint: Constraint.RelativeToParent(parent => parent.Width * 2 / 3),
                yConstraint: Constraint.RelativeToParent(parent => parent.Height / 2),
                widthConstraint: Constraint.RelativeToParent(parent => parent.Width / 3),
                heightConstraint: Constraint.RelativeToParent(parent => parent.Height / 2));


            contentView.Content = layout;

            View = contentView;
        }
        protected override void OnAppearing()
        {
            base.OnAppearing();
        }

        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

        }
    }
}

