using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using Prototypist.LeftToRight;

namespace Prototypist.Toolbox.Test
{
    public class BoolExtensions
    {
        [Fact]
        public void IfFalse() {
            var wasRun = false;

            false.If(() =>
            {
                wasRun = true;
            });

            Assert.False(wasRun);
        }

        [Fact]
        public void IfTrue()
        {
            var wasRun = false;

            true.If(() =>
            {
                wasRun = true;
            });

            Assert.True(wasRun);
        }

        [Fact]
        public void ElseFalse()
        {
            var wasRun = false;

            false.Else(() =>
            {
                wasRun = true;
            });

            Assert.True(wasRun);
        }

        [Fact]
        public void ElseTrue()
        {
            var wasRun = false;

            true.Else(() =>
            {
                wasRun = true;
            });

            Assert.False(wasRun);
        }
		
        [Fact]
        public void NotTrue()
        {
            Assert.False(true.Not());
        }
		
        [Fact]
        public void NotFalse()
        {
            Assert.True(false.Not());
        }

    }
}
