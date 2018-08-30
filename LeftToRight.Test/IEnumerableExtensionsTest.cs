using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Prototypist.LeftToRight;

namespace Prototypist.LeftToRight.Test
{
    public class IEnumerableExtensions
    {
        #region LargestOrThrow

        [Fact]
        public void LargestOrThrowSimple()
        {
            var list = new List<int>() { 5, 2, 3, 1, 10, 23 };

            Assert.Equal(23, list.LargestOrThrow(x => x));
        }

        [Fact]
        public void LargestOrThrowFlip()
        {
            var list = new List<int>() { 5, 2, 3, 1, 10, 23 };

            Assert.Equal(1, list.LargestOrThrow(x => -x));
        }

        [Fact]
        public void LargestOrThrowNull()
        {
            List<int> list = null;

            Assert.Throws<ArgumentNullException>(()=>list.LargestOrThrow(x => x));
        }

        [Fact]
        public void LargestOrThrowEmpty()
        {
            var list = new List<int>();

            Assert.Throws<InvalidOperationException>(() => list.LargestOrThrow(x => x));
        }

        #endregion

        #region LargestOrFallback
        
        [Fact]
        public void LargestOrFallbackSimple()
        {
            var list = new List<int>() { 5, 2, 3, 1, 10, 23 };

            Assert.Equal(23, list.LargestOrFallback(100, x => x));
        }

        [Fact]
        public void LargestOrFallbackFlip()
        {
            var list = new List<int>() { 5, 2, 3, 1, 10, 23 };

            Assert.Equal(1, list.LargestOrFallback(100, x => -x));
        }

        [Fact]
        public void LargestOrFallbackNull()
        {
            List<int> list = null;

            Assert.Throws<ArgumentNullException>(() => list.LargestOrFallback(100, x => x));
        }

        [Fact]
        public void LargestOrFallbackEmpty()
        {
            var list = new List<int>();

            Assert.Equal(100, list.LargestOrFallback(100, x => x));
        }

        #endregion

        #region SmallestOrThrow
        
        [Fact]
        public void SmallestOrThrowSimple()
        {
            var list = new List<int>() { 5, 2, 3, 1, 10, 23 };

            Assert.Equal(1, list.SmallestOrThrow(x => x));
        }

        [Fact]
        public void SmallestOrThrowFlip()
        {
            var list = new List<int>() { 5, 2, 3, 1, 10, 23 };

            Assert.Equal(23, list.SmallestOrThrow(x => -x));
        }

        [Fact]
        public void SmallestOrThrowNull()
        {
            List<int> list = null;

            Assert.Throws<ArgumentNullException>(() => list.SmallestOrThrow(x => x));
        }

        [Fact]
        public void SmallestOrThrowEmpty()
        {
            var list = new List<int>();

            Assert.Throws<InvalidOperationException>(() => list.SmallestOrThrow(x => x));
        }

        #endregion

        #region SmallestOrFallback

        [Fact]
        public void SmallestOrFallbackSimple()
        {
            var list = new List<int>() { 5, 2, 3, 1, 10, 23 };

            Assert.Equal(1, list.SmallestOrFallback(100, x => x));
        }

        [Fact]
        public void SmallestOrFallbackFlip()
        {
            var list = new List<int>() { 5, 2, 3, 1, 10, 23 };

            Assert.Equal(23, list.SmallestOrFallback(100, x => -x));
        }

        [Fact]
        public void SmallestOrFallbackNull()
        {
            List<int> list = null;

            Assert.Throws<ArgumentNullException>(() => list.SmallestOrFallback(100, x => x));
        }

        [Fact]
        public void SmallestOrFallbackEmpty()
        {
            var list = new List<int>();

            Assert.Equal(100, list.SmallestOrFallback(100, x => x));
        }

        #endregion

        #region SetEqual

        [Fact]
        public void SetEqualEmpty()
        {
            var list1 = new List<int>();
            var list2 = new List<int>();

            Assert.True(list1.SetEqual(list2));
        }

