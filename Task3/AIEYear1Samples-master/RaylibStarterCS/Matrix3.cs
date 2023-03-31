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

        public Matrix3(float m00, float m01, float m02, float m10, float m11, float m12, float m20, float m21, float m22)
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
        public Matrix3(Vector3 X, Vector3 Y, Vector3 Z)
        {

            m00 = X.x; m01 = X.y; m02 = X.z;
            m10 = Y.x; m11 = Y.y; m12 = Y.z;
            m20 = Z.x; m21 = Z.z; m22 = Z.z;
        }


        public Matrix3(float uniformScale) // for creating an identity matrix
        {
            m00 = m11 = m22 = uniformScale;
            m01 = m02 = m10 = m12 = m12 = m20 = m21 = 0;

        }


        public static Matrix3 operator *(Matrix3 M1, Matrix3 M2)
        {
            return new Matrix3(
                 M1.m00 * M2.m00 + M1.m10 * M2.m01 + M1.m20 * M2.m02,
                 M1.m01 * M2.m00 + M1.m11 * M2.m01 + M1.m21 * M2.m02,
                 M1.m02 * M2.m00 + M1.m12 * M2.m01 + M1.m22 * M2.m02,

                  M1.m00 * M2.m10 + M1.m10 * M2.m11 + M1.m20 * M2.m12,
                  M1.m01 * M2.m10 + M1.m11 * M2.m11 + M1.m21 * M2.m12,
                  M1.m02 * M2.m10 + M1.m12 * M2.m11 + M1.m22 * M2.m12,

                  M1.m00 * M2.m20 + M1.m10 * M2.m21 + M1.m20 * M2.m22,
                  M1.m01 * M2.m20 + M1.m11 * M2.m21 + M1.m21 * M2.m22,
                  M1.m02 * M2.m20 + M1.m12 * M2.m21 + M1.m22 * M2.m22

                );

        }

        public static Vector3 operator *(Matrix3 M, Vector3 V)
        {
            return new Vector3(
                // V.x * xaxis + V.y * yaxis + V.z * zaxis
                V.x * M.m00 + V.y * M.m10 + V.z * M.m20,
                V.x * M.m01 + V.y * M.m11 + V.z * M.m21,
                V.x * M.m02 + V.y * M.m12 + V.z * M.m22
                );
        }

        public void SetRotateX(double radians)
        {
            this.m00 = 1;
            this.m01 = 0;
            this.m02 = 0;
            this.m10 = 0;
            this.m11 = (float)Math.Cos(radians);
            this.m12 = (float)Math.Sin(radians);
            this.m20 = 0;
            this.m21 = (float)-Math.Sin(radians);
            this.m22 = (float)Math.Cos(radians);
        }
        public void SetRotateY(double radians)
        {
            this.m00 = (float)Math.Cos(radians);
            this.m01 = 0;
            this.m02 = (float)-Math.Sin(radians);
            this.m10 = 0;
            this.m11 = 1;
            this.m12 = 0;
            this.m20 = (float)Math.Sin(radians);
            this.m21 = 0;
            this.m22 = (float)Math.Cos(radians);
        }
        public void SetRotateZ(double radians)
        {
            this.m00 = (float)Math.Cos(radians);
            this.m01 =(float)Math.Sin(radians);
            this.m02 = 0;
            this.m10 = (float)-Math.Sin(radians);
            this.m11 = (float)Math.Cos(radians);
            this.m12 = 0;
            this.m20 = 0;
            this.m21 = 0;
            this.m22 = 1;
        }
        public void SetTranslation(float x, float y)
        {

            this.m20 = x; this.m21 = y;
        }
        public void SetScaled(float x, float y, float z)
        {
            m00 = x; m01 = 0; m02 = 0;
            m10 = 0; m11 = y; m12 = 0;
            m20 = 0; m21 = 0; m22 = z;
        }
        public void SetScaled(Vector3 v)
        {
            m00 = v.x; m01 = 0; m02 = 0;
            m10 = 0; m11 = v.y; m12 = 0;
            m20 = 0; m21 = 0; m22 = v.z;
        }
        //public void Scale(float x, float y, float z)
        //{
        //    Matrix3 m = new Matrix3();
        //    m.SetScaled(x, y, z);
        //    Set(this * m);
        //}
    }
}