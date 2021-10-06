using System;
using MathNet.Numerics.LinearAlgebra;

namespace VectorOperations
{
    public class VectorOperations
    {
        public static Vector<T> Append<T>(Vector<T> left, Vector<T> right) where T : struct, IEquatable<T>, IFormattable
        {
            Vector<T> vector = Vector<T>.Build.SameAs(left, left.Count + right.Count);
            left.Storage.CopySubVectorTo(vector.Storage, 0, 0, left.Count, ExistingData.AssumeZeros);
            right.Storage.CopySubVectorTo(vector.Storage, 0, left.Count, right.Count, ExistingData.AssumeZeros);
            return vector;
        }
    }
}