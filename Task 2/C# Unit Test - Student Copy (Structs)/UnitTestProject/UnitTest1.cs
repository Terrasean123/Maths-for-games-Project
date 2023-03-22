using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MathClasses;

//All tests below include the following attributes in some form.
//DataTestMethod: enables data used for testing to originate outside of the test code.
//DataRow: represents a single run of the test and what values will be used during the test.
//Note - Each DataRow must have as many parameters as the test function does. The types must also match.

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        //const float DEFAULT_TOLERANCE = 0.0001f;

        ///// <summary>
        ///// Helper function for asserting on the state of complex objects. Determines whether two objects are approximately equivelant to each other.
        ///// </summary>
        ///// <param name="expected">Expected value</param>
        ///// <param name="actual">Actual Value</param>
        ///// <param name="tolerance">Acceptable delta between <paramref name="expected"/> and <paramref name="actual"/></param>
        //static void AreEquivalent(Vector3 expected, Vector3 actual, float tolerance = DEFAULT_TOLERANCE)
        //{
        //    Assert.AreEqual(expected.x, actual.x, tolerance);
        //    Assert.AreEqual(expected.y, actual.y, tolerance);
        //    Assert.AreEqual(expected.z, actual.z, tolerance);
        //}

        //static void AreEquivalent(Vector4 expected, Vector4 actual, float tolerance = DEFAULT_TOLERANCE)
        //{
        //    Assert.AreEqual(expected.x, actual.x, tolerance);
        //    Assert.AreEqual(expected.y, actual.y, tolerance);
        //    Assert.AreEqual(expected.z, actual.z, tolerance);
        //    Assert.AreEqual(expected.w, actual.w, tolerance);
        //}

        //static void AreEquivalent(Matrix3 expected, Matrix3 actual, float tolerance = DEFAULT_TOLERANCE)
        //{
        //    Assert.AreEqual(expected.m00, actual.m00, tolerance);
        //    Assert.AreEqual(expected.m01, actual.m01, tolerance);
        //    Assert.AreEqual(expected.m02, actual.m02, tolerance);
        //    Assert.AreEqual(expected.m10, actual.m10, tolerance);
        //    Assert.AreEqual(expected.m11, actual.m11, tolerance);
        //    Assert.AreEqual(expected.m12, actual.m12, tolerance);
        //    Assert.AreEqual(expected.m20, actual.m20, tolerance);
        //    Assert.AreEqual(expected.m21, actual.m21, tolerance);
        //    Assert.AreEqual(expected.m22, actual.m22, tolerance);
        //}

        //static void AreEquivalent(Matrix4 expected, Matrix4 actual, float tolerance = DEFAULT_TOLERANCE)
        //{
        //    Assert.AreEqual(expected.m00, actual.m00, tolerance);
        //    Assert.AreEqual(expected.m01, actual.m01, tolerance);
        //    Assert.AreEqual(expected.m02, actual.m02, tolerance);
        //    Assert.AreEqual(expected.m03, actual.m03, tolerance);
        //    Assert.AreEqual(expected.m10, actual.m10, tolerance);
        //    Assert.AreEqual(expected.m11, actual.m11, tolerance);
        //    Assert.AreEqual(expected.m12, actual.m12, tolerance);
        //    Assert.AreEqual(expected.m13, actual.m13, tolerance);
        //    Assert.AreEqual(expected.m20, actual.m20, tolerance);
        //    Assert.AreEqual(expected.m21, actual.m21, tolerance);
        //    Assert.AreEqual(expected.m22, actual.m22, tolerance);
        //    Assert.AreEqual(expected.m23, actual.m23, tolerance);
        //    Assert.AreEqual(expected.m30, actual.m30, tolerance);
        //    Assert.AreEqual(expected.m31, actual.m31, tolerance);
        //    Assert.AreEqual(expected.m32, actual.m32, tolerance);
        //    Assert.AreEqual(expected.m33, actual.m33, tolerance);
        //}

        ///// <summary>
        ///// Helper function for asserting on the state of complex data structures. Determines whether two objects are equivelant to each other.
        ///// </summary>
        ///// <remarks>Not suitable for most use-cases.</remarks>
        ///// <param name="expected"></param>
        ///// <param name="actual"></param>
        //static void AreEqual(Vector3 expected, Vector3 actual)
        //{
        //    Assert.AreEqual(expected.x, actual.x);
        //    Assert.AreEqual(expected.y, actual.y);
        //    Assert.AreEqual(expected.z, actual.z);
        //}
        //static void AreEqual(Vector4 expected, Vector4 actual)
        //{
        //    Assert.AreEqual(expected.x, actual.x);
        //    Assert.AreEqual(expected.y, actual.y);
        //    Assert.AreEqual(expected.z, actual.z);
        //    Assert.AreEqual(expected.w, actual.w);
        //}
        //static void AreEqual(Matrix3 expected, Matrix3 actual)
        //{
        //    Assert.AreEqual(expected.m00, actual.m00);
        //    Assert.AreEqual(expected.m01, actual.m01);
        //    Assert.AreEqual(expected.m02, actual.m02);
        //    Assert.AreEqual(expected.m10, actual.m10);
        //    Assert.AreEqual(expected.m11, actual.m11);
        //    Assert.AreEqual(expected.m12, actual.m12);
        //    Assert.AreEqual(expected.m20, actual.m20);
        //    Assert.AreEqual(expected.m21, actual.m21);
        //    Assert.AreEqual(expected.m22, actual.m22);
        //}
        //static void AreEqual(Matrix4 expected, Matrix4 actual)
        //{
        //    Assert.AreEqual(expected.m00, actual.m00);
        //    Assert.AreEqual(expected.m01, actual.m01);
        //    Assert.AreEqual(expected.m02, actual.m02);
        //    Assert.AreEqual(expected.m03, actual.m03);
        //    Assert.AreEqual(expected.m10, actual.m10);
        //    Assert.AreEqual(expected.m11, actual.m11);
        //    Assert.AreEqual(expected.m12, actual.m12);
        //    Assert.AreEqual(expected.m13, actual.m13);
        //    Assert.AreEqual(expected.m20, actual.m20);
        //    Assert.AreEqual(expected.m21, actual.m21);
        //    Assert.AreEqual(expected.m22, actual.m22);
        //    Assert.AreEqual(expected.m23, actual.m23);
        //    Assert.AreEqual(expected.m30, actual.m30);
        //    Assert.AreEqual(expected.m31, actual.m31);
        //    Assert.AreEqual(expected.m32, actual.m32);
        //    Assert.AreEqual(expected.m33, actual.m33);
        //}

        ///// <summary>
        ///// Helper function to remove reliance on correct implementation of student-made constructors. Creates an object and sets all fields individually.
        ///// </summary>
        ///// <returns>Newly created object with provided values set.</returns>
        //static Vector3 CreateVec3(float a, float b, float c)
        //{
        //    var v = new Vector3();
        //    v.x = a; v.y = b; v.z = c;
        //    return v;
        //}
        //static Vector4 CreateVec4(float a, float b, float c, float d)
        //{
        //    var v = new Vector4();
        //    v.x = a; v.y = b; v.z = c; v.w = d;
        //    return v;
        //}
        //static Matrix3 CreateMat3(float s)
        //{
        //    var m = new Matrix3();

        //    m.m00 = m.m11 = m.m22 = s;
        //    m.m01 = m.m02 = 0;
        //    m.m10 = m.m12 = 0;
        //    m.m20 = m.m21 = 0;

        //    return m;
        //}
        //static Matrix3 CreateMat3(float a, float b, float c,
        //                        float d, float e, float f,
        //                        float g, float h, float i)
        //{
        //    var m = new Matrix3();

        //    m.m00 = a; m.m01 = b; m.m02 = c;
        //    m.m10 = d; m.m11 = e; m.m12 = f;
        //    m.m20 = g; m.m21 = h; m.m22 = i;

        //    return m;
        //}
        //static Matrix4 CreateMat4(float s)
        //{
        //    var mat = new Matrix4();

        //    mat.m00 = mat.m11 = mat.m22 = mat.m33 = s;
        //    mat.m01 = mat.m02 = mat.m03 = mat.m10 = mat.m12 = mat.m13 = mat.m20 = mat.m21 = mat.m23 = mat.m30 = mat.m31 = mat.m32 = 0;

        //    return mat;
        //}
        //static Matrix4 CreateMat4(float a, float b, float c, float d,
        //    float e, float f, float g, float h,
        //    float i, float j, float k, float l,
        //    float m, float n, float o, float p)
        //{
        //    var mat = new Matrix4();

        //    mat.m00 = a; mat.m01 = b; mat.m02 = c; mat.m03 = d;
        //    mat.m10 = e; mat.m11 = f; mat.m12 = g; mat.m13 = h;
        //    mat.m20 = i; mat.m21 = j; mat.m22 = k; mat.m23 = l;
        //    mat.m30 = m; mat.m31 = n; mat.m32 = o; mat.m33 = p;

        //    return mat;
        //}
        static Colour CreateColour(UInt32 value)
        {
            var col = new Colour();

            col.colour = value;

            return col;
        }
        static Colour CreateColour(byte r, byte g, byte b, byte a)
        {
            var col = new Colour();

            col.colour = (UInt32)r << 24 | (UInt32)g << 16 | (UInt32)b << 8 | (UInt32)a;

            return col;
        }


        //[DataRow(3.4f, 2.3f, 1.2f)]
        //[DataRow(0.0f, 0.0f, 0.0f)]
        //[DataRow(0.0f, 0.0f, 1.0f)]
        //[DataTestMethod]
        //public void Vector3Construction(float x, float y, float z)
        //{
        //    var v3a = new Vector3(x, y, z);

        //    AreEqual(CreateVec3(x, y, z), v3a);
        //}

        //[DataRow(3.4f, 2.3f, 1.2f, 0.1f)]
        //[DataRow(0.0f, 0.0f, 0.0f, 0.0f)]
        //[DataRow(0.0f, 0.0f, 0.0f, 1.0f)]
        //[DataTestMethod]
        //public void Vector4Construction(float x, float y, float z, float w)
        //{
        //    var v3a = new Vector4(x, y, z, w);

        //    AreEqual(CreateVec4(x, y, z, w), v3a);
        //}

        //[DataRow(0, 0, 0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1, 1, 1)]
        //[DataRow(-1, -1, -1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 5.0f, 3.99f, -12.0f)]
        //[DataTestMethod]
        //public void Vector3Addition(float x1, float y1, float z1, float x2, float y2, float z2)
        //{
        //    Vector3 v3a = CreateVec3(x1, y1, z1);
        //    Vector3 v3b = CreateVec3(x2, y2, z2);
        //    Vector3 v3c = v3a + v3b;

        //    AreEquivalent(CreateVec3(x1 + x2, y1 + y2, z1 + z2), v3c);
        //}

        //[DataRow(0, 0, 0, 0, 0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1, 1, 1, 1, 1)]
        //[DataRow(-1, -1, -1, -1, -1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 0, 5.0f, 3.99f, -12.0f, 1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 9.11f, 5.0f, 3.99f, -12.0f, -2.28f)]
        //[DataTestMethod]
        //public void Vector4Addition(float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2)
        //{
        //    Vector4 v4a = CreateVec4(x1, y1, z1, w1);
        //    Vector4 v4b = CreateVec4(x2, y2, z2, w2);
        //    Vector4 v4c = v4a + v4b;

        //    AreEquivalent(CreateVec4(x1 + x2, y1 + y2, z1 + z2, w1 + w2), v4c);
        //}

        //[DataRow(0, 0, 0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1, 1, 1)]
        //[DataRow(-1, -1, -1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 5.0f, 3.99f, -12.0f)]
        //[DataTestMethod]
        //public void Vector3Subtraction(float x1, float y1, float z1, float x2, float y2, float z2)
        //{
        //    Vector3 v3a = CreateVec3(x1, y1, z1);
        //    Vector3 v3b = CreateVec3(x2, y2, z2);
        //    Vector3 v3c = v3a - v3b;

        //    AreEquivalent(CreateVec3(x1 - x2, y1 - y2, z1 - z2), v3c);
        //}

        //[DataRow(0, 0, 0, 0, 0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1, 1, 1, 1, 1)]
        //[DataRow(-1, -1, -1, -1, -1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 0, 5.0f, 3.99f, -12.0f, 1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 9.11f, 5.0f, 3.99f, -12.0f, -2.28f)]
        //[DataTestMethod]
        //public void Vector4Subtraction(float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2)
        //{
        //    Vector4 v4a = CreateVec4(x1, y1, z1, w1);
        //    Vector4 v4b = CreateVec4(x2, y2, z2, w2);
        //    Vector4 v4c = v4a - v4b;

        //    AreEquivalent(CreateVec4(x1 - x2, y1 - y2, z1 - z2, w1 - w2), v4c);
        //}

        //[DataRow(0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1)]
        //[DataRow(-1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 5.0f)]
        //[DataTestMethod]
        //public void Vector3PostScale(float x, float y, float z, float s)
        //{
        //    Vector3 v3a = CreateVec3(x, y, z);
        //    Vector3 v3c = v3a * s;

        //    AreEquivalent(CreateVec3(x * s, y * s, z * s), v3c);
        //}

        //[DataRow(0, 0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1, 1)]
        //[DataRow(-1, -1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 5.0f, 9.12f)]
        //[DataTestMethod]
        //public void Vector4PostScale(float x, float y, float z, float w, float s)
        //{
        //    Vector4 v4a = CreateVec4(x, y, z, w);
        //    Vector4 v4c = v4a * s;

        //    AreEquivalent(CreateVec4(x * s, y * s, z * s, w * s), v4c);
        //}

        //[DataRow(0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1)]
        //[DataRow(-1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 5.0f)]
        //[DataTestMethod]
        //public void Vector3PreScale(float x, float y, float z, float s)
        //{
        //    Vector3 v3a = CreateVec3(x, y, z);
        //    Vector3 v3c = s * v3a;

        //    AreEquivalent(CreateVec3(x * s, y * s, z * s), v3c);
        //}

        //[DataRow(0, 0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1, 1)]
        //[DataRow(-1, -1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 5.0f, 9.12f)]
        //[DataTestMethod]
        //public void Vector4PreScale(float x, float y, float z, float w, float s)
        //{
        //    Vector4 v4a = CreateVec4(x, y, z, w);
        //    Vector4 v4c = s * v4a;

        //    AreEquivalent(CreateVec4(x * s, y * s, z * s, w * s), v4c);
        //}

        //[DataRow(0, 0, 0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1, 1, 1)]
        //[DataRow(-1, -1, -1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 5.0f, 3.99f, -12.0f)]
        //[DataTestMethod]
        //public void Vector3Dot(float x1, float y1, float z1, float x2, float y2, float z2)
        //{
        //    Vector3 v3a = CreateVec3(x1, y1, z1);
        //    Vector3 v3b = CreateVec3(x2, y2, z2);
        //    float dot3 = v3a.Dot(v3b);

        //    Assert.AreEqual(x1 * x2 + y1 * y2 + z1 * z2, dot3, DEFAULT_TOLERANCE);
        //}

        //[DataRow(0, 0, 0, 0, 0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1, 1, 1, 1, 1)]
        //[DataRow(-1, -1, -1, -1, -1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 0, 5.0f, 3.99f, -12.0f, 1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 9.11f, 5.0f, 3.99f, -12.0f, -2.28f)]
        //[DataTestMethod]
        //public void Vector4Dot(float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2)
        //{
        //    Vector4 v4a = CreateVec4(x1, y1, z1, w1);
        //    Vector4 v4b = CreateVec4(x2, y2, z2, w2);
        //    float dot4 = v4a.Dot(v4b);

        //    Assert.AreEqual(x1 * x2 + y1 * y2 + z1 * z2 + w1 * w2, dot4, DEFAULT_TOLERANCE);
        //}

        //[DataRow(0, 0, 0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1, 1, 1)]
        //[DataRow(1, 0, 1, 0, 1, 0)]
        //[DataRow(-1, -1, -1, 1, 1, 1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 5.0f, 3.99f, -12.0f)]
        //[DataTestMethod]
        //public void Vector3Cross(float x1, float y1, float z1, float x2, float y2, float z2)
        //{
        //    Vector3 v3a = CreateVec3(x1, y1, z1);
        //    Vector3 v3b = CreateVec3(x2, y2, z2);
        //    Vector3 v3c = v3a.Cross(v3b);

        //    var vValidateA = new System.Numerics.Vector3(x1, y1, z1);
        //    var vValidateB = new System.Numerics.Vector3(x2, y2, z2);
        //    var vValidate = System.Numerics.Vector3.Cross(vValidateA, vValidateB);

        //    AreEquivalent(CreateVec3(vValidate.X, vValidate.Y, vValidate.Z),
        //        v3c);
        //}

        //[DataRow(0, 0, 0, 0, 0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1, 1, 1, 1, 1)]
        //[DataRow(1, 0, 1, 1, 0, 1, 0, 1)]
        //[DataRow(-1, -1, -1, -1, 1, 1, 1, 1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 0, 5.0f, 3.99f, -12.0f, 1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 9.11f, 5.0f, 3.99f, -12.0f, -2.28f)]
        //[DataTestMethod]
        //public void Vector4Cross(float x1, float y1, float z1, float w1, float x2, float y2, float z2, float w2)
        //{
        //    Vector4 v4a = CreateVec4(x1, y1, z1, w1);
        //    Vector4 v4b = CreateVec4(x2, y2, z2, w2);
        //    Vector4 v4c = v4a.Cross(v4b);

        //    var vValidateA = new System.Numerics.Vector3(x1, y1, z1);
        //    var vValidateB = new System.Numerics.Vector3(x2, y2, z2);
        //    var vValidate = System.Numerics.Vector3.Cross(vValidateA, vValidateB);

        //    AreEquivalent(CreateVec4(vValidate.X, vValidate.Y, vValidate.Z, 0), v4c);
        //}


        //[DataRow(0, 0, 0)]
        //[DataRow(1, 1, 1)]
        //[DataRow(-1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f)]
        //[DataTestMethod]
        //public void Vector3Magnitude(float x, float y, float z)
        //{
        //    Vector3 v3a = CreateVec3(x, y, z);
        //    float mag3 = v3a.Magnitude();

        //    Assert.AreEqual((float)Math.Sqrt(x * x + y * y + z * z), mag3, DEFAULT_TOLERANCE);
        //}

        //[DataRow(0, 0, 0, 0)]
        //[DataRow(1, 1, 1, 1)]
        //[DataRow(-1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 88.47f)]
        //[DataTestMethod]
        //public void Vector4Magnitude(float x, float y, float z, float w)
        //{
        //    Vector4 v4a = CreateVec4(x, y, z, w);
        //    float mag4 = v4a.Magnitude();

        //    Assert.AreEqual((float)Math.Sqrt(x * x + y * y + z * z + w * w), mag4, DEFAULT_TOLERANCE);
        //}

        //[DataRow(1, 1, 1)]
        //[DataRow(1, 0, 0)]
        //[DataRow(-1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f)]
        //[DataRow(0.0156349f, -0.0558571f, 0.998316f)]
        //[DataTestMethod]
        //public void Vector3Normalise(float x, float y, float z)
        //{
        //    Vector3 v3a = CreateVec3(x, y, z);
        //    v3a.Normalize();

        //    var vValidate = new System.Numerics.Vector3(x, y, z);
        //    vValidate = System.Numerics.Vector3.Normalize(vValidate);

        //    AreEquivalent(CreateVec3(vValidate.X, vValidate.Y, vValidate.Z),
        //        v3a);
        //}

        //[DataRow(1, 1, 1, 1)]
        //[DataRow(1, 0, 0, 0)]
        //[DataRow(-1, -1, -1, -1)]
        //[DataRow(13.5f, -48.23f, 862.0f, 99.81f)]
        //[DataRow(0.0156349f, -0.0558571f, 0.998316f, 0)]
        //[DataRow(0.270935f, -0.0537745f, 0.961094f, 0)]
        //[DataTestMethod]
        //public void Vector4Normalise(float x, float y, float z, float w)
        //{
        //    Vector4 v4a = CreateVec4(x, y, z, w);
        //    v4a.Normalize();

        //    var vValidate = new System.Numerics.Vector4(x, y, z, w);
        //    vValidate = System.Numerics.Vector4.Normalize(vValidate);

        //    AreEquivalent(CreateVec4(vValidate.X, vValidate.Y, vValidate.Z, vValidate.W), v4a);
        //}

        //[DataRow(11.22f, 22.33f, 33.44f, 44.55f, 55.66f, 66.77f, 77.88f, 88.99f, 99.01f)]
        //[DataRow(1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f)]
        //[DataRow(1.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 1.0f)]
        //[DataTestMethod]
        //public void Matrix3Construction(float a, float b, float c, float d, float e, float f, float g, float h, float i)
        //{
        //    var m3a = new Matrix3(a, b, c,
        //                              d, e, f,
        //                              g, h, i);

        //    AreEqual(CreateMat3(a, b, c, d, e, f, g, h, i), m3a);
        //}

        //[DataRow(1.0f)]
        //[DataRow(4.0f)]
        //[DataRow(0.5f)]
        //[DataTestMethod]
        //public void Matrix3ScaleConstruction(float s)
        //{
        //    var m3a = new Matrix3(s);

        //    AreEqual(CreateMat3(s), m3a);
        //}

        //[DataRow(11.22f, 22.33f, 33.44f, 44.55f, 55.66f, 66.77f, 77.88f, 88.99f, 99.01f, 1.11f, 11.22f, 22.33f, 33.44f, 44.55f, 55.66f, 66.77f)]
        //[DataRow(1.0f, 2.0f, 3.0f, 4.0f, 5.0f, 6.0f, 7.0f, 8.0f, 9.0f, 10.0f, 11.0f, 12.0f, 13.0f, 14.0f, 15.0f, 16.0f)]
        //[DataRow(1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f, 1.0f, 1.0f, 0.0f, 0.0f, 0.0f, 0.0f)]
        //[DataTestMethod]
        //public void Matrix4Construction(float a, float b, float c, float d, float e, float f, float g, float h, float i,
        //                                float j, float k, float l, float m, float n, float o, float p)
        //{
        //    var m3a = new Matrix4(a, b, c, d,
        //                              e, f, g, h,
        //                              i, j, k, l,
        //                              m, n, o, p);

        //    AreEqual(CreateMat4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p), m3a);
        //}

        //[DataRow(0.0f, 1, 0)]
        //[DataRow(15.0f, 1, 0)]
        //[DataRow(15.0f, 0, 0)]
        //[DataRow(15.0f, 0, 1)]
        //[DataRow(15.0f, 1, 1)]
        //[DataRow(30.0f, 1, 0)]
        //[DataRow(45.0f, 1, 0)]
        //[DataRow(90.0f, 1, 0)]
        //[DataRow(180.0f, 1, 0)]
        //[DataRow(270.0f, 1, 0)]
        //[DataRow(360.0f, 1, 0)]
        //[DataTestMethod]
        //public void Matrix3SetRotateX(float r, float s, float o)
        //{
        //    float rAsRad = (float)(r * (180.0 / Math.PI));

        //    Matrix3 m3a = CreateMat3(s, o, o, o, s, o, o, o, s);
        //    m3a.SetRotateX(rAsRad);

        //    double sinVal = Math.Sin(rAsRad);
        //    double cosVal = Math.Cos(rAsRad);

        //    AreEquivalent(CreateMat3(1, 0, 0, 0, (float)cosVal, (float)sinVal, 0, (float)-sinVal, (float)cosVal),
        //        m3a);
        //}

        //[DataRow(0.0f, 1, 0)]
        //[DataRow(15.0f, 1, 0)]
        //[DataRow(15.0f, 0, 0)]
        //[DataRow(15.0f, 0, 1)]
        //[DataRow(15.0f, 1, 1)]
        //[DataRow(30.0f, 1, 0)]
        //[DataRow(45.0f, 1, 0)]
        //[DataRow(90.0f, 1, 0)]
        //[DataRow(180.0f, 1, 0)]
        //[DataRow(270.0f, 1, 0)]
        //[DataRow(360.0f, 1, 0)]
        //[DataTestMethod]
        //public void Matrix4SetRotateX(float r, float s, float o)
        //{
        //    float rAsRad = (float)(r * (180.0 / Math.PI));

        //    Matrix4 m4a = CreateMat4(s, o, o, o, o, s, o, o, o, o, s, o, o, o, o, s);
        //    m4a.SetRotateX(rAsRad);

        //    double sinVal = Math.Sin(rAsRad);
        //    double cosVal = Math.Cos(rAsRad);

        //    AreEquivalent(CreateMat4(1, 0, 0, 0, 0, (float)cosVal, (float)sinVal, 0, 0, (float)-sinVal, (float)cosVal, 0, 0, 0, 0, 1),
        //        m4a);
        //}

        //[DataRow(0.0f, 1, 0)]
        //[DataRow(15.0f, 1, 0)]
        //[DataRow(15.0f, 0, 0)]
        //[DataRow(15.0f, 0, 1)]
        //[DataRow(15.0f, 1, 1)]
        //[DataRow(30.0f, 1, 0)]
        //[DataRow(45.0f, 1, 0)]
        //[DataRow(90.0f, 1, 0)]
        //[DataRow(180.0f, 1, 0)]
        //[DataRow(270.0f, 1, 0)]
        //[DataRow(360.0f, 1, 0)]
        //[DataTestMethod]
        //public void Matrix3SetRotateY(float r, float s, float o)
        //{
        //    float rAsRad = (float)(r * (180.0 / Math.PI));

        //    Matrix3 m3a = CreateMat3(s, o, o, o, s, o, o, o, s);
        //    m3a.SetRotateY(rAsRad);

        //    double sinVal = Math.Sin(rAsRad);
        //    double cosVal = Math.Cos(rAsRad);

        //    AreEquivalent(CreateMat3((float)cosVal, 0, (float)-sinVal, 0, 1, 0, (float)sinVal, 0, (float)cosVal),
        //        m3a);
        //}

        //[DataRow(0.0f, 1, 0)]
        //[DataRow(15.0f, 1, 0)]
        //[DataRow(15.0f, 0, 0)]
        //[DataRow(15.0f, 0, 1)]
        //[DataRow(15.0f, 1, 1)]
        //[DataRow(30.0f, 1, 0)]
        //[DataRow(45.0f, 1, 0)]
        //[DataRow(90.0f, 1, 0)]
        //[DataRow(180.0f, 1, 0)]
        //[DataRow(270.0f, 1, 0)]
        //[DataRow(360.0f, 1, 0)]
        //[DataTestMethod]
        //public void Matrix4SetRotateY(float r, float s, float o)
        //{
        //    float rAsRad = (float)(r * (180.0 / Math.PI));

        //    Matrix4 m4a = CreateMat4(s, o, o, o, o, s, o, o, o, o, s, o, o, o, o, s);
        //    m4a.SetRotateY(rAsRad);

        //    double sinVal = Math.Sin(rAsRad);
        //    double cosVal = Math.Cos(rAsRad);

        //    AreEquivalent(CreateMat4((float)cosVal, 0, (float)-sinVal, 0, 0, 1, 0, 0, (float)sinVal, 0, (float)cosVal, 0, 0, 0, 0, 1),
        //        m4a);
        //}

        //[DataRow(0.0f, 1, 0)]
        //[DataRow(15.0f, 1, 0)]
        //[DataRow(15.0f, 0, 0)]
        //[DataRow(15.0f, 0, 1)]
        //[DataRow(15.0f, 1, 1)]
        //[DataRow(30.0f, 1, 0)]
        //[DataRow(45.0f, 1, 0)]
        //[DataRow(90.0f, 1, 0)]
        //[DataRow(180.0f, 1, 0)]
        //[DataRow(270.0f, 1, 0)]
        //[DataRow(360.0f, 1, 0)]
        //[DataTestMethod]
        //public void Matrix3SetRotateZ(float r, float s, float o)
        //{
        //    float rAsRad = (float)(r * (180.0 / Math.PI));

        //    Matrix3 m3a = CreateMat3(s, o, o, o, s, o, o, o, s);
        //    m3a.SetRotateZ(rAsRad);

        //    double sinVal = Math.Sin(rAsRad);
        //    double cosVal = Math.Cos(rAsRad);

        //    AreEquivalent(CreateMat3((float)cosVal, (float)sinVal, 0, (float)-sinVal, (float)cosVal, 0, 0, 0, 1),
        //        m3a);
        //}

        //[DataRow(0.0f, 1, 0)]
        //[DataRow(15.0f, 1, 0)]
        //[DataRow(15.0f, 0, 0)]
        //[DataRow(15.0f, 0, 1)]
        //[DataRow(15.0f, 1, 1)]
        //[DataRow(30.0f, 1, 0)]
        //[DataRow(45.0f, 1, 0)]
        //[DataRow(90.0f, 1, 0)]
        //[DataRow(180.0f, 1, 0)]
        //[DataRow(270.0f, 1, 0)]
        //[DataRow(360.0f, 1, 0)]
        //[DataTestMethod]
        //public void Matrix4SetRotateZ(float r, float s, float o)
        //{
        //    float rAsRad = (float)(r * (180.0 / Math.PI));

        //    Matrix4 m4a = CreateMat4(s, o, o, o, o, s, o, o, o, o, s, o, o, o, o, s);
        //    m4a.SetRotateZ(rAsRad);

        //    double sinVal = Math.Sin(rAsRad);
        //    double cosVal = Math.Cos(rAsRad);

        //    AreEquivalent(CreateMat4((float)cosVal, (float)sinVal, 0, 0, (float)-sinVal, (float)cosVal, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1),
        //        m4a);
        //}

        //[DataRow(0.0f, 0.0f, 1, 0)]
        //[DataRow(0.0f, 0.0f, 0, 0)]
        //[DataRow(0.0f, 0.0f, 0, 1)]
        //[DataRow(0.0f, 0.0f, 1, 1)]
        //[DataRow(1.0f, 1.0f, 1, 0)]
        //[DataRow(1.0f, 1.0f, 0, 0)]
        //[DataRow(1.0f, 1.0f, 0, 1)]
        //[DataRow(1.0f, 1.0f, 1, 1)]
        //[DataRow(1.23f, 2.34f, 1, 0)]
        //[DataRow(1.23f, 2.34f, 0, 0)]
        //[DataRow(1.23f, 2.34f, 0, 1)]
        //[DataRow(1.23f, 2.34f, 1, 1)]
        //[DataTestMethod]
        //public void Matrix3SetTranslation(float x, float y, float s, float o)
        //{
        //    Matrix3 m3a = CreateMat3(s, o, o, o, s, o, o, o, s);
        //    m3a.SetTranslation(x, y);

        //    AreEquivalent(CreateMat3(s, o, o, o, s, o, x, y, s), m3a);
        //}

        //[DataRow(1, 0, 0,
        //         0, 1, 0,
        //         0, 0, 1,
        //        2, 4, 6,
        //        8, 10, 12,
        //        14, 16, 18)]

        //[DataRow(2, 4, 6,
        //         8, 10, 12,
        //         14, 16, 18,
        //        1, 0, 0,
        //        0, 1, 0,
        //        0, 0, 1)]
        //[DataRow(2, 1, 1,
        //         1, 2, 1,
        //         1, 1, 2,
        //        1, 1, -1,
        //        1, -1, 1,
        //        -1, 1, 1)]
        //[DataRow(2.11f, 3.22f, 4.33f,
        //         5.44f, 6.55f, 7.66f,
        //         8.77f, 9.88f, 10.99f,
        //        11.100f, 12.110f, 13.120f,
        //        14.130f, 15.140f, 16.150f,
        //        17.160f, 18.170f, 19.180f)]
        //[DataTestMethod]
        //public void Matrix3Multiply(float a0, float a1, float a2, float a3, float a4, float a5, float a6, float a7, float a8,
        //                            float b0, float b1, float b2, float b3, float b4, float b5, float b6, float b7, float b8)
        //{
        //    Matrix3 m3a = CreateMat3(a0, a1, a2, a3, a4, a5, a6, a7, a8);
        //    Matrix3 m3b = CreateMat3(b0, b1, b2, b3, b4, b5, b6, b7, b8);

        //    Matrix3 m3c = m3a * m3b;

        //    var mValidateA = new System.Numerics.Matrix4x4(a0, a1, a2, 0, a3, a4, a5, 0, a6, a7, a8, 0, 0, 0, 0, 1);
        //    var mValidateB = new System.Numerics.Matrix4x4(b0, b1, b2, 0, b3, b4, b5, 0, b6, b7, b8, 0, 0, 0, 0, 1);

        //    var mValidate = mValidateB * mValidateA;

        //    AreEquivalent(CreateMat3(mValidate.M11, mValidate.M12, mValidate.M13, mValidate.M21, mValidate.M22, mValidate.M23, mValidate.M31, mValidate.M32, mValidate.M33),
        //        m3c);
        //}

        //[DataRow(1, 0, 0, 0,
        //         0, 1, 0, 0,
        //         0, 0, 1, 0,
        //         0, 0, 0, 1,
        //        2, 4, 6, 8,
        //        10, 12, 14, 16,
        //        18, 20, 22, 24,
        //        26, 28, 30, 32)]

        //[DataRow(2, 4, 6, 8,
        //        10, 12, 14, 16,
        //        18, 20, 22, 24,
        //        26, 28, 30, 32,
        //        1, 0, 0, 0,
        //         0, 1, 0, 0,
        //         0, 0, 1, 0,
        //         0, 0, 0, 1)]
        //[DataRow(2, 1, 1, 1,
        //         1, 2, 1, 1,
        //         1, 1, 2, 1,
        //         1, 1, 1, 2,
        //        1, 1, 1, -1,
        //        1, 1, -1, 1,
        //        1, -1, 1, 1,
        //        -1, 1, 1, 1)]
        //[DataRow(2.11f, 3.22f, 4.33f, 5.44f,
        //         6.55f, 7.66f, 8.77f, 9.88f,
        //         10.99f, 11.100f, 12.110f, 13.120f,
        //         14.130f, 15.140f, 16.150f, 17.160f,
        //        18.170f, 19.180f, 20.190f, 21.200f,
        //        22.210f, 23.220f, 24.230f, 25.240f,
        //        26.250f, 27.260f, 28.270f, 29.280f,
        //        30.290f, 31.300f, 32.310f, 33.320f)]
        //[DataTestMethod]
        //public void Matrix4Multiply(float a0, float a1, float a2, float a3, float a4, float a5, float a6, float a7, float a8, float a9, float a10, float a11, float a12, float a13, float a14, float a15,
        //                            float b0, float b1, float b2, float b3, float b4, float b5, float b6, float b7, float b8, float b9, float b10, float b11, float b12, float b13, float b14, float b15)
        //{
        //    Matrix4 m3a = CreateMat4(a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15);
        //    Matrix4 m3b = CreateMat4(b0, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15);

        //    Matrix4 m3c = m3a * m3b;

        //    var mValidateA = new System.Numerics.Matrix4x4(a0, a1, a2, a3, a4, a5, a6, a7, a8, a9, a10, a11, a12, a13, a14, a15);
        //    var mValidateB = new System.Numerics.Matrix4x4(b0, b1, b2, b3, b4, b5, b6, b7, b8, b9, b10, b11, b12, b13, b14, b15);

        //    var mValidate = mValidateB * mValidateA;

        //    AreEquivalent(CreateMat4(mValidate.M11, mValidate.M12, mValidate.M13, mValidate.M14,
        //        mValidate.M21, mValidate.M22, mValidate.M23, mValidate.M24,
        //        mValidate.M31, mValidate.M32, mValidate.M33, mValidate.M34,
        //        mValidate.M41, mValidate.M42, mValidate.M43, mValidate.M44),
        //        m3c);
        //}

        //[DataRow(1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0)]
        //[DataRow(1, 0, 0, 0, 1, 0, 0, 0, 1, 1, 1, 1)]
        //[DataRow(1, 2, 3, 4, 5, 6, 7, 8, 9, 4, 5, 6)]
        //[DataTestMethod]
        //public void Vector3MatrixMultiply(float a, float b, float c, float d, float e, float f, float g, float h, float i,
        //                                    float x, float y, float z)
        //{
        //    Matrix3 m3a = CreateMat3(a, b, c, d, e, f, g, h, i);
        //    Vector3 v3a = CreateVec3(x, y, z);

        //    Vector3 v3b = m3a * v3a;

        //    var mValidate = new System.Numerics.Matrix4x4(a, b, c, 0, d, e, f, 0, g, h, i, 0, 0, 0, 0, 1);
        //    var vValidate = new System.Numerics.Vector4(x, y, z, 1);
        //    var vResult = System.Numerics.Vector4.Transform(vValidate, mValidate);

        //    AreEquivalent(CreateVec3(vResult.X, vResult.Y, vResult.Z), v3b);
        //}

        //[DataRow(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0)]
        //[DataRow(1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 0, 0, 0, 0, 1, 1, 1, 1, 1)]
        //[DataRow(1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 4, 5, 6, 7)]
        //[DataTestMethod]
        //public void Vector4MatrixMultiply(float a, float b, float c, float d, float e, float f, float g, float h, float i, float j, float k, float l, float m, float n, float o, float p,
        //                                    float x, float y, float z, float w)
        //{
        //    var m4a = CreateMat4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        //    var v4a = CreateVec4(x, y, z, w);

        //    Vector4 v4b = m4a * v4a;

        //    var mValidate = new System.Numerics.Matrix4x4(a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p);
        //    var vValidate = new System.Numerics.Vector4(x, y, z, w);
        //    var vResult = System.Numerics.Vector4.Transform(vValidate, mValidate);

        //    AreEquivalent(CreateVec4(vResult.X, vResult.Y, vResult.Z, vResult.W), v4b);
        //}

        [DataRow((byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0xFF, (byte)0, (byte)0xFF, (byte)0)]
        [DataRow((byte)0x12, (byte)0x34, (byte)0x56, (byte)0x78)]
        [DataTestMethod]
        public void ColourConstructor(byte r, byte g, byte b, byte a)
        {
            var c = new Colour(r, g, b, a);

            Colour validate = CreateColour(r, g, b, a);

            Assert.AreEqual<UInt32>(validate.colour, c.colour);
        }

        [DataRow((byte)0x12, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0x12, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0xFF, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0x12, (byte)0x34, (byte)0x56, (byte)0x78)]
        [DataTestMethod]
        public void ColourGetRed(byte r, byte g, byte b, byte a)
        {
            Colour c = CreateColour(r, g, b, a);

            Assert.AreEqual<byte>(r, c.red);
            Colour validate = CreateColour(r, g, b, a);
            Assert.AreEqual(validate.colour, c.colour);
        }

        [DataRow((byte)0, (byte)0x34, (byte)0, (byte)0)]
        [DataRow((byte)0xFF, (byte)0x34, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0xFF, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0x12, (byte)0x34, (byte)0x56, (byte)0x78)]
        [DataTestMethod]
        public void ColourGetGreen(byte r, byte g, byte b, byte a)
        {
            Colour c = CreateColour(r, g, b, a);

            Assert.AreEqual<byte>(g, c.green);
            Colour validate = CreateColour(r, g, b, a);
            Assert.AreEqual(validate.colour, c.colour);
        }

        [DataRow((byte)0, (byte)0, (byte)0x56, (byte)0)]
        [DataRow((byte)0xFF, (byte)0xFF, (byte)0x56, (byte)0xFF)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0xFF, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0x12, (byte)0x34, (byte)0x56, (byte)0x78)]
        [DataTestMethod]
        public void ColourGetBlue(byte r, byte g, byte b, byte a)
        {
            Colour c = CreateColour(r, g, b, a);

            Assert.AreEqual<byte>(b, c.blue);
            Colour validate = CreateColour(r, g, b, a);
            Assert.AreEqual(validate.colour, c.colour);
        }

        [DataRow((byte)0, (byte)0, (byte)0, (byte)0x78)]
        [DataRow((byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0x78)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0xFF, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0x12, (byte)0x34, (byte)0x56, (byte)0x78)]
        [DataTestMethod]
        public void ColourGetAlpha(byte r, byte g, byte b, byte a)
        {
            Colour c = CreateColour(r, g, b, a);

            Assert.AreEqual<byte>(a, c.alpha);
            Colour validate = CreateColour(r, g, b, a);
            Assert.AreEqual(validate.colour, c.colour);
        }

        [DataRow((byte)0x12, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0x12, (byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0x12, (byte)0xFF, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0x12, (byte)0, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0, (byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0, (byte)0xFF, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0, (byte)0, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataTestMethod]
        public void ColourSetRed(byte v, byte r, byte g, byte b, byte a)
        {
            Colour c = CreateColour(r, g, b, a);
            c.red = v;

            Colour validate = CreateColour(v, g, b, a);

            Assert.AreEqual<UInt32>(validate.colour, c.colour);
        }

        [DataRow((byte)0x34, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0x34, (byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0x34, (byte)0, (byte)0xFF, (byte)0, (byte)0)]
        [DataRow((byte)0x34, (byte)0xFF, (byte)0, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0, (byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0, (byte)0, (byte)0xFF, (byte)0, (byte)0)]
        [DataRow((byte)0, (byte)0xFF, (byte)0, (byte)0xFF, (byte)0xFF)]
        [DataTestMethod]
        public void ColourSetGreen(byte v, byte r, byte g, byte b, byte a)
        {
            Colour c = CreateColour(r, g, b, a);
            c.green = v;

            Colour validate = CreateColour(r, v, b, a);

            Assert.AreEqual<UInt32>(validate.colour, c.colour);
        }

        [DataRow((byte)0x56, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0x56, (byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0x56, (byte)0, (byte)0, (byte)0xFF, (byte)0)]
        [DataRow((byte)0x56, (byte)0xFF, (byte)0xFF, (byte)0, (byte)0xFF)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0, (byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0xFF, (byte)0)]
        [DataRow((byte)0, (byte)0xFF, (byte)0xFF, (byte)0, (byte)0xFF)]
        [DataTestMethod]
        public void ColourSetBlue(byte v, byte r, byte g, byte b, byte a)
        {
            Colour c = CreateColour(r, g, b, a);
            c.blue = v;

            Colour validate = CreateColour(r, g, v, a);

            Assert.AreEqual<UInt32>(validate.colour, c.colour);
        }

        [DataRow((byte)0x78, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0x78, (byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0x78, (byte)0, (byte)0, (byte)0, (byte)0xFF)]
        [DataRow((byte)0x78, (byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0, (byte)0)]
        [DataRow((byte)0, (byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0xFF)]
        [DataRow((byte)0, (byte)0, (byte)0, (byte)0, (byte)0xFF)]
        [DataRow((byte)0, (byte)0xFF, (byte)0xFF, (byte)0xFF, (byte)0)]
        [DataTestMethod]
        public void ColourSetAlpha(byte v, byte r, byte g, byte b, byte a)
        {
            Colour c = CreateColour(r, g, b, a);
            c.alpha = v;

            Colour validate = CreateColour(r, g, b, v);

            Assert.AreEqual<UInt32>(validate.colour, c.colour);
        }

        [TestMethod]
        public void ShiftRedToGreen()
        {
            Colour red = CreateColour(94, 0, 0, 0);

            red.colour >>= 8;

            Colour green = CreateColour(0, 94, 0, 0);

            Assert.AreEqual(green.colour, red.colour);
        }

        [DataRow((byte)0xFF, (byte)(0xFF))]
        [DataTestMethod]
        public void TestColorGetter(byte green, byte red)
        {
            Colour c = CreateColour(green, red, 0, 0);

            Assert.AreEqual((byte)0xFF, c.GetRed());
            Assert.AreEqual((byte)0xFF, c.GetGreen());
            Assert.AreEqual(0, c.GetBlue());
            Assert.AreEqual(0, c.GetAlpha());

        }

    }
}
