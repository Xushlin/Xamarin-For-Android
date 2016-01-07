using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using AndroidDemo.API.Service.Model;
using HtmlAgilityPack;

namespace AndroidDemo.API.Service
{
    public class MovieService : IMovieService
    {
        public List<Movie> GetMovies()
        {
            var url = "http://dianying.fm/search/?region=%E7%BE%8E%E5%9B%BD";
            var nodes = DownloadHtmlDocumentByUrl(url);
            var movies = ParseMovieListHtml(nodes, "//ul[@class='fm-result-list']/li");

            return movies;
        }

        private List<Movie> ParseMovieListHtml(HtmlNode htmlNode, string xPath)
        {
            try
            {
                var movies = new List<Movie>();
                var hnc = htmlNode.SelectNodes(xPath);
                var hnc2 = htmlNode.SelectNodes("//div/a/img");
                if (hnc.Count < 1)
                    return null;

                for (int i = 0; i < hnc.Count; i++)
                {
                    var node1 = hnc2[i];
                    var node = hnc[i];
                    var movie = new Movie();
                    var hac = node1.Attributes;

                    movie.Grade =node.SelectSingleNode("div[@class='fm-movie-desc']/div/span[@class='fm-rating']").InnerText.Replace("\n", "").RemoveSpace().Trim();
                    movie.Image = hac[0].Value.Replace("-poster100","").Trim();
                    movie.Name = node.SelectNodes("div[@class='fm-movie-desc']/div")[0].InnerText.Replace("\n","").RemoveSpace().Trim();
                    movie.Director =node.SelectNodes("div[@class='fm-movie-desc']/div")[2].InnerText.Replace("\n", "").RemoveSpace().Trim();
                    movie.Story = node.SelectNodes("div[@class='fm-movie-desc']/div")[3].InnerText.Replace("\n", "").RemoveSpace().Trim(); 
                    movie.Actor =node.SelectNodes("div[@class='fm-movie-desc']/div")[4].InnerText.Replace("\n","").RemoveSpace().Trim();
                    movie.DetailUrl = node.SelectSingleNode("div[@class='fm-movie-cover']/a").Attributes["href"].Value.Trim();
                    movies.Add(movie);
                }
                return movies;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
      
        private  HtmlNode DownloadHtmlDocumentByUrl(string url)
        {
            try
            {
                var uri = new Uri(url);
                var request = (HttpWebRequest)WebRequest.Create(uri);
                var response = request.GetResponse();

                var stream = response.GetResponseStream();
                var read = new StreamReader(stream, Encoding.GetEncoding("utf-8"));
                var str = read.ReadToEnd();

                var html = new HtmlDocument();
                html.LoadHtml(str);

                return html.DocumentNode;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }

    public static class Extensions
    {
        public static string RemoveSpace(this string oldString)
        {
            var options = RegexOptions.None;
            var regex = new Regex(@"[ ]{2,}", options);
            return regex.Replace(oldString, @" ");
        }
    }
}