        [Fact]
        public void SetEqualTrue()
        {
            var list1 = new List<int>() { 1,2,3,4,5};
            var list2 = new List<int>() { 5,4,3,2,1};

            Assert.True(list1.SetEqual(list2));
        }


        [Fact]
        public void SetEqualFalse()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5 };
            var list2 = new List<int>() { 5, 4, 3, 2, 1, 1 };

            Assert.False(list1.SetEqual(list2));
        }

        [Fact]
        public void SetEqualSecondNull()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = null;

            Assert.Throws<ArgumentNullException>(() => list1.SetEqual(list2));
        }

        [Fact]
        public void SetEqualFirstNull()
        {
            List<int> list1 = null;
            var list2 = new List<int>() { 1, 2, 3, 4, 5 };

            Assert.Throws<ArgumentNullException>(() => list1.SetEqual(list2));
        }

        [Fact]
        public void SetEqualBothNull()
        {
            List<int> list1 = null;
            List<int> list2 = null;

            Assert.Throws<ArgumentNullException>(()=>list1.SetEqual(list2));
        }

        #endregion

        #region NullSafeSetEqual

        [Fact]
        public void NullSafeSetEqualEmpty()
        {
            var list1 = new List<int>();
            var list2 = new List<int>();

            Assert.True(list1.NullSafeSetEqual(list2));
        }

        [Fact]
        public void NullSafeSetEqualTrue()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5 };
            var list2 = new List<int>() { 5, 4, 3, 2, 1 };

            Assert.True(list1.NullSafeSetEqual(list2));
        }


        [Fact]
        public void NullSafeSetEqualFalse()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5 };
            var list2 = new List<int>() { 5, 4, 3, 2, 1, 1 };

            Assert.False(list1.NullSafeSetEqual(list2));
        }

        [Fact]
        public void NullSafeSetEqualFirstNull()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = null;

            Assert.False(list1.NullSafeSetEqual(list2));
        }

        [Fact]
        public void NullSafeSetEqualSecondNull()
        {
            List<int> list1 = null;
            var list2 = new List<int>() { 1, 2, 3, 4, 5 };

            Assert.False(list1.NullSafeSetEqual(list2));
        }

        [Fact]
        public void NullSafeSetEqualBothNull()
        {
            List<int> list1 = null;
            List<int> list2 = null;

            Assert.True(list1.NullSafeSetEqual(list2));
        }

        #endregion


        #region NullSafeSequenceEqual

        [Fact]
        public void NullSafeSequenceEqualEmpty()
        {
            var list1 = new List<int>();
            var list2 = new List<int>();

            Assert.True(list1.NullSafeSequenceEqual(list2));
        }

        [Fact]
        public void NullSafeSequenceEqualTrue()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5 };
            var list2 = new List<int>() { 1,2,3,4,5 };

            Assert.True(list1.NullSafeSequenceEqual(list2));
        }


        [Fact]
        public void NullSafeSequenceEqualFalse()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5 };
            var list2 = new List<int>() { 5, 4, 3, 2, 1 };

            Assert.False(list1.NullSafeSequenceEqual(list2));
        }

        [Fact]
        public void NullSafeSequenceEqualFirstNull()
        {
            var list1 = new List<int>() { 1, 2, 3, 4, 5 };
            List<int> list2 = null;

            Assert.False(list1.NullSafeSequenceEqual(list2));
        }


        [Fact]
        public void NullSafeSequenceEqualSecondNull()
        {
            List<int> list1 = null;
            var list2 = new List<int>() { 1, 2, 3, 4, 5 };

            Assert.False(list1.NullSafeSequenceEqual(list2));
        }

        [Fact]
        public void NullSafeSequenceEqualBothNull()
        {
            List<int> list1 = null;
            List<int> list2 = null;

            Assert.True(list1.NullSafeSequenceEqual(list2));
        }

        #endregion
    }
}