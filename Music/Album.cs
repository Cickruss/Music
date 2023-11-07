using System;

namespace Music
{
    class Album
    {
        public string Name { get; set; }
        private List<Music> musicList = new List<Music>();

        public Album(string name)
        {
            Name = name;
        }

        public float TotalDuration => musicList.Sum(music => music.DurationInMinutes);

        public void AddMusic(Music music)
        {
            this.musicList.Add(music);
        }
        public void ShowMusics() 
        {
            Console.WriteLine($"Album: {Name} \n");
            foreach (Music music in this.musicList)
            {
                Console.WriteLine($"Music: {music.Title}");
            }
            Console.WriteLine($"Total duration of Album {Name} is {TotalDuration.ToString("F").Replace(',', ':')} minutes.");
        }
    }
}
