using System.Collections.Generic;
using Android.App;
using Android.Views;
using Android.Widget;
using AndroidDemo.Model;

namespace AndroidDemo.CustomAdapter
{
    public class MovieAdapter:BaseAdapter<Movie>
    {
        private readonly Activity _context;
        private readonly List<Movie> _movies;

        public MovieAdapter(Activity context, List<Movie> movies )
        {
            _context = context;
            _movies = movies;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            var item = _movies[position];
            if (view == null)
            {
                view = _context.LayoutInflater.Inflate(Resource.Layout.MovieList_Item,null);
            }

            var name = view.FindViewById<TextView>(Resource.Id.txtName);
            var grade = view.FindViewById<TextView>(Resource.Id.txtGrade);
            var storyType = view.FindViewById<TextView>(Resource.Id.txtStory);
            var director = view.FindViewById<TextView>(Resource.Id.txtDirector);
            var actor = view.FindViewById<TextView>(Resource.Id.txtActor);

            var image = view.FindViewById<ImageView>(Resource.Id.imageViewPicture);

            name.Text = item.Name;
            grade.Text = item.Grade;
            storyType.Text = item.Story;
            director.Text = item.Director;
            actor.Text = item.Actor;
            image.SetImageResource(Resource.Drawable.shawshank);
           // Koush.UrlImageViewHelper.SetUrlDrawable(image, item.Image, _context.GetDrawable(Resource.Drawable.shawshank));

            return view;
        }

        public override int Count { get { return _movies.Count; } }

        public override Movie this[int position]
        {
            get { return _movies[position]; }
        }
    }
}