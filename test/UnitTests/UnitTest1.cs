using System;
using FluentAssertions;
using MathNet.Numerics.LinearAlgebra;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
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
        public void TestAppendThrowException()
        {
            // Arrange
            Vector<double> leftVector = null;
            Vector<double> righVector = Vector<double>.Build.Dense(4, 2.0);

            // Act
            var vector = VectorOperations.VectorOperations.Append(leftVector, righVector);

            // Assert
            vector.Should().Thr
        }
    }
}