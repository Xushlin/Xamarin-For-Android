namespace AndroidDemo.Model
{
    public class Movie
    {
        public string DetailUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public string Grade { get; set; }
        public string Director { get; set; }
        public string Story { get; set; }
        public string Actor { get; set; }
      
    }

    public static class MovieModelAdapter
    {
        public static Movie ToMovie(this AndroidDemo.Service.Model.Movie me)
        {
            return new Movie
            {
                DetailUrl = me.DetailUrl,
                Director = me.Director,
                Image = me.Image,
                Actor = me.Actor,
                Description = me.Description,
                Grade = me.Grade,
                Name = me.Name,
                Story = me.Story
            };
        }
    }
}
