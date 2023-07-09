//node class
//connect class & method
using Raylib_cs;
using System.Numerics;

public class Lines
{ 
    public static void Main()
    {
        Raylib.InitWindow(640, 360, "Lines");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLANK);
            Raylib.DrawLineEx(Raylib.GetMousePosition(), new Vector2((550 - Raylib.GetMouseX()) / 2 + Raylib.GetMouseX(), Raylib.GetMouseY()), 5, Color.WHITE);
            Raylib.DrawRectangleGradientH(Raylib.GetMouseX() - 50, Raylib.GetMouseY() - 50, 100, 100, Color.GOLD, Color.SKYBLUE);
            Raylib.DrawRectangleGradientH(500, 250, 100, 100, Color.GOLD, Color.SKYBLUE);
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }
}