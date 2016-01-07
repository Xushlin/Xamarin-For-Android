using AndroidDemo.API.Service.Model;

namespace AndroidDemo.API.Models
{
    public class MovieModel
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

    public static class MoiveAdapter
    {
        public static MovieModel ToModel(this Movie me)
        {
           return new MovieModel
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