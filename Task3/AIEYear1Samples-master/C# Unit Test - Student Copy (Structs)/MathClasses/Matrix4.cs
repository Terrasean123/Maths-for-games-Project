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

        public Matrix4(float m00, float m01, float m02, float m03, float m10, float m11, float m12, float m13, float m20, float m21, float m22, float m23, float m30, float m31, float m32, float m33)
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
        public static Matrix4 operator *(Matrix4 M1, Matrix4 M2)
        {
            return new Matrix4(
               M1.m00 * M2.m00 + M1.m10 * M2.m01 + M1.m20 * M2.m02 + M1.m30 * M2.m03,
               M1.m01 * M2.m00 + M1.m11 * M2.m01 + M1.m21 * M2.m02 + M1.m31 * M2.m03,
               M1.m02 * M2.m00 + M1.m12 * M2.m01 + M1.m22 * M2.m02 + M1.m32 * M2.m03,
               M1.m03 * M2.m00 + M1.m13 * M2.m01 + M1.m23 * M2.m02 + M1.m33 * M2.m03,

               M1.m00 * M2.m10 + M1.m10 * M2.m11 + M1.m20 * M2.m12 + M1.m30 * M2.m13,
               M1.m01 * M2.m10 + M1.m11 * M2.m11 + M1.m21 * M2.m12 + M1.m31 * M2.m13,
               M1.m02 * M2.m10 + M1.m12 * M2.m11 + M1.m22 * M2.m12 + M1.m32 * M2.m13,
               M1.m03 * M2.m10 + M1.m13 * M2.m11 + M1.m23 * M2.m12 + M1.m33 * M2.m13,

               M1.m00 * M2.m20 + M1.m10 * M2.m21 + M1.m20 * M2.m22 + M1.m30 * M2.m23,
               M1.m01 * M2.m20 + M1.m11 * M2.m21 + M1.m21 * M2.m22 + M1.m31 * M2.m23,
               M1.m02 * M2.m20 + M1.m12 * M2.m21 + M1.m22 * M2.m22 + M1.m32 * M2.m23,
               M1.m03 * M2.m20 + M1.m13 * M2.m21 + M1.m23 * M2.m22 + M1.m33 * M2.m23,

               M1.m00 * M2.m30 + M1.m10 * M2.m31 + M1.m20 * M2.m32 + M1.m30 * M2.m33,
               M1.m01 * M2.m30 + M1.m11 * M2.m31 + M1.m21 * M2.m32 + M1.m31 * M2.m33,
               M1.m02 * M2.m30 + M1.m12 * M2.m31 + M1.m22 * M2.m32 + M1.m32 * M2.m33,
               M1.m03 * M2.m30 + M1.m13 * M2.m31 + M1.m23 * M2.m32 + M1.m33 * M2.m33

              //new Vector4(M1.m00, M1.m10, M1.m20, M1.m30).Dot(new Vector4(M2.m00, M2.m01, M2.m02, M1.m03)),// COLUMNS/ROWS
              //new Vector4(M1.m00, M1.m10, M1.m20, M1.m30).Dot(new Vector4(M2.m10, M2.m11, M2.m12, M1.m13)),/// rememeber that you use outside outside to multiply
              //new Vector4(M1.m00, M1.m10, M1.m20, M1.m30).Dot(new Vector4(M2.m20, M2.m21, M2.m22, M1.m23)),
              //new Vector4(M1.m00, M1.m10, M1.m20, M1.m30).Dot(new Vector4(M2.m30, M2.m31, M2.m32, M1.m33)),

              //new Vector4(M1.m01, M1.m11, M1.m21, M1.m31).Dot(new Vector4(M2.m00, M2.m01, M2.m02, M1.m03)),
              //new Vector4(M1.m01, M1.m11, M1.m21, M1.m31).Dot(new Vector4(M2.m10, M2.m11, M2.m12, M1.m13)),
              //new Vector4(M1.m01, M1.m11, M1.m21, M1.m31).Dot(new Vector4(M2.m20, M2.m21, M2.m22, M1.m23)),
              //new Vector4(M1.m01, M1.m11, M1.m21, M1.m31).Dot(new Vector4(M2.m30, M2.m31, M2.m32, M1.m33)),

              //new Vector4(M1.m02, M1.m12, M1.m22, M1.m32).Dot(new Vector4(M2.m00, M2.m01, M2.m02, M1.m03)),
              //new Vector4(M1.m02, M1.m12, M1.m22, M1.m32).Dot(new Vector4(M2.m10, M2.m11, M2.m12, M1.m13)),
              //new Vector4(M1.m02, M1.m12, M1.m22, M1.m32).Dot(new Vector4(M2.m20, M2.m21, M2.m22, M1.m23)),
              //new Vector4(M1.m02, M1.m12, M1.m22, M1.m32).Dot(new Vector4(M2.m30, M2.m31, M2.m32, M1.m33)),

              //new Vector4(M1.m03, M1.m13, M1.m23, M1.m33).Dot(new Vector4(M2.m00, M2.m01, M2.m02, M1.m03)),
              //new Vector4(M1.m03, M1.m13, M1.m23, M1.m33).Dot(new Vector4(M2.m10, M2.m11, M2.m12, M1.m13)),
              //new Vector4(M1.m03, M1.m13, M1.m23, M1.m33).Dot(new Vector4(M2.m20, M2.m21, M2.m22, M1.m23)),
              //new Vector4(M1.m03, M1.m13, M1.m23, M1.m33).Dot(new Vector4(M2.m30, M2.m31, M2.m32, M1.m33))
              );

        }

        public static Vector4 operator *(Matrix4 M, Vector4 V)
        {

            return new Vector4(
                V.x * M.m00 + V.y * M.m10 + V.z * M.m20 + V.w * M.m30,
                V.x * M.m01 + V.y * M.m11 + V.z * M.m21 + V.w * M.m31,
                V.x * M.m02 + V.y * M.m12 + V.z * M.m22 + V.w * M.m32,
                V.x * M.m03 + V.y * M.m13 + V.z * M.m23 + V.w * M.m33);
        }
        public void SetRotateX(double radians)
        {
            float c = (float)Math.Cos(radians);
            float s = (float)Math.Sin(radians);

            m00 = 1; m01 = 0; m02 = 0; m03 = 0;
            m10 = 0; m11 = c; m12 = s; m13 = 0;
            m20 = 0; m21 = -s; m22 = c; m23 = 0;
            m30 = 0; m31 = 0; m32 = 0; m33 = 1;
        }
        public void SetRotateY(double radians )
        {

            float c = (float)Math.Cos(radians);
            float s = (float)Math.Sin(radians);

            m00 = c; m01 = 0; m02 = -s; m03 = 0;
            m10 = 0; m11 = 1; m12 = 0; m13 = 0;
            m20 = s; m21 = 0; m22 = c; m23 = 0;
            m30 = 0; m31 = 0; m32 = 0; m33 = 1;
        }
        public void SetRotateZ(double radians )
        {
            float c = (float)Math.Cos(radians);
            float s = (float)Math.Sin(radians);

            m00 = c; m01 = s; m02 = 0; m03 = 0;
            m10 = -s; m11 = c; m12 = 0; m13 = 0;
            m20 = 0; m21 = 0; m22 = 1; m23 = 0;
            m30 = 0; m31 = 0; m32 = 0; m33 = 1;
        }

    }
}
