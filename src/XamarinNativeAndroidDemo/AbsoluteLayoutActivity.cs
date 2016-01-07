using Android.App;
using Android.OS;

namespace AndroidDemo
{
    [Activity(Label = "Absolute Layout", Icon = "@drawable/icon")]
    public class AbsoluteLayoutActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.AbsoluteLayout);
        }
    }
}

