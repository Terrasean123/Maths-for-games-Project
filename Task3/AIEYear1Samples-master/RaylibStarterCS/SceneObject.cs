using MathClasses;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace RaylibStarterCS
{
    internal class SceneObject
    {
        protected SceneObject parent = null;
        protected List<SceneObject> children = new List<SceneObject>();

        protected Matrix3 localTransform = new Matrix3(1);
        protected Matrix3 globalTransform = new Matrix3(1);


        public Matrix3 LocalTransform
        {
            get { return localTransform; }

        }

        public Matrix3 GlobalTransform
        {
            get { return globalTransform; }

        }




        ~SceneObject()
        {
            if (parent != null)
            {
                parent.RemoveChild(this);
            }
            foreach (SceneObject so in children)
            {
                so.parent = null;
            }

        }

        public virtual void OnUpdate(float deltaTime)
        {


        }


        public virtual void OnDraw()
        {



        }


        public void Update(float deltaTime)
        {
            OnUpdate(deltaTime);

            foreach (SceneObject child in children)
            {

                child.Update(deltaTime);

            }

        }

        public void Draw()
        {
            OnDraw();

            foreach (SceneObject child in children)
            {

                child.Draw();
            }
        }




        public SceneObject Parent
        {
            get { return parent; }

        }

        public int GetChildCount()
        {
            return children.Count;
        }


        public SceneObject GetChild(int index)
        {
            return children[index];
        }

        public void AddChild(SceneObject Child)
        {
            // make sure it doesn't have a parent already
            Debug.Assert(Child != null);
            // assign "this as parent
            Child.parent = this;
            // add new child to collection
            children.Add(Child);
        }

        public void RemoveChild(SceneObject Child)
        {
            if (children.Remove(Child) == true)
            {
                Child.parent = null;
            }
        }

        public void UpdateTransform()
        {
            if (parent != null)
                globalTransform = parent.globalTransform * localTransform;
            else
                globalTransform = localTransform;

            foreach (SceneObject child in children)
                child.UpdateTransform();
        }

        public void SetPosition(float x, float y)
        {
            localTransform.SetTranslation(x, y);
            UpdateTransform();
        }

        public void SetRotate(float radians)
        {
            localTransform.SetRotateZ(radians);
            UpdateTransform();
        }

        public void SetScale(float width, float height)
        {
            localTransform.SetScaled(width, height, 1);
            UpdateTransform();
        }

        public void Translate(float x, float y)
        {
            localTransform.Translate(x, y);
            UpdateTransform();
        }

        public void Rotate(float radians)
        {
            localTransform.RotateZ(radians);
            UpdateTransform();
        }

        public void Scale(float width , float height) 
        {
            localTransform.SetScaled(width,height, 1);
            UpdateTransform();
        }

    }
}
