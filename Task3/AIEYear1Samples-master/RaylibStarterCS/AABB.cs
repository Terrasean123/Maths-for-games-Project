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

        public AABB()
        {
        }

        public AABB(MathClasses.Vector3 min, MathClasses.Vector3 max)
        {
            this.min = min;
            this.max = max;
        }

        public MathClasses.Vector3 Center()
        {
            return (min + max) * 0.5f;
        }

        public MathClasses.Vector3 Extents()
        {
            return new MathClasses.Vector3(
                Math.Abs(max.x - min.x) * 0.5f,
                Math.Abs(max.y - min.y) * 0.5f,
                Math.Abs(max.z - min.z) * 0.5f);
        }

        public void Fit(MathClasses.Vector3[] points)
        {
            min = new MathClasses.Vector3(
                float.PositiveInfinity,
                float.PositiveInfinity,
                float.PositiveInfinity);

            max = new MathClasses.Vector3(
                float.NegativeInfinity,
                float.NegativeInfinity,
                float.NegativeInfinity);

            foreach (MathClasses.Vector3 p in points)
            {
                min = MathClasses.Vector3.Min(min, p);
                max = MathClasses.Vector3.Max(max, p);
            }
        }

        public bool Overlaps(MathClasses.Vector3 p)
        {
            // test for not overlapped as it exits faster
            return !(p.x < min.x || p.y < min.y ||
                    p.x > max.x || p.x > max.y);
        }

        public bool Overlaps(AABB other)
        {
            return !(max.x < other.min.x || max.y < other.min.y
                    || min.x > other.max.x || min.y > other.max.y);


        }

        public MathClasses.Vector3 ClosestPoint(MathClasses.Vector3 p)
        {
            return MathClasses.Vector3.Clamp(p, min, max);
        }

        public MathClasses.Vector3[] Corners()
        {
            MathClasses.Vector3[] corners = new MathClasses.Vector3[4];
            corners[0] = min;
            corners[1] = new MathClasses.Vector3(min.x, max.y, min.z);
            corners[2] = max;
            corners[3] = new MathClasses.Vector3(max.x, min.y, min.z);
            return corners;
        }

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
            if (m.m00 > 0.0f)
            {
                min.x += m.m00 * box.min.x; max.x += m.m00 * box.max.x;
            }
            else
            {
                //min.x += m.m00 * box.max.x;
                min.x += m.m00 * box.max.x; max.x += m.m00 * box.min.x;
            }
            if (m.m01 > 0.0f)
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





            if (m.m10 > 0.0f)
            {
                min.x += m.m10 * box.min.x; max.x += m.m10 * box.max.x;
            }
            else
            {
                //min.x += m.m00 * box.max.x;
                min.x += m.m10 * box.max.x; max.x += m.m10 * box.min.x;
            }
            if (m.m11 > 0.0f)
            {
                min.z += m.m11 * box.min.x; max.z += m.m11 * box.min.x;
            }
            else
            {
                //min.x += m.m00 * box.max.x;
                min.x += m.m11 * box.max.x; max.x += m.m11 * box.min.x;
            }
            if (m.m02 > 0.0f)
            {
                min.z += m.m12 * box.min.x; max.z += m.m12 * box.min.x;
            }
            else
            {
                //min.x += m.m00 * box.max.x;
                min.z += m.m12 * box.max.x; max.z += m.m12 * box.min.x;
            }




            if (m.m20 > 0.0f)
            {
                min.x += m.m20 * box.min.x; max.x += m.m20 * box.max.x;
            }
            else
            {
                //min.x += m.m00 * box.max.x;
                min.x += m.m20 * box.max.x; max.x += m.m20 * box.min.x;
            }
            if (m.m21 > 0.0f)
            {
                min.z += m.m21 * box.min.x; max.z += m.m21 * box.min.x;
            }
            else
            {
                //min.x += m.m00 * box.max.x;
                min.x += m.m21 * box.max.x; max.x += m.m21 * box.min.x;
            }
            if (m.m22 > 0.0f)
            {
                min.z += m.m22 * box.min.x; max.z += m.m22 * box.min.x;
            }
            else
            {
                //min.x += m.m00 * box.max.x;
                min.z += m.m22 * box.max.x; max.z += m.m22 * box.min.x;
            }
        }




    }
}
