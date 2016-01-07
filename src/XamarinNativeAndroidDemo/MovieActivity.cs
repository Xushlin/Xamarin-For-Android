using System.Collections.Generic;
using System.Linq;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Widget;
using AndroidDemo.Common;
using AndroidDemo.CustomAdapter;
using AndroidDemo.Model;
using AndroidDemo.Service;



namespace AndroidDemo
{
    [Activity(Label = "@string/MovieText", Icon = "@drawable/icon", Theme = "@style/Theme.Custom")]
    public class MovieActivity : Activity
    {
        ListView _listViewMovie;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MovieList);
            _listViewMovie = FindViewById<ListView>(Resource.Id.listViewMovie);
            BindData();
            _listViewMovie.ItemClick += _listViewMovie_ItemClick;
        }

        private void _listViewMovie_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            var item = ((MovieAdapter)_listViewMovie.Adapter)[e.Position];
            var intent = new Intent(this, typeof(MovieDetailActivity));
            var jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(item);
            intent.PutExtra("movie", jsonString);
            StartActivity(intent);
        }

        public async void BindData()
        {
            DialogUitls.ShowProgressDialog(this);
            var moves = await MovieService.GetMoviesAsync();
            if (moves != null)
            {
                var movieViewModels = moves.Select(x => x.ToMovie()).ToList();
                _listViewMovie.Adapter = new MovieAdapter(this, movieViewModels);
            }
            DialogUitls.CloseProgressDialog(this);
        }

        private List<Movie> GetDummyData(int count)
        {
            var movies = new List<Movie>();
            for (var i = 1; i <= count; i++)
            {
                var movie = new Movie
                {
                    Name = string.Format("The Shawshank Redemption{0}", i),
                    Description =
                        "20世纪40年代末，小有成就的青年银行家安迪（蒂姆·罗宾斯 Tim Robbins 饰）因涉嫌杀害妻子及她的情人而锒铛入狱。在这座名为肖申克的监狱内，" +
                        "希望似乎虚无缥缈，终身监禁的惩罚无疑注定了安迪接下来灰暗绝望的人生。未过多久，安迪尝试接近囚犯中颇有声望的瑞德（摩根·弗里曼 Morgan Freeman " +
                        "饰），请求对方帮自己搞来小锤子。以此为契机，二人逐渐熟稔，安迪也仿佛在鱼龙混杂、罪恶横生、黑白混淆的牢狱中找到属于自己的求生之道。" +
                        "他利用自身的专业知识，帮助监狱管理层逃税、洗黑钱，同时凭借与瑞德的交往在犯人中间也渐渐受到礼遇。表面看来，" +
                        "他已如瑞德那样对那堵高墙从憎恨转变为处之泰然，但是对自由的渴望仍促使他朝着心中的希望和目标前进。而关于其罪行的真相，" +
                        "似乎更使这一切朝前推进了一步…… ",
                };
                movies.Add(movie);
            }

            return movies;
        }
    }
}

