﻿using System;
using MathClasses;
using Raylib_cs;

namespace RaylibStarterCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();

            Raylib.InitWindow(640, 480, "Hello World");

            game.Init();

            while (!Raylib.WindowShouldClose())
            {
                game.DestroyBullet();
                game.Update();
                game.Draw();
                game.Debug();
            }

            game.Shutdown();

            Raylib.CloseWindow();
        }
    }
}
