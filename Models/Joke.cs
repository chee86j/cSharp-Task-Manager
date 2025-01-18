namespace Task_Manager.Models
{
    public class Joke
    {
        public int Id { get; set; }
        public string JokeText { get; set; }
        public string JokeAnswer { get; set; }
        public string CreatedBy { get; set; }
        public string Category { get; set; }
        public List<string> Tags { get; set; }

        public Joke()
        {
            Id = 0;
            JokeText = "";
            JokeAnswer = "";
            CreatedBy = "";
            Category = "";
            Tags = new List<string>();
        }
    }
}
