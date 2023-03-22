using System;

namespace Console_Part5
{
    public class Song
    {
        public string Artist { get; set; }
        public string Title { get; set; }
        public int Duration { get; set; }

        public Song(string artist, string title, int duration)
        {
            Artist = artist;
            Title = title;
            Duration = duration;
        }

        public override bool Equals(object obj)
        {
            if (!(obj is Song))
                return false;

            var otherSong = (Song)obj;
            return Artist == otherSong.Artist &&
                   Title == otherSong.Title &&
                   Duration == otherSong.Duration;
        }
    }
}
