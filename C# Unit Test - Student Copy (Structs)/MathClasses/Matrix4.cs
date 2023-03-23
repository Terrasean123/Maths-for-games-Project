using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace MathClasses
{
    public struct Matrix4
    {
        public float m00, m01, m02, m03;
        public float m10, m11, m12, m13;
        public float m20, m21, m22, m23;
        public float m30, m31, m32, m33;

        public Matrix4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13 , float m20, float m21, float m22, float m23 , float m30 , float m31,  float m32, float m33)
        {
            this.m00 = m00;
            this.m01 = m01;
            this.m02 = m02;
            this.m03 = m03;
            this.m10 = m10;
            this.m11 = m11;
            this.m12 = m12;
            this.m13 = m13;
            this.m20 = m20;
            this.m21 = m21;
            this.m22 = m22;
            this.m23 = m23;
            this.m30 = m30;
            this.m31 = m31;
            this.m32 = m32;
            this.m33 = m33;
        }
        public static Matrix4 operator *(Matrix4 l, Matrix4 r)
        {

            return new Matrix4();

        }

        public static Vector4 operator *( Matrix4 l , Vector4 r) 
        {

            return new Vector4();
        }
        public void SetRotateX(float rotatation)
        {

        }
        public void SetRotateY(float rotatation)
        {

        }
        public void SetRotateZ(float rotatation)
        {

        }

    }
}
