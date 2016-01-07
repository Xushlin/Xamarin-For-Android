using Android.App;
using Android.OS;

namespace AndroidDemo
{
    [Activity(Label = "Grid Layout", Icon = "@drawable/icon", Theme = "@style/Theme.Custom")]
    public class GridLayoutActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.GridLayout);
        }
    }
}

