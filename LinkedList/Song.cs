// Create a linked list to represent the playlist

// Add songs to the playlist

// Remove a song from the playlist

// Add a song to the beginning of the playlist

// Print the playlist
class Song
{
    public string Title { get; }
    public string Artist { get; }
    public TimeSpan Duration { get; }

    public Song(string title, string artist, TimeSpan duration)
    {
        Title = title;
        Artist = artist;
        Duration = duration;
    }
}