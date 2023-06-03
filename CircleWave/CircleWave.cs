using Raylib_cs;
using System.Numerics;

namespace AAA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ScreenSize = 1000;
            int section = 16;
            Raylib.InitWindow(ScreenSize, ScreenSize, "Perlin");
            Raylib.SetTargetFPS(50);


            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLANK);


                for (int i = 0; i < section; i++)
                {
                    int width = ScreenSize / 2 / (section + 1) + (i * ScreenSize / 2 / (section + 1));
                    float deltaTime = 0.25f;
                    float deltaWidth = ScreenSize / 2 / (section + 2) / 2 * MathF.Sin((float)Raylib.GetTime() + i * deltaTime);
                    Raylib.DrawRing(new Vector2(ScreenSize / 2, ScreenSize / 2), width - deltaWidth, width + deltaWidth, 0, 360, 360, Color.WHITE);
                }
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}
