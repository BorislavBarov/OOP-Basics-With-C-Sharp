using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    public static void Main()
    {
        var numberOfSongs = int.Parse(Console.ReadLine());
        var playlist = new List<Song>();

        for (int i = 0; i < numberOfSongs; i++)
        {
            var songInfo = Console.ReadLine().Split(';');
            var artistName = songInfo[0];
            var songName = songInfo[1];

            try
            {
                var time = songInfo[2].Split(':').Select(int.Parse).ToArray();
                var minutes = time[0];
                var second = time[1];

                var song = new Song(artistName, songName, minutes, second);
                playlist.Add(song);
                Console.WriteLine($"Song added.");
            }
            catch (InvalidSongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Invalid song length.");
            }
        }

        var totalMinutes = playlist.Sum(m => m.Minutes);
        var totalSecond = playlist.Sum(s => s.Seconds);

        totalSecond += totalMinutes * 60;
        var finalMinutes = totalSecond / 60;
        var finalSecond = totalSecond % 60;
        var finalHours = finalMinutes / 60;
        finalMinutes %= 60;

        Console.WriteLine($"Songs added: {playlist.Count}");
        Console.WriteLine($"Playlist length: {finalHours}h {finalMinutes}m {finalSecond}s");
    }
}