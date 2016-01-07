using System.Threading.Tasks;
using Android.App;
using Android.OS;
using Android.Widget;

namespace AndroidDemo
{
    [Activity(Label = "Frame Layout", Icon = "@drawable/icon")]
    public class FrameLayoutActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.FrameLayout);
            for (var i = 0; i < ViewIDs.Length; i++)
            {
                _views[i] = FindViewById<TextView>(ViewIDs[i]);
            }

            Task.Factory.StartNew(() =>
            {
                while (true)
                {
                    _handler.PostDelayed(() =>
                    {
                        for (var i = 0; i < ViewIDs.Length; i++)
                        {
                            _views[i].SetBackgroundResource(_colors[(i + _currentColor) % ViewIDs.Length]);
                        }
                        _currentColor++;

                    }, 100);
                }
            });
        }

        private int _currentColor = 0;

        readonly int[] _colors =
        {
            Resource.Color.color1,
            Resource.Color.color2,
            Resource.Color.color3,
            Resource.Color.color4,
            Resource.Color.color5,
            Resource.Color.color6
        };

        static readonly int[] ViewIDs =
        {
            Resource.Id.view01,
            Resource.Id.view02,
            Resource.Id.view03,
            Resource.Id.view04,
            Resource.Id.view05,
            Resource.Id.view06
        };

        private readonly TextView[] _views = new TextView[ViewIDs.Length];
        readonly Handler _handler = new Handler();
    }
}