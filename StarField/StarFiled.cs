using Raylib_cs;
using System.Numerics;
using Particle;

namespace StarFiled
{
    class StarField
    {
        public static int screenWidth = 800;
        public static int screenHeight = 800;
        public static int particleNum = 800;

        public static void Main()
        {
            int frameCounter = 0;

            Raylib.InitWindow(screenWidth, screenHeight, "StarFidel");
            Raylib.SetTargetFPS(100);

            Star[] stars = new Star[particleNum];
            for (int i = 0;i<stars.Length;i++)
            {
                stars[i] = new Star();
            }

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();


                if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
                    Star.displayLine = !Star.displayLine;
                if (Raylib.IsKeyDown(KeyboardKey.KEY_F))
                    Raylib.DrawFPS(-Raylib.GetScreenWidth() / 2, -Raylib.GetScreenHeight() / 2);

                Raylib.ClearBackground(Color.BLANK);
                Rlgl.rlTranslatef(Raylib.GetScreenWidth() / 2, Raylib.GetScreenHeight() / 2, 0);
                for (int i = 0;i <stars.Length;i++)
                {
                    stars[i].update();
                    stars[i].show();
                }

                Raylib.EndDrawing();

                if (Raylib.IsKeyDown(KeyboardKey.KEY_C))
                {
                    Raylib.TakeScreenshot("screenshot/" + frameCounter++ + ".png");
		        }
            }
        }
    }

}