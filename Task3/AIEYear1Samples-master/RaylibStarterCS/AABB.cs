using MathClasses;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace RaylibStarterCS
{
    internal class AABB
    {
        MathClasses.Vector3 min = new MathClasses.Vector3(float.NegativeInfinity,
                                  float.NegativeInfinity,
                                  float.NegativeInfinity);
        MathClasses.Vector3 max = new MathClasses.Vector3(float.PositiveInfinity,
                                  float.PositiveInfinity,
                                  float.PositiveInfinity);

        public bool isEmpty()
        {
            if (float.IsNegativeInfinity(min.x) &&
                    float.IsNegativeInfinity(min.y) &&
                     float.IsNegativeInfinity(min.z) &&
                       float.IsInfinity(max.x) &&
                        float.IsInfinity(max.y) &&
                         float.IsInfinity(max.z))
                return true;
            return false;
        }


        public void Empty()
        {

            min = new MathClasses.Vector3(float.NegativeInfinity,
                              float.NegativeInfinity,
                              float.NegativeInfinity);
            max = new MathClasses.Vector3(float.PositiveInfinity,
                              float.PositiveInfinity,
                              float.PositiveInfinity);
        }


        void SetToTransFormedBox(AABB box, Matrix3 m)
        {
            // If we're empty, then exit (an empty box defined as having the min/max
            // set to infinity)

            if (box.isEmpty())
            {
                Empty();
                return;
            }

            // Examine each of the nine matrix elements
            // and compute the new AABB
            if(m.m00 > 0.0f) 
            {
                min.x += m.m00 * box.min.x; max.x += m.m00 * box.max.x;
            }
            else 
            {
                //min.x += m.m00 * box.max.x;
                min.x += m.m00 * box.max.x; max.x += m.m00 * box.min.x;
            }
            if (m.m01 > 0.0f ) 
            {
                min.z += m.m01 * box.min.x; max.z += m.m01 * box.min.x;
            }
            else
            {
                //min.x += m.m00 * box.max.x;
                min.x += m.m01 * box.max.x; max.x += m.m01 * box.min.x;
            }
            if (m.m02 > 0.0f)
            {
                min.z += m.m02 * box.min.x; max.z += m.m02 * box.min.x;
            }
            else
            {
                //min.x += m.m00 * box.max.x;
                min.z += m.m02 * box.max.x; max.z += m.m02 * box.min.x;
            }

        }




    }
}
