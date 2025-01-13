// See https://aka.ms/new-console-template for more information
using Raylib_cs;
using Characters;
using System.Numerics;

namespace HelloWorld;


class Program
{
    public static void Main()
    {
        int screenHeigth, screenWidth;
        Console.WriteLine("Hello World!");
        Raylib.InitWindow(800, 800, "Hello World!");

        // Create a player
        Player player = new Player(new Vector2(400, 300), Raylib.LoadTexture("npcs/some_npc.png"));
        player.setSpeed(10);

        while (!Raylib.WindowShouldClose())
        {
            screenHeigth = Raylib.GetScreenHeight();
            screenWidth = Raylib.GetScreenWidth();

            Raylib.BeginDrawing();
            Raylib.ClearBackground(Color.White);

            makeGrid(screenHeigth, screenWidth);    
            makeGrass(screenHeigth, screenWidth);
            Raylib.DrawTexture(player.getTexture(),(int) player.getPosition().X , (int) player.getPosition().Y, Color.White);
            Raylib.DrawText("Test_map", 12, 12, 20, Color.Black);

            // User Input
            if (Raylib.IsKeyPressed(KeyboardKey.Right)) {
                player.setPosition(new Vector2(player.getPosition().X + player.getSpeed(), player.getPosition().Y));
            }
            if (Raylib.IsKeyPressed(KeyboardKey.Left)) {
                player.setPosition(new Vector2(player.getPosition().X - player.getSpeed(), player.getPosition().Y));
            }
            if (Raylib.IsKeyPressed(KeyboardKey.Up)) {
                player.setPosition(new Vector2(player.getPosition().X, player.getPosition().Y - player.getSpeed()));
            }
            if (Raylib.IsKeyPressed(KeyboardKey.Down)) {
                player.setPosition(new Vector2(player.getPosition().X, player.getPosition().Y + player.getSpeed()));
            }

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

    // fullfill the screen with grass tiles
    public static void makeGrass(int screenHeigth, int screenWidth) {
        Texture2D grass = Raylib.LoadTexture("floor_tiles/grass_01.png");
        for (int i = 0; i < screenHeigth; i+=16) {
            for (int j = 0; j < screenWidth; j+=16) {
                Raylib.DrawTexture(grass, i, j, Color.White);
            }
        }
    }
}