using Android.App;
using Android.OS;

namespace AndroidDemo
{
    [Activity(Label = "Relative Layout", Icon = "@drawable/icon", Theme = "@style/Theme.Custom")]
    public class RelativeLayoutActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.RelativeLayout);
        }
    }
}

