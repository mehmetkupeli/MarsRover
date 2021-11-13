using MarsRove.Models.Concrete;
using MarsRove.Enums;
using System;
using Xunit;

namespace TestRover
{
    public class UnitTest1
    {
        [Fact]
        public void SpinLeft()
        {
            Ground testGround = new Ground(new Position(5, 5));
            Rover testRover = new Rover(testGround, new Position(1, 1), Directions.N);
            testRover.Process("LLLL");
            string testResult = testRover.ToString();
            Assert.Equal("1 1 N", testResult);
        }

        [Fact]
        public void SpinRight()
        {
            Ground testGround = new Ground(new Position(5, 5));
            Rover testRover = new Rover(testGround, new Position(1, 1), Directions.N);
            testRover.Process("RRRR");
            string testResult = testRover.ToString();
            Assert.Equal("1 1 N", testResult);
        }

        [Fact]
        public void SpinMove()
        {
            Ground testGround = new Ground(new Position(5, 5));
            Rover testRover = new Rover(testGround, new Position(1, 1), Directions.N);
            testRover.Process("MMMM");
            string testResult = testRover.ToString();
            Assert.Equal("1 5 N", testResult);
        }
    }
}
