using System;
using System.Diagnostics;
using System.Numerics;
using Raylib_cs;
using static Raylib_cs.Raylib;

namespace RaylibStarterCS
{
    class Game
    {
        Stopwatch stopwatch = new Stopwatch();

        private long currentTime = 0;
        private long lastTime = 0;
        private float timer = 0;
        private int fps = 1;
        private int frames;
        private float m_timer;
        private float deltaTime = 0.005f;

        SceneObject tankObject = new SceneObject();
        SceneObject turretObject = new SceneObject();

        SceneObject bulletObject = new SceneObject();
        SpriteObject bulletSprite = new SpriteObject();

        SpriteObject tankSprite = new SpriteObject();
        SpriteObject turretSprite = new SpriteObject();

         
        Camera2D camera;

        public Game()
        {



        }

        public void Init()
        {
            stopwatch.Start();
            lastTime = stopwatch.ElapsedMilliseconds;

            if (Stopwatch.IsHighResolution)
            {
                Console.WriteLine("Stopwatch high-resolution frequency: {0} ticks per second", Stopwatch.Frequency);
            }

            tankSprite.Load("L:/Maths for games project/Maths-for-games-Project/Task3/AIEYear1Samples-master/Sprites/tankBody_blue_outline.png");

            tankSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));

            tankSprite.SetPosition(-tankSprite.Width / 2.0f, tankSprite.Height / 2.0f);

            turretSprite.Load("L:/Maths for games project/Maths-for-games-Project/Task3/AIEYear1Samples-master/Sprites/Tank turret.png");
            turretSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            turretSprite.SetPosition(-60, turretSprite.Width / 2.0f);
            turretObject.Translate(-15, 0);

            // set up the scene object hierarchy - parent the turret to the base,
            // then the base to the tank sceneObject
            turretObject.AddChild(turretSprite);
            tankObject.AddChild(tankSprite);
            tankObject.AddChild(turretObject);

            // having an empty object for the tank parent means we can set the
            // position/rotation of the tank without
            // affecting the offset of the base sprite

            tankObject.SetPosition(GetScreenWidth() / 2.0f, GetScreenHeight() / 2.0f);
            SetTargetFPS(60);

            // Set our game to run at 60 frames-per-second
            //camera.target = new Vector2(0, 0);
            //camera.offset = Vector2.Zero;
            //camera.rotation = 0;
            //camera.zoom = 1.0f;
        }

        public void Shutdown()
        {


        }

        public void Update()
        {
            lastTime = currentTime;
            currentTime = stopwatch.ElapsedMilliseconds;
            deltaTime = (currentTime - lastTime) / 1000.0f;
            timer += deltaTime;
            if (timer >= 1)
            {
                fps = frames;
                frames = 0;
                timer -= 1;
            }
            frames++;
            //m_timer += deltaTime;

            // insert game logic here
            
            if (IsKeyDown(KeyboardKey.KEY_SPACE))
            {
                //SceneObject bulletObject = new SceneObject();
                //SpriteObject bulletSprite = new SpriteObject();
                bulletSprite.Load("L:/Maths for games project/Maths-for-games-Project/Task3/AIEYear1Samples-master/Sprites/bulletDark1_outline.png");
                bulletObject.AddChild(bulletSprite);
                //bulletObject.Draw();
                MathClasses.Vector3 facing = new MathClasses.Vector3(tankSprite.LocalTransform.m00,
                   tankObject.LocalTransform.m01, 1); 
                bulletObject.SetPosition(facing.x,facing.y);
            }

            if (IsKeyDown(KeyboardKey.KEY_LEFT))
            {

                turretObject.Rotate(-deltaTime);

            }

            if (IsKeyDown(KeyboardKey.KEY_RIGHT))
            {

                turretObject.Rotate(deltaTime);
            }

            if (IsKeyDown(KeyboardKey.KEY_A))
            {

                tankObject.Rotate(-deltaTime);

            }

            if (IsKeyDown(KeyboardKey.KEY_D))
            {

                tankObject.Rotate(deltaTime);
            }

            if (IsKeyDown(KeyboardKey.KEY_W))
            {
                MathClasses.Vector3 facing = new MathClasses.Vector3(tankObject.LocalTransform.m00,
                    tankObject.LocalTransform.m01, 1) * deltaTime * -100;
                tankObject.Translate(facing.x, facing.y);


            }

            if (IsKeyDown(KeyboardKey.KEY_S))
            {
                MathClasses.Vector3 facing = new MathClasses.Vector3(tankObject.LocalTransform.m00,
                    tankObject.LocalTransform.m01, 1) * deltaTime * 100;
                tankObject.Translate(facing.x, facing.y);


            }
            tankObject.Update(deltaTime);

        }

        public void Draw()
        {
            BeginDrawing();

            ClearBackground(Color.WHITE);
            DrawText(fps.ToString(), 10, 10, 14, Color.RED);
            bulletObject.Draw();
            tankObject.Draw();
            EndDrawing();
        }

    }
}
