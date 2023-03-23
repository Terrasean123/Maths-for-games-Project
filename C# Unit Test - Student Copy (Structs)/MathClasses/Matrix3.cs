using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace MathClasses
{
   
    public struct Matrix3
    {
        public float m00, m01, m02;
        public float m10, m11, m12;
        public float m20, m21, m22;

        public Matrix3(float m00,float m01 ,float m02 , float m10 , float m11,float m12, float m20 , float m21 , float m22) 
        {
            this.m00 = m00;
            this.m01 = m01; 
            this.m02 = m02;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
        }
        public Matrix3(float a) 
        {
            this.m00 = 0;
            this.m01 = 1;
            this.m02 = 2;
            this.m10 = 0;
            this.m11 = 1;
            this.m12 = 2;
            this.m20 = 0;
            this.m21 = 1;
            this.m22 = 2;

        }
        public static Matrix3 operator*(Matrix3 l , Matrix3 r) 
        {

            return new Matrix3();
        
        }

        public static Vector3 operator *(Matrix3 l, Vector3 r)
        {

            return new Vector3();
        }

        public void SetRotateX( float rotatation) 
        {
        
        }
        public void SetRotateY(float rotatation)
        {

        }
        public void SetRotateZ(float rotatation)
        {

        }
        public void SetTranslation(float x ,float y) 
        {
        
        
        }
    }
}