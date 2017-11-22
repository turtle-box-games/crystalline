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

        [Test(Description = "Test that a smaller range can be found inside a larger range.")]
        public void ContainsRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(1, 10, 2)]     int inner)
        {
            // [--range--{--other--}--]
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start + inner, end - inner);
            Assert.That(range.Contains(other), Is.True);
        }

        [Test(Description = "Test that a smaller range can't contain a larger range.")]
        public void DoesNotContainLargerRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(1, 10, 2)]     int outer)
        {
            // {--other--[--range--]--}
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start - outer, end + outer);
            Assert.That(range.Contains(other), Is.False);
        }

        [Test(Description = "Test that an completely exclusive prior range is not found inside another range.")]
        public void DoesNotContainBeforeRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(0, 50, 2)]     int outside)
        {
            // {--other--}---[--range--]
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start - count - outside, start - outside);
            Assert.That(range.Contains(other), Is.False);
        }

        [Test(Description = "Test that an completely exclusive following range is not found inside another range.")]
        public void DoesNotContainAfterRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(0, 50, 2)]     int outside)
        {
            // [--range--]--{--other--}
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(end + outside, end + outside + count);
            Assert.That(range.Contains(other), Is.False);
        }

        [Test(Description = "Test that a prior overlapping range is not considered being contained.")]
        public void DoesNotContainOverlapBeforeRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(1, 25, 2)]     int offset)
        {
            // {--other--[--}--range--]
            var end = start + count;
            var range = new Range(start, end);
            var other = new Range(start - offset, end - offset);
            Assert.That(range.Contains(other), Is.False);
        }

        [Test(Description = "Test that a following overlapping range is not considered being contained.")]
        public void DoesNotContainOverlapAfterRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(1, 25, 2)]     int offset)
        {
            // [--range--{--other--]--}
            var end = start + count;
            var range = new Range(start, end);
            var other = new Range(start + offset, end + offset);
            Assert.That(range.Contains(other), Is.False);
        }

        [Test(Description = "Test that a range can be contained in itself.")]
        public void ContainsSameRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            Assert.That(range.Contains(range), Is.True);
        }

        [Test(Description = "Test that a smaller range is considered to overlap a larger range.")]
        public void OverlapsSmallerRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(1, 10, 2)]     int inner)
        {
            // [--range--{--other--}--]
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start + inner, end - inner);
            Assert.That(range.Overlaps(other), Is.True);
        }

        [Test(Description = "Test that a larger range is considered to overlap a smaller range.")]
        public void OverlapsLargerRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(1, 10, 2)]     int inner)
        {
            // {--other--[--range--]--}
            var end   = start + count;
            var range = new Range(start + inner, end - inner);
            var other = new Range(start, end);
            Assert.That(range.Overlaps(other), Is.True);
        }

        [Test(Description = "Test that an completely exclusive prior range does not overlap the range.")]
        public void DoesNotOverlapBeforeRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(0, 50, 2)]     int outside)
        {
            // {--other--}---[--range--]
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start - count - outside, start - outside);
            Assert.That(range.Overlaps(other), Is.False);
        }

        [Test(Description = "Test that an completely exclusive following range does not overlap the range.")]
        public void DoesNotOverlapAfterRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(0, 50, 2)]     int outside)
        {
            // [--range--]--{--other--}
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(end + outside, end + outside + count);
            Assert.That(range.Overlaps(other), Is.False);
        }

        [Test(Description = "Test that a prior overlapping range is considered overlapping.")]
        public void OverlapBeforeRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(1, 25, 2)]     int offset)
        {
            // {--other--[--}--range--]
            var end = start + count;
            var range = new Range(start, end);
            var other = new Range(start - offset, end - offset);
            Assert.That(range.Overlaps(other), Is.True);
        }

        [Test(Description = "Test that a following overlapping range is considered overlapping.")]
        public void OverlapAfterRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(1, 25, 2)]     int offset)
        {
            // [--range--{--other--]--}
            var end = start + count;
            var range = new Range(start, end);
            var other = new Range(start + offset, end + offset);
            Assert.That(range.Overlaps(other), Is.True);
        }

        [Test(Description = "Test that a range can overlap itself.")]
        public void OverlapsSameRangeTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            Assert.That(range.Overlaps(range), Is.True);
        }

        [Test(Description = "Test that start of another range at the end of the current range is not considered overlapping.")]
        public void DoesNotOverlapStartEndTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            // [--range--]{--other--}
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(end, end + count);
            Assert.That(range.Overlaps(other), Is.False);
        }

        [Test(Description = "Test that end of another range at the start of the current range is not considered overlapping.")]
        public void DoesNotOverlapEndStartTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            // {--other--}[--range--]
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start - count, start);
            Assert.That(range.Overlaps(other), Is.False);
        }

        [Test(Description = "Test that the enumerator can iterate through the entire range.")]
        public void EnumeratorTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            using (var enumerator = range.GetEnumerator())
            {
                Assert.Multiple(() =>
                {
                    for (var i = start; i < end; ++i)
                    {
                        Assert.That(enumerator.MoveNext(), Is.True);
                        Assert.That(enumerator.Current, Is.EqualTo(i));
                    }
                    Assert.That(enumerator.MoveNext(), Is.False);
                });
            }
        }

        [Test(Description = "Test that the enumerator can iterate through the entire range in custom increments.")]
        public void StepEnumeratorTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count,
            [Random(2, 5, 2)]      int step)
        {
            var end   = start + count;
            var range = new Range(start, end);
            using (var enumerator = range.GetEnumerator(step))
            {
                Assert.Multiple(() =>
                {
                    for (var i = start; i < end; i += step)
                    {
                        Assert.That(enumerator.MoveNext(), Is.True);
                        Assert.That(enumerator.Current, Is.EqualTo(i));
                    }
                    Assert.That(enumerator.MoveNext(), Is.False);
                });
            }
        }

        [Test(Description = "Test that the enumerator can properly reset to the start of the range.")]
        public void ResetEnumeratorTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            using (var enumerator = range.GetEnumerator())
            {
                for (var i = 0; i < count / 2; ++i)
                    enumerator.MoveNext();
                enumerator.Reset();
                enumerator.MoveNext();
                Assert.That(enumerator.Current, Is.EqualTo(start));
            }
        }

        [Test(Description = "Test that negative and zero are rejected as enumerator step values.")]
        public void BadStepEnumeratorTest(
            [Random(-500, 500, 1)] int start,
            [Random(25, 50, 1)]    int count,
            [Values(-5, -1, 0)]    int step)
        {
            var end = start + count;
            var range = new Range(start, end);
            Assert.That(() =>
            {
                range.GetEnumerator(step);
            }, Throws.InstanceOf<ArgumentOutOfRangeException>());
        }

        [Test(Description = "Test that two identical ranges are considered equal.")]
        public void SameRangeEqualsTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start, end);
            Assert.That(range.Equals(other), Is.True);
        }

        [Test(Description = "Test that two ranges, one with a different end, are considered different.")]
        public void SameStartDifferentEndEqualsTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start, end + 5);
            Assert.That(range.Equals(other), Is.False);
        }

        [Test(Description = "Test that two ranges, one with a different start, are considered different.")]
        public void SameEndDifferentStartEqualsTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start + 5, end);
            Assert.That(range.Equals(other), Is.False);
        }

        [Test(Description = "Test that two completely different ranges are not considered equal.")]
        public void DifferentRangeEqualsTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start + 5, end + 5);
            Assert.That(range.Equals(other), Is.False);
        }

        [Test(Description = "Test that a range is considered not equal to null.")]
        public void NullEqualsTest(
            [Random(-500, 500, 1)] int start,
            [Random(25, 50, 1)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            Assert.That(range.Equals(null), Is.False);
        }

        [Test(Description = "Test that a range is considered not equal to a different object type.")]
        public void DifferentTypeEqualsTest(
            [Random(-500, 500, 1)] int start,
            [Random(25, 50, 1)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            Assert.That(range.Equals("foobar"), Is.False);
        }

        [Test(Description = "Test that two identical ranges are considered equal with the equality operator.")]
        public void SameRangeEqualityTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var left  = new Range(start, end);
            var right = new Range(start, end);
            Assert.That(left == right, Is.True);
        }

        [Test(Description = "Test that two ranges, one with a different end, are considered different with the equality operator.")]
        public void SameStartDifferentEndEqualityTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var left  = new Range(start, end);
            var right = new Range(start, end + 5);
            Assert.That(left == right, Is.False);
        }

        [Test(Description = "Test that two ranges, one with a different start, are considered different with the equality operator.")]
        public void SameEndDifferentStartEqualityTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var left  = new Range(start, end);
            var right = new Range(start + 5, end);
            Assert.That(left == right, Is.False);
        }

        [Test(Description = "Test that two completely different ranges are not considered equal with the equality operator.")]
        public void DifferentRangeEqualityTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var left  = new Range(start, end);
            var right = new Range(start + 5, end + 5);
            Assert.That(left == right, Is.False);
        }

        [Test(Description = "Test that two identical ranges are considered equal with the inequality operator.")]
        public void SameRangeInequalityTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var left  = new Range(start, end);
            var right = new Range(start, end);
            Assert.That(left != right, Is.False);
        }

        [Test(Description = "Test that two ranges, one with a different end, are considered different with the inequality operator.")]
        public void SameStartDifferentEndInequalityTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var left  = new Range(start, end);
            var right = new Range(start, end + 5);
            Assert.That(left != right, Is.True);
        }

        [Test(Description = "Test that two ranges, one with a different start, are considered different with the inequality operator.")]
        public void SameEndDifferentStartInequalityTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var left  = new Range(start, end);
            var right = new Range(start + 5, end);
            Assert.That(left != right, Is.True);
        }

        [Test(Description = "Test that two completely different ranges are not considered equal with the inequality operator.")]
        public void DifferentRangeInequalityTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var left  = new Range(start, end);
            var right = new Range(start + 5, end + 5);
            Assert.That(left != right, Is.True);
        }

        [Test(Description = "Test that two identical ranges generate the same hash code.")]
        public void IdenticalRangeHashTest(
            [Random(-500, 500, 2)] int start,
            [Random(25, 50, 2)]    int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start, end);
            Assert.That(range.GetHashCode(), Is.EqualTo(other.GetHashCode()));
        }

        [Test(Description = "Test that two different ranges generate different hash codes.")]
        public void DifferentRangeHashTest(
            [Values(1, 2, 3)]    int start,
            [Values(10, 20, 30)] int count)
        {
            var end   = start + count;
            var range = new Range(start, end);
            var other = new Range(start + 5, end + 5);
            Assert.That(range.GetHashCode(), Is.Not.EqualTo(other.GetHashCode()));
        }
    }
}