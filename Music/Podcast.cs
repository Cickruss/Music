using System;


namespace Music
{
    internal class Podcast
    {
        public List<Episode> episodeList = new List<Episode>();
        public string? Name { get;}
        public string? Host { get;}
        public int TotalEp => episodeList.Count();
        public Podcast(string? name, string? host)
        {
            Name = name;
            Host = host;
        }
        public void AddEpisode(Episode episode)
        {
            episodeList.Add(episode);
        }
        public void ShowDetailsPodcast()
        {
            Console.WriteLine($"Name: {this.Name}\nHost: {this.Host}\nN° Episode: {this.TotalEp}");
        }
        public void ShowDetailsAllEpisodes()
        {
            episodeList.ForEach(delegate (Episode episode)
            {
                episode.ShowDetails();
                Console.WriteLine("=====");
            });
        }

    }
}
