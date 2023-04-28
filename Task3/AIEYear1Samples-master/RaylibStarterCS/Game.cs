using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
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
        int previousCount = 0;
        int bulletIterartor = 0;
        List<SceneObject> bulletList = new List<SceneObject>();

        SceneObject tankObject = new SceneObject();
        SceneObject turretObject = new SceneObject();


        Bullets[] bulletMagizine = new Bullets[10];
        SpriteObject tankSprite = new SpriteObject();
        SpriteObject turretSprite = new SpriteObject();
        MathClasses.Vector3 turretFacing;
        MathClasses.Vector3 turretFacingOnLastMovement;

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

            //tankSprite.Load("L:/Maths for games project/Maths-for-games-Project/Task3/AIEYear1Samples-master/Sprites/tankBody_blue_outline.png");
            tankSprite.Load("../../../../Sprites/tankBody_blue_outline.png");

            tankSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));

            tankSprite.SetPosition(-tankSprite.Width / 2.0f, tankSprite.Height / 2.0f);




            for (int i = 0; i < bulletMagizine.Length; i++)
            {
                bulletMagizine[i] = new Bullets();
            }


            turretSprite.Load("../../../../Sprites/Tank turret.png");
            turretSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            turretSprite.SetPosition(-60, turretSprite.Width / 2.0f);
            turretObject.Translate(-15, 0);
            turretFacing = new MathClasses.Vector3(0, 0, 0);

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

        public void Debug()
        {

            if (previousCount != bulletList.Count)
            {
                previousCount = bulletList.Count;
                Console.WriteLine("Current number of Bullets:" + bulletList.Count);
            }

        }

        public void DrawBulletHitBox()
        {
            //Console.WriteLine("Drawing hitboxes...");
            foreach (Bullets bullet in bulletMagizine)
            {
                Vector2 Center = new Vector2(bullet.CollsionBox.Center().x, bullet.CollsionBox.Center().y);
                Vector2 Extents = new Vector2(bullet.CollsionBox.Extents().x, bullet.CollsionBox.Extents().y);

                DrawLineEx(Center, Extents, 1000, Color.RED);
                Console.WriteLine("Center:" + Center);
                Console.WriteLine("Extents: " + Extents);
            }
        }

        public bool BulletsUsable()
        {
            int usedBullets = 0;
            for (int i = 0; i < bulletMagizine.Length; i++)
            {
                if (bulletMagizine[i].used == true)
                {
                    usedBullets++;
                }
            }
            if (usedBullets >= bulletMagizine.Length)
            {

                Console.WriteLine("OUT OF Bullets reloading:" + usedBullets);
                ResetAndReload();
                return false;
            }
            else
            {
                return true;

            }
        }
        public void DestroyBullet()
        {
            for (int i = 0; i < bulletMagizine.Count(); i++)
            {
                MathClasses.Vector3 bulletLocation = bulletMagizine[i].GlobalTransform *
                    new MathClasses.Vector3(bulletMagizine[i].bulletSprite.Width, bulletMagizine[i].bulletSprite.Height, 1);
                Console.WriteLine("x:" + bulletLocation.x);
                Console.WriteLine("y:" + bulletLocation.y);

                if (bulletMagizine[i].used == true)
                {
                    if (bulletLocation.x <= 30 || bulletLocation.x >= 600)
                    {
                        bulletMagizine[i].Die();
                    }
                    if (bulletLocation.y <= 30 || bulletLocation.y >= 440)
                    {
                        bulletMagizine[i].Die();
                    }
                }
            }
        }

        public void ResetAndReload()
        {
            for (int i = 0; i < bulletMagizine.Length; i++)
            {
                bulletMagizine[i].used = false;

            }


        }

        public void Shutdown()
        {


        }

        public void Update()
        {
            float turretRotation = (float)Math.Atan2(turretObject.GlobalTransform.m01, turretObject.GlobalTransform.m00);
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

            if (IsKeyReleased(KeyboardKey.KEY_SPACE))
            {
                if (BulletsUsable() == true)
                {
                    MathClasses.Vector3 Location =
                      turretSprite.GlobalTransform *
                      new MathClasses.Vector3(turretSprite.Width / 2, 10, 1);

                    turretFacing = new MathClasses.Vector3(turretObject.GlobalTransform.m00,
                    turretObject.GlobalTransform.m01, 1) * deltaTime * -50;

                    bulletMagizine[bulletIterartor].bulletDirection = turretFacing;
                    bulletMagizine[bulletIterartor].SetRotate(turretRotation);
                    bulletMagizine[bulletIterartor].SetPosition(Location.x, Location.y);
                    bulletMagizine[bulletIterartor].used = true;

                    bulletIterartor++;
                }
                else
                {

                    bulletIterartor = 0;
                    Console.WriteLine("Resetting iterator:" + bulletIterartor);
                }

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

            foreach (Bullets bullet in bulletMagizine)
            {
                bullet.Translate(bullet.bulletDirection.x, bullet.bulletDirection.y);
            }

            tankObject.Update(deltaTime);

            foreach (SceneObject bullet in bulletMagizine)
            {
                bullet.Update(deltaTime);
            }
        }

        public void Draw()
        {
            BeginDrawing();

            ClearBackground(Color.WHITE);
            DrawText(fps.ToString(), 10, 10, 14, Color.RED);
            //foreach (Bullets bullet in bulletMagizine)
            //{
            //    Vector2 Center = new Vector2(bullet.CollsionBox.Center().x, bullet.CollsionBox.Center().y);
            //    Vector2 Extents = new Vector2(bullet.CollsionBox.Extents().x, bullet.CollsionBox.Extents().y);

            //    DrawLineEx(Center, Extents, 20, Color.RED);

            //}
            // DrawBulletHitBox();
            foreach (SceneObject bullet in bulletMagizine)
            {
                bullet.Draw();
            }
            tankObject.Draw();
            EndDrawing();
        }

    }
}
