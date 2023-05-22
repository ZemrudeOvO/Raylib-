using Raylib_cs;
using System.Numerics;

namespace SaveScreenShot
{ 
    class Program
    { 
        public static void Main()
        {
            Raylib.SetTargetFPS(25);
            Raylib.InitWindow(640, 360, "save frames");

            Vector2 pos = new Vector2(Raylib.GetScreenWidth() / 2, Raylib.GetScreenHeight() / 2);
            Random random = new Random();
            int frameCounter = 0;

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLACK);
                Raylib.DrawRectangle((int)(pos.X += random.NextSingle() * 6 - 3), (int)(pos.Y += random.NextSingle() * 6 - 3), 50, 50, Color.WHITE);
                Raylib.EndDrawing();
                Raylib.TakeScreenshot("screenshot/"+frameCounter+++".png");
            }
        }
    }
}