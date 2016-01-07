using Android.App;
using Android.OS;

namespace AndroidDemo
{
    [Activity(Label = "Linear Layout2", Icon = "@drawable/icon", Theme = "@style/Theme.Custom")]
    public class LinearLayout2Activity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.LinearLayout2);
        }
    }
}