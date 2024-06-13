using System;
using Raylib_cs;
using System.Numerics;
using team_mohawk_a4_platformer;

public class Program
{
    // window and game variables
    static string title = "Flappin Birb"; // window title
    static int screenWidth = 800; // screen width
    static int screenHeight = 600; // screen height
    static int targetFps = 60; // target frames-per-second

    // bird instance
    static Class1 bird;

    static void Main()
    {
        // create a window to draw to
        Raylib.InitWindow(screenWidth, screenHeight, title);
        // set the target frames-per-second (FPS)
        Raylib.SetTargetFPS(targetFps);
        // setup your game
        Setup();

        // game loop
        while (!Raylib.WindowShouldClose())
        {
            // enable drawing to the canvas (window)
            Raylib.BeginDrawing();
            // clear the canvas with one color
            Raylib.ClearBackground(Color.RayWhite);
            // update and draw your game
            Update();
            // stop drawing to the canvas, begin displaying the frame
            Raylib.EndDrawing();
        }

        // close the window
        Raylib.CloseWindow();
    }

    static void Setup()
    {
        // initialize the bird instance
        bird = new Class1(new Vector2(100, 300), new Vector2(0, 75));
    }

    static void Update()
    {
        // bird flap input
        if (Raylib.IsKeyPressed(KeyboardKey.Space))
        {
            // applies a certain amount of force if the designated key is pressed
            bird.ApplyFlap(new Vector2(0, -15));
        }

        // simulate gravity
        bird.SimulateGravity(Raylib.GetFrameTime());

        // check if the bird hits the ground or ceiling
        bird.CheckBounds(25, 575);

        // draw everything in the game
        Draw();
    }

    static void Draw()
    {
        // draw everything in the game
        Raylib.DrawText("Press SPACE to jump", 10, 10, 20, Color.DarkGray);
        Raylib.DrawText("(game instantly closes if you touch the ceiling/ground)", 10, 30, 20, Color.DarkGray);
        bird.Draw();
    }
}
