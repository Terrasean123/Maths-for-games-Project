using System;
using System.Collections.Generic;
using System.Text;

namespace RaylibStarterCS
{
    internal class Bullets : SceneObject
    {
        SpriteObject bulletSprite = new SpriteObject();
        public MathClasses.Vector3 bulletDirection;
        public bool used = false;
        public bool alive = true;

        public Bullets() 
        {
            bulletSprite.Load("L:/Maths for games project/Maths-for-games-Project/Task3/AIEYear1Samples-master/Sprites/bulletDark1_outline.png");
            bulletSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            bulletSprite.SetPosition(-bulletSprite.Height, bulletSprite.Width / 2);
            AddChild(bulletSprite);
        }

    }
}
