using Android.App;
using Android.OS;

namespace AndroidDemo
{
    [Activity(Label = "Linear Layout", Icon = "@drawable/icon", Theme = "@style/Theme.Custom")]
    public class LinearLayoutActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.LinearLayout);
        }
    }
}

