namespace Music
{
    class Music
    {
        public Band Artist { get;}
        public string Title { get; set; }
        public float DurationInMinutes { get; set; }
        public bool Avalaible { get; set; }
        public string ShortDescription => 
            $"This music {Title} is from {Artist} and lasts {DurationInMinutes.ToString().Replace(',', ':')} minutes.";

        public Music(Band artist, string title, float duration, bool avalaible)
        {
            this.Artist = artist;
            this.Title = title;
            this.DurationInMinutes = duration;
            this.Avalaible = avalaible;
        }

        public void getDataSheet()
        {
            if (Avalaible) 
            {   
                Console.WriteLine($"Title: {this.Title}");
                Console.WriteLine($"Artist: {this.Artist}");
                Console.WriteLine($"Duration: {this.DurationInMinutes.ToString().Replace(',', ':')}");
                Console.WriteLine($"Is Avalaible: Yes");
            }
        }
    }
}