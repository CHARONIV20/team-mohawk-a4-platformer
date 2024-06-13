using Raylib_cs;
using System.Numerics;
using System.Runtime.CompilerServices;

public class Program
{
    // If you need variables in the Program class (outside functions), you must mark them as static
    static string title = "Flappin Birb"; // Window title
    static int screenWidth = 800; // Screen width
    static int screenHeight = 600; // Screen height
    static int targetFps = 60; // Target frames-per-second
    static bool isMouseButtonPressed = Raylib.IsMouseButtonPressed(MouseButton.Left);
    static bool isKeyPressed = Raylib.IsKeyPressed(KeyboardKey.Space);



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
        }
    }

    private static void LoadSFX()
    {
        sfx = new Sound();
    }
}