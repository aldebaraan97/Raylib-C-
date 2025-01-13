// See https://aka.ms/new-console-template for more information

using Raylib_cs;

namespace HelloWorld;

class Program
{
    public static void Main()
    {
        int screenHeigth;
        int screenWidth;
        Console.WriteLine("Hello World!");
        Raylib.InitWindow(800, 800, "Hello World!");
        Texture2D grass = Raylib.LoadTexture("floor_tiles/grass_01.png");

        while (!Raylib.WindowShouldClose())
        {
            screenHeigth = Raylib.GetScreenHeight();
            screenWidth = Raylib.GetScreenWidth();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            makeGrid(screenHeigth, screenWidth);
            for (int i = 0; i < screenWidth; i += 16) {
                for (int j = 0; j < screenHeigth; j += 16) {
                    Raylib.DrawTexture(grass, i, j, Color.White);
                    }
            }
             Raylib.DrawText("Test_map", 12, 12, 20, Color.Black);


            Raylib.EndDrawing();
        }
        Raylib.CloseWindow();
    }

    // Draw a grid of lines
    public static void makeGrid(int screenHeigth, int screenWidth) {
        for (int i = 0; i < screenHeigth; i+=16) {
            Raylib.DrawLine(0, i, screenWidth, i, Color.Black);
        }
        for (int i = 0; i < screenWidth; i+=16) {
            Raylib.DrawLine(i, 0, i, screenHeigth, Color.Black);
        }
    }
}