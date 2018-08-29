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

    }
}