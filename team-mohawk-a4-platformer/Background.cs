using Raylib_cs;

namespace team_mohawk_a4_platformer
{
    
    public class Background
    {
        public static Texture2D texture;
        public static void load()
        {

            //load texture
            Image image = Raylib.LoadImage("../../../Assets-Graphics/bg_5.png");
            texture = Raylib.LoadTextureFromImage(image);

            Raylib.UnloadImage(image);
        }
        public static void Draw()
        {
            Raylib.DrawTexture(texture,0,0,Color.White);

        }

    }
}
