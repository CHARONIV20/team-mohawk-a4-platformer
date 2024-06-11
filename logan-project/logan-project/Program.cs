using Raylib_cs;
using System.Numerics;

public class Program
{
    // If you need variables in the Program class (outside functions), you must mark them as static
    static string title = "Game Title"; // Window title
    static int screenWidth = 800; // Screen width
    static int screenHeight = 600; // Screen height
    static int targetFps = 60; // Target frames-per-second

    static Pipes? pipes;

    static void Main()
    {
        // Create a window to draw to. The arguments define width and height
        Raylib.InitWindow(screenWidth, screenHeight, title);
        // Set the target frames-per-second (FPS)
        Raylib.SetTargetFPS(targetFps);
        // Setup your game. This is a function YOU define.
        Setup();
        // Loop so long as window should not close
        while (!Raylib.WindowShouldClose())
        {
            // Enable drawing to the canvas (window)
            Raylib.BeginDrawing();
            // Clear the canvas with one color
            Raylib.ClearBackground(Raylib_cs.Color.RayWhite);
            // Your game code here. This is a function YOU define.
            Update();
            // Stop drawing to the canvas, begin displaying the frame
            Raylib.EndDrawing();
        }
        // Close the window
        Raylib.CloseWindow();
    }

    static void Setup()
    {
        // Your one-time setup code here
        pipes = new Pipes();
    }

    static void Update()
    {
        // Your game code run each frame here
        pipes?.Draw();
    }
}

public class Pipes
{
    private Rectangle topPipe;
    private Rectangle bottomPipe;
    private Color pipeColor;

    public Pipes()
    {
        // Initialize the rectangles for the pipes
        topPipe = new Rectangle(0, 0, 100, 150); // Top pipe
        bottomPipe = new Rectangle(0, 450, 100, 150); // Bottom pipe
        pipeColor = Color.Green; // Pipe color
    }

    public void Draw()
    {
        // Draw the top and bottom pipes
        Raylib.DrawRectangleRec(topPipe, pipeColor);
        Raylib.DrawRectangleRec(bottomPipe, pipeColor);
    }
}
