using MarsRove.Models.Concrete;
using MarsRove.Enums;
using System;
using Xunit;

namespace TestRover
{
    public class UnitTest1
    {
        [Fact]
        public void TurnLeftTest()
        {
            Rover testRover = new Rover("2 2 N");
            testRover.TurnLeft();
            Assert.Equal("S",testRover.direction);   
        }
        [Fact]
        public void TurnRightTest()
        {
            Rover testRover = new Rover("2 2 N");
            testRover.TurnRight();
            Assert.Equal("E", testRover.direction);
        }
        
       
    }
}
