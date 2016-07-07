

namespace EmbeddedNativeControl.Droid
{
    using Android.Support.Design.Widget;
    using Android.Widget;
    using EmbeddedNativeControl.Controls;
    using Xamarin.Forms;
    using Xamarin.Forms.Platform.Android;

    public class FloatButton : IFloatingButton
    {
        public View BuildFloatingButton()
        {
            FloatingActionButton fButton = new FloatingActionButton(Forms.Context)
            {
                UseCompatPadding = true
            };
            fButton.SetImageResource(Droid.Resource.Drawable.icon);

            //fButton.Click += (sender, args) =>
            //{
            //    fButton.Show();
            //    Toast.MakeText(Forms.Context, "Event in XAndroid", ToastLength.Long).Show();
            //};

            View view = fButton.ToView();

            TapGestureRecognizer tapGesture = new TapGestureRecognizer
            {
                Command = new Command(
                    () =>
                    {
                        fButton.Show();
                        Toast.MakeText(Forms.Context, "Event in Android", ToastLength.Long).Show();
                    })

            };

            view.GestureRecognizers.Add(tapGesture);

            return view;
        }


    }
}