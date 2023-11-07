using System;


namespace Music
{
    internal class Band
    {
        public string name { get; set; }
        private List<Album> bandList = new List<Album>();
        public Band(string name)
        {
            this.name = name;
        }
        public void AddAlbum(Album album)

        {
            bandList.Add(album);
        }
        public void ShowDiscografy()
        {
            Console.WriteLine($"Discografy: {this.name}");

            foreach (Album album in bandList){
                Console.WriteLine($"Album: {album.Name} ({album.TotalDuration.ToString("N2").Replace(",",":")})");
            }
        }

    }
}
