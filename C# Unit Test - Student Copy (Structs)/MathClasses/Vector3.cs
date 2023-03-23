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
            return new Vector3();
        }

        public static Vector3 operator *(Vector3 l, float r)
        {

            return new Vector3();

        }

        public static Vector3 operator *(float l, Vector3 r)
        {

            return new Vector3();

        }

        public static Vector3 operator -(Vector3 l, Vector3 r)
        {

            return new Vector3();
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

        public void Normalize()
        {
            this *= this.Magnitude();
        }



    }
}
