using Raylib_cs;
using System.Numerics;

namespace Particle
{
    public class Star
    {
        public float speed = 5;
        public int particleMaxSize = 8;
        public static bool displayLine = false;

        float x, y, z;
        float pz;
        Random random = new Random();

        public Star()
        {
            x = 2 * random.Next(Raylib.GetScreenWidth()) - Raylib.GetScreenWidth();
            y = 2 * random.Next(Raylib.GetScreenHeight()) - Raylib.GetScreenHeight();
            z = random.Next(Raylib.GetScreenWidth());

            pz = z;
        }

        public void update()
        {
            z -= speed;
            if (z < 1)
            {
                z = Raylib.GetScreenWidth();
                x = 2 * random.Next(Raylib.GetScreenWidth()) - Raylib.GetScreenWidth();
                y = 2 * random.Next(Raylib.GetScreenHeight()) - Raylib.GetScreenHeight();

                pz = z;
            }
        }

        public void show()
        {
            float sx = Raylib.GetScreenWidth() * (x / z);
            float sy = Raylib.GetScreenWidth() * (y / z);

            float rad = particleMaxSize - (z / Raylib.GetScreenWidth() * particleMaxSize);
            Raylib.DrawEllipse((int)sx, (int)sy, rad, rad, Color.WHITE);

            float px = x / pz * Raylib.GetScreenWidth();
            float py = y / pz * Raylib.GetScreenHeight();

            if (!displayLine)
                pz = z;

            Raylib.DrawLine((int)px, (int)py, (int)sx, (int)sy, Color.WHITE);
        }
    }
}

