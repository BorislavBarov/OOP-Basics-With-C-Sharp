using System;
using System.Globalization;

public class Song
{
    private const int MinLenOfArtistName = 3;
    private const int MaxLenOfArtistName = 20;
    private const int MinLenOfSongName = 3;
    private const int MaxLenOfSongName = 30;
    private const int MaxMinutes = 14;
    private const int MaxSeconds = 59;

    private string artistName;
    private string songName;
    private int minutes;
    private int seconds;

    public Song(string artistName, string songName, int minutes, int seconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.Minutes = minutes;
        this.Seconds = seconds;
    }

    public string ArtistName
    {
        get { return this.artistName; }
        private set
        {
            if (value.Length < MinLenOfArtistName || value.Length > MaxLenOfArtistName)
            {
                throw new InvalidArtistNameException();
            }

            this.artistName = value;
        }
    }

    public string SongName
    {
        get { return this.songName; }
        private set
        {
            if (value.Length < MinLenOfSongName || value.Length > MaxLenOfSongName)
            {
                throw new InvalidSongNameException();
            }

            this.songName = value;
        }
    }

    public int Minutes
    {
        get { return this.minutes; }
        private set
        {
            if (value < 0 || value > MaxMinutes)
            {
                throw new InvalidSongMinutesException();
            }

            this.minutes = value;
        }
    }

    public int Seconds
    {
        get { return this.seconds; }
        private set
        {
            if (value < 0 || value > MaxSeconds)
            {
                throw new InvalidSongSecondsException();
            }

            this.seconds = value;
        }
    }
}