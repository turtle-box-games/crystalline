using System;
using NUnit.Framework;

namespace Crystalline.Test
{
    [TestFixture(TestOf = typeof(Range))]
    public class RangeTests
    {
        [Test(Description = "Test that Start property is set to the correct value.")]
        public void StartTest(
            [Random(-500, 500, 5)] int start)
        {
            var range = new Range(start, start + 5);
            Assert.That(range.Start, Is.EqualTo(start));
        }

        [Test(Description = "Test that End property is set to the correct value.")]
        public void EndTest(
            [Random(-500, 500, 5)] int end)
        {
            var range = new Range(end - 5, end);
            Assert.That(range.End, Is.EqualTo(end));
        }

        [Test(Description = "Test that Count property returns the difference between End and Start.")]
        public void CountTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var range = new Range(start, start + count);
            Assert.That(range.Count, Is.EqualTo(count));
        }

        [Test(Description = "Test that an exception is raised if End is before Start.")]
        public void EndBeforeStartTest(
            [Random(-500, 500, 2)] int start,
            [Values(1, 2, 2)]     int before)
        {
            Assert.That(() => { new Range(start, start - before); }, Throws.ArgumentException);
        }

        [Test(Description = "Test that an exception is raised if Start and End are the same.")]
        public void SameStartEndTest(
            [Random(-500, 500, 5)] int start)
        {
            Assert.That(() => { new Range(start, start); }, Throws.ArgumentException);
        }

        [Test(Description = "Test that a value can be found within the range when it is inside.")]
        public void ContainsValueTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var value = new Random().Next(start, end);
            var range = new Range(start, end);
            Assert.That(range.Contains(value), Is.True);
        }

        [Test(Description = "Test that a value can't be found in the range when it is outside.")]
        public void DoesNotContainValueBeforeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(1, 50, 2)]     int offset)
        {
            var end   = start + count;
            var value = start - offset;
            var range = new Range(start, end);
            Assert.That(range.Contains(value), Is.False);
        }

        [Test(Description = "Test that a value can't be found in the range when it is outside.")]
        public void DoesNotContainValueAfterTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(0, 50, 2)]     int offset)
        {
            var end   = start + count;
            var value = end + offset;
            var range = new Range(start, end);
            Assert.That(range.Contains(value), Is.False);
        }

        [Test(Description = "Test that the end value is exclusive and is considered outside the range.")]
        public void DoesNotContainEndTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            Assert.That(range.Contains(end), Is.False);
        }
    }
}