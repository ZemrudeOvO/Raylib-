using Raylib_cs;
using System.Numerics;

namespace AAA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int ScreenSize = 1000;
            int frameCounter = 0;
            int lineNum = 75;
            int noiseSize = 500;
            int yOffset = 125;
            Raylib.InitWindow(ScreenSize, ScreenSize, "Perlin");
            Raylib.SetTargetFPS(50);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.BLANK);

                frameCounter++;
                Image noise = Raylib.GenImagePerlinNoise(noiseSize, noiseSize, 0, frameCounter, 1);
                for (int height = 0; height < lineNum; height++)
                {

                    Vector2[] vec = new Vector2[noiseSize];
                    for (int width = 0; width < noiseSize; width++)
                    {
                        vec[width] = new Vector2(width * Raylib.GetScreenWidth() / noiseSize, Raylib.GetImageColor(noise, width, height * noiseSize / lineNum).r + height * Raylib.GetScreenHeight() / lineNum - yOffset);
                    }
                    Raylib.DrawLineStrip(vec, noiseSize, Color.WHITE);
                }
                Raylib.DrawFPS(0, 0);
                Raylib.EndDrawing();
            }
            Raylib.CloseWindow();
        }
    }
}