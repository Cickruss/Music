namespace Music
{
    class Episode
    {
        public List<string> guessList = new List<string>();
        public float Duration { get; set; }
        public string? Title { get; set; }
        public int Order { get;}
        public Podcast Program{ get;}

        public Episode(int order,string? title, float duration, Podcast program)
        {
            Title = title;
            Duration = duration;
            Program = program;
            Order = order;
        }

        public void AddGuest(string guess)
        {
            guessList.Add(guess);
        }
        public void ShowDetails()
        {
            Console.WriteLine($"Program: {this.Program.Name}\nTitle: {this.Title}\n" +
                $"Duration: {this.Duration}\nOrder: {Order}\n" +
                $"Guests: {string.Join(",", guessList)}");
        }
    }

}