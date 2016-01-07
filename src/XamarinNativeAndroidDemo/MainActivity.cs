using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;

namespace AndroidDemo
{
    [Activity(Label = "@string/ApplicationName", MainLauncher = true, Icon = "@drawable/icon", Theme = "@style/Theme.Main")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);
          
            var buttonAbsoluteLayout = FindViewById<Button>(Resource.Id.buttonAbsoluteLayout);
            var buttonFrameLayout = FindViewById<Button>(Resource.Id.buttonFrameLayout);
            var buttonLinearLayout = FindViewById<Button>(Resource.Id.buttonLinearLayout);
            var buttonLinearLayout2 = FindViewById<Button>(Resource.Id.buttonLinearLayout2);
            var buttonGridLayout = FindViewById<Button>(Resource.Id.buttonGridLayout);
            var buttonTableLayout = FindViewById<Button>(Resource.Id.buttonTableLayout);
            var buttonRelativeLayout = FindViewById<Button>(Resource.Id.buttonRelativeLayout);
            var buttonRelativeLayout2 = FindViewById<Button>(Resource.Id.buttonRelativeLayout2);
            var buttonMovie = FindViewById<Button>(Resource.Id.buttonMovie);

            buttonAbsoluteLayout.Click += (s, e) =>
            {
                Intent intent=new  Intent(this,typeof(AbsoluteLayoutActivity));
                StartActivity(intent);
            };

            buttonFrameLayout.Click += (s, e) =>
            {
                Intent intent=new  Intent(this,typeof(FrameLayoutActivity));
                StartActivity(intent);
            };

            buttonLinearLayout.Click += (s, e) =>
            {
                Intent intent=new  Intent(this,typeof(LinearLayoutActivity));
                StartActivity(intent);
            };

            buttonLinearLayout2.Click += (s, e) =>
            {
                Intent intent=new  Intent(this,typeof(LinearLayout2Activity));
                StartActivity(intent);
            };

            buttonGridLayout.Click += (s, e) =>
            {
                Intent intent = new Intent(this, typeof(GridLayoutActivity));
                StartActivity(intent);
            };

            buttonTableLayout.Click += (s, e) =>
            {
                Intent intent = new Intent(this, typeof(TableLayoutActivity));
                StartActivity(intent);
            };

            buttonRelativeLayout.Click += (s, e) =>
            {
                Intent intent = new Intent(this, typeof(RelativeLayoutActivity));
                StartActivity(intent);
            };

            buttonRelativeLayout2.Click += (s, e) =>
            {
                Intent intent = new Intent(this, typeof(RelativeLayout2Activity));
                StartActivity(intent);
            };
            buttonMovie.Click += (s, e) =>
            {
                Intent intent = new Intent(this, typeof(MovieActivity));
                StartActivity(intent);
            };
        }
    }
}

