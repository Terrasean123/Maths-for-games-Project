using System;
using System.Collections.Generic;
using System.IO.IsolatedStorage;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public struct Vector3
    {
        public float x, y, z;

        public Vector3(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public static Vector3 operator +(Vector3 l, Vector3 r)
        {

            l.y += r.y;
            l.x += r.x;
            l.z += r.z;

            return l;
        }

        public static Vector3 operator *(Vector3 l, float r)
        {

            l.x *= r;
            l.y *= r;
            l.z *= r;
            return l;

        }

        public static Vector3 operator *(float l, Vector3 r)
        {
            r.x *= l;
            r.y *= l;
            r.z *= l;
            return r;

        }

        public static Vector3 operator /(Vector3 l, float r)
        {
            l.y /= r;
            l.x /= r;
            l.z /= r;

            return l;
        }

        public static Vector3 operator -(Vector3 l, Vector3 r)
        {
            l.y -= r.y;
            l.x -= r.x;
            l.z -= r.z;
            return l;
        }

        public static Vector3 Clamp(Vector3 t, Vector3 a, Vector3 b)
        {
            return Max(a, Min(b, t));
        }

        public static Vector3 Min(Vector3 a, Vector3 b)
        {
            return new Vector3(Math.Min(a.x, b.x), Math.Min(a.y, b.y), Math.Min(a.z, b.z));
        }

        public static Vector3 Max(Vector3 a, Vector3 b)
        {
            return new Vector3(Math.Max(a.x, b.x), Math.Max(a.y, b.y), Math.Max(a.z, b.z));
        }

        public float Dot(Vector3 o)
        {
            return (this.x * o.x) + (this.y * o.y) + (this.z * o.z);
        }

        public Vector3 Cross(Vector3 o)
        {
            return new Vector3(
            (this.y * o.z) - (this.z * o.y), /*x*/
            (this.z * o.x) - (this.x * o.z),/*y*/
            (this.x * o.y) - (this.y * o.x));/* z*/

        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(x * x + y * y + z * z);
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }


        public void Normalize()
        {
            this /= this.Magnitude();
        }
    }
}
