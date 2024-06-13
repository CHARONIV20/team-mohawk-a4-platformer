using Raylib_cs;
using System;

public class pipeAssets
{
    public static Texture2D texture;
    public static void load()
    {
        //load texture
        Image image = Raylib.LoadImage("../../../Assets-Graphics/pipe.png");
        texture = Raylib.LoadTextureFromImage(image);

        Raylib.UnloadImage(image);

    }
    public static void Draw()
    {
        Raylib.DrawTexture(texture, 0, 0, Color.White);

    }

}
