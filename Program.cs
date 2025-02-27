using System;

class Program
{
    static void Main()
    {
        // Using IPlayable reference
        IPlayable music = new MusicPlayer();
        music.Play(); // Calls Play() from MusicPlayer

        IPlayable video = new VideoPlayer();
        video.Play(); // Calls Play() from VideoPlayer
    }
}
