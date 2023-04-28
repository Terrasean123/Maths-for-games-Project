using System;
using System.Collections.Generic;
using System.Text;

namespace RaylibStarterCS
{
    internal class Bullets : SceneObject
    {
        public SpriteObject bulletSprite = new SpriteObject();
        public MathClasses.Vector3 bulletDirection;
        public AABB CollsionBox;
        public bool used = false;
        public bool alive = true;

        public Bullets()
        {
            bulletSprite.Load("../../../../Sprites/bulletDark1_outline.png");
            bulletSprite.SetRotate(-90 * (float)(Math.PI / 180.0f));
            bulletSprite.SetPosition(-bulletSprite.Height, bulletSprite.Width / 2);
            AddChild(bulletSprite);
            CollsionBox = new AABB(new MathClasses.Vector3(bulletSprite.LocalTransform.m00, bulletSprite.LocalTransform.m01, 1), bulletSprite.LocalTransform * new MathClasses.Vector3(bulletSprite.Width, bulletSprite.Height, 1));
        }

        public void Die()
        {
            alive = false;
            RemoveChild(bulletSprite);
        }

        public void Live()
        {
            alive = true;
            AddChild(bulletSprite);
        }



    }
}
