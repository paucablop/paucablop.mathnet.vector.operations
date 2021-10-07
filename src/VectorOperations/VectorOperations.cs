using System;
using MathNet.Numerics.LinearAlgebra;

namespace VectorOperations
{
    /// <summary>
    /// Operations for Vectors in mathnet-umerics
    /// </summary>
    public static class VectorOperations
    {
        /// <summary>
        /// Concatenates a vector (right) on the right side of a given vector (left)
        /// </summary>
        /// <param name="left"> This vector is appended on the left side</param>
        /// <param name="right"> This vector is appended on the right side</param>
        public static Vector<T> Append<T>(Vector<T> left, Vector<T> right) where T : struct, IEquatable<T>, IFormattable
        {
            if (left == null)
            {
                throw new ArgumentNullException(nameof(left));
            }

            if (right == null)
            {
                throw new ArgumentNullException(nameof(right));
            }

            Vector<T> vector = Vector<T>.Build.SameAs(left, left.Count + right.Count);
            left.Storage.CopySubVectorTo(vector.Storage, 0, 0, left.Count, ExistingData.AssumeZeros);
            right.Storage.CopySubVectorTo(vector.Storage, 0, left.Count, right.Count, ExistingData.AssumeZeros);
            return vector;
        }
    }
}