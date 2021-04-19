using System;
using Xunit;
using Xunit.Abstractions;

namespace ILGPU.Tests
{
    public abstract class ClassValues : TestBase
    {
        protected ClassValues(
            ITestOutputHelper output,
            TestContext testContext)
            : base(output, testContext)
        { }

        private static void ThisIndependentLambdaKernel(
            Index1D index, ArrayView<int> data, Func<int, int> op)
        {
            data[index] = op(1);
        }

        private static int Inc(int v) => v + 1;
        [Fact]
        public void ThisIndependentLambda()
        {
            Action<Index1D, ArrayView<int>> kernel =
                (i, v) => ThisIndependentLambdaKernel(i, v, Inc);

            using var output = Accelerator.Allocate1D<int>(1);
            Execute(kernel.Method, new Index1D(1), output.View);

            var expected = new [] { 2 };
            Verify(output.View, expected);
        }
    }
}

#pragma warning restore xUnit1026 // Theory methods should use all of their parameters
