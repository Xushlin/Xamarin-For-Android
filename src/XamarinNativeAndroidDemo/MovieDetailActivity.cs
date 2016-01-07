using Android.App;
using Android.OS;
using Android.Widget;
using AndroidDemo.Model;
using Newtonsoft.Json;

namespace AndroidDemo
{
    [Activity(Label = "@string/MovieDetailText", Icon = "@drawable/icon", Theme = "@style/Theme.Custom")]
    public class MovieDetailActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.MovieDetails);
            var movie =JsonConvert.DeserializeObject<Movie>(Intent.GetStringExtra("movie"));
            BindData( movie);
        }

        public  void BindData(Movie movie)
        {
            var name = FindViewById<TextView>(Resource.Id.txtName);
            var grade = FindViewById<TextView>(Resource.Id.txtGrade);
            var storyType = FindViewById<TextView>(Resource.Id.txtStory);
            var director = FindViewById<TextView>(Resource.Id.txtDirector);
            var actor = FindViewById<TextView>(Resource.Id.txtActor);

            name.Text = movie.Name;
            grade.Text = movie.Grade;
            storyType.Text = movie.Story;
            director.Text = movie.Director;
            actor.Text = movie.Actor;
        }
    }
}