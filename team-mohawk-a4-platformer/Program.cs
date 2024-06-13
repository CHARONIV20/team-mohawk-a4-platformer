using Raylib_cs;
using System.Numerics;
using System.Runtime.CompilerServices;

public class Program
{
 

    static Sound sfx;

    static void Main()
    {
        
        // Enable audio
        Raylib.InitAudioDevice();
        // Setup your game. This is a function YOU define.
        Setup();
        // Loop so long as window should not close
        while (!Raylib.WindowShouldClose())
        {


            // Stop audio
            Raylib.CloseAudioDevice();
            // Close the window
            Raylib.CloseWindow();
        }

        static void Setup()
        {


            LoadSFX();
        }

        static void Update()
        {
            // Your game code run each frame here


            PlaySFX();
        }

        static void LoadSFX()
        {
            string path = "../../../../assets/audio/Mission Impossible Theme (Full Theme).mp3";
            sfx = Raylib.LoadSound(path);
        }

        static void PlaySFX()
        {
            if (Raylib.IsKeyPressed(KeyboardKey.Space))
            {
                Raylib.PlaySound(sfx);
            }
        }
    }
}