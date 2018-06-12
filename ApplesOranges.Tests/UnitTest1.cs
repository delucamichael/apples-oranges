using System;
using System.Collections.Generic;
using Xunit;

namespace ApplesOranges.Tests
{
    public class UnitTest1
    {
        [Theory]
        [InlineData(5)]
        [InlineData(3)]
        public void HouseHasCorrectStartPosition(int start)
        {
            var house = new House(start, 8);
            Assert.Equal(start,house.Start);
        }

        [Theory]
        [InlineData(9)]
        [InlineData(5)]
        public void HouseHasCorrectEndPosition(int end)
        {
            var house = new House(1,end);
            Assert.Equal(end,house.End);
        }

        [Theory]
        [InlineData(7)]
        [InlineData(2)]
        [InlineData(1)]
        public void FirstTreeHasCorrectPosition(int pos)
        {
            var tree = new Tree(pos);
            Assert.Equal(pos, tree.Position);
        }

        [Theory]
        [InlineData(5)]
        [InlineData(-9)]
        [InlineData(120)]
        public void FirstAppleHasCorrectDistance(int dist)
        {
            var apple = new Apple(dist);
            Assert.Equal(dist, apple.Distance);
        }

        [Fact]
        public void AppleWithinBoundsOfHouse()
        {
            var apple = new Apple(3);
            Assert.InRange(3,1,5);
        }
    }

    public class House
    {        
        public House(int start, int end)
        {
            Start = start;
            End = end;
        }

        public int Start { get; }
        public int End { get;}
    }

    public class Tree
    {
        public Tree(int position)
        { Position = position;
        }
        public int Position { get; }
    }
    public class Apple
    {
        public Apple(int distance)
        {
            Distance = distance;
        }
        public int Distance { get; }
       
    }

}
