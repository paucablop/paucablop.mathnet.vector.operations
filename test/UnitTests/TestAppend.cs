using System;
using MathNet.Numerics.LinearAlgebra;
using Xunit;

namespace UnitTests
{
    public class TestAppend
    {
        [Fact]
        public void TestAppendShouldAppend()
        {
            // Arrange
            Vector<double> leftVector = Vector<double>.Build.Dense(5, 1.0);
            Vector<double> righVector = Vector<double>.Build.Dense(4, 2.0);

            // Act
            var vector = VectorOperations.VectorOperations.Append(leftVector, righVector);

            // Assert
            Assert.IsAssignableFrom<Vector<double>>(vector);
            Assert.Equal(9, vector.Count);
            Assert.Equal(1.0, vector[0]);
            Assert.Equal(2.0, vector[5]);
        }

        [Fact]
        public void TestAppendThrowExceptions()
        {
            // Arrange
            Vector<double> leftVector = Vector<double>.Build.Dense(5, 1.0);
            Vector<double> righVector = Vector<double>.Build.Dense(4, 2.0);

            // Act and Assert
            Assert.Throws<ArgumentNullException>(() => VectorOperations.VectorOperations.Append(null, righVector));
            Assert.Throws<ArgumentNullException>(() => VectorOperations.VectorOperations.Append(leftVector, null));

        }
    }
}