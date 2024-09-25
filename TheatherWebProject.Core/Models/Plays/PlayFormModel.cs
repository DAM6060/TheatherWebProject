namespace TheatherWebProject.Core.Models.Plays
{
    public class PlayFormModel
    {
        public string Title { get; set; } = string.Empty;

        public string Genre { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public List<string> ImagesURLs { get; set; } = new List<string>();

        public List<string> VideosURLs { get; set; } = new List<string>();

        public string Location { get; set; } = string.Empty;

        public string Town { get; set; } = string.Empty;

        public DateTime DateAndTime { get; set; }

        public string TicketURL { get; set; } = string.Empty;

        public List<int> ActorsIds { get; set; } = new List<int>();


    }
}
