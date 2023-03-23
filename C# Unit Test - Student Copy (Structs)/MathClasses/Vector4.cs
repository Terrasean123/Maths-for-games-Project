using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathClasses
{
    public struct Vector4
    {
        public float x, y, z, w;


        public Vector4(float x, float y, float z , float w)
        {
            this.x = x;
            this.y = y;
            this.z = z;
            this.w = w; 
        }

        public static Vector4 operator +(Vector4 l, Vector4 r)
        {
            return new Vector4();
        }

        public static Vector4 operator -(Vector4 l, Vector4 r) 
        {

            return new Vector4();
        
        }


        public static Vector4 operator *(Vector4 l, float r)
        {

            return new Vector4();

        }

        public static Vector4 operator *(float l, Vector4 r)
        {

            return new Vector4();

        }



        public float Dot(Vector4 o)// gives angle between vectors measures parrellelness
        {
            return (this.x * o.x) + (this.y * o.y) + (this.z * o.z)+0;
           
        }

        public Vector4 Cross(Vector4 o)// gives vector between perpendicular vectors for finding up down left and right provided there is at least one vectr
        {
            return new Vector4(
          (this.y * o.z) - (this.z * o.y), /*x*/
          (this.z * o.x) - (this.x * o.z),/*y*/
          (this.x * o.y) - (this.y * o.x),
          0);/* z*/
            
        }

        public float Magnitude()
        {
            return (float)Math.Sqrt(
                (float)Math.Pow(x, 2) +
                (float)Math.Pow(y, 2) +
                (float)Math.Pow(z, 2) +  
                (float)Math.Pow(w,2));
        }

        public float MagnitudeSqr()
        {
            return (x * x + y * y + z * z);
        }


        public void Normalize()
        {

        }
    }
}
