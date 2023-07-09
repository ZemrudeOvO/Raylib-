using Raylib_cs;
using System;
using System.Timers;

class TimeClock
{
    private static System.Timers.Timer? aTimer;
    static DateTime date;

    public static void Main()
    {
        Raylib.InitWindow(640, 360, "Timer");

        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.BLACK);

            if (Raylib.IsKeyPressed(KeyboardKey.KEY_SPACE))
            { 
                SetTimer();
                Console.WriteLine(date.Second);
	        }
            if (Raylib.IsKeyPressed(KeyboardKey.KEY_ESCAPE))
            {
                aTimer?.Stop();
                aTimer?.Dispose();
	        }

            Raylib.DrawText((date.Second + date.Minute * 60).ToString(), 0, 0, 30, Color.WHITE);
            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }

    static void SetTimer()
    {
        aTimer = new System.Timers.Timer(2000);
        aTimer.Elapsed += OnTimedEvent;
        aTimer.AutoReset = true;
        aTimer.Enabled = true;
    }

    private static void OnTimedEvent(object? sender, ElapsedEventArgs e)
    {
        date = e.SignalTime;
    }
}