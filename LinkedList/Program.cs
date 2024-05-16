// Create a linked list to represent the playlist
LinkedList<Song> playlist = new LinkedList<Song>();

// Add songs to the playlist
playlist.AddLast(new Song("Song 1", "Artist 1", TimeSpan.FromMinutes(3)));
playlist.AddLast(new Song("Song 2", "Artist 2", TimeSpan.FromMinutes(4)));
playlist.AddLast(new Song("Song 3", "Artist 3", TimeSpan.FromMinutes(5)));

// Remove a song from the playlist
playlist.RemoveFirst();

// Add a song to the beginning of the playlist
playlist.AddFirst(new Song("New Song", "New Artist", TimeSpan.FromMinutes(6)));

// Print the playlist
Console.WriteLine("Playlist:");
foreach (var song in playlist)
{
    Console.WriteLine(song.Title + " by " + song.Artist + " (" + song.Duration + ")");
}
