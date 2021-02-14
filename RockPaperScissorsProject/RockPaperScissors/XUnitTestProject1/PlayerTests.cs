using System;
using Xunit;
using RockPaperScissors;

namespace RockPaperScissors.Tests
{
    public class PlayerTests
    {
        //[Fact]
        //public void Player_IsValidAnswer_ShouldReturnTrueforValidAnswers()
        //{
        //    //Arrange
        //    //bool test = true;
        //    //Act
        //    Player one = new Player();
        //    bool answer = one.IsValidAnswer("rOck");
        //    //Assert
        //    Assert.True(answer);
        //}
        [Theory]
        [InlineData("Rock")]
        [InlineData("Roc")]
        [InlineData("rOck")]
        public void Player_IsValidAnswer_ShouldReturnTrueforValidAnswers(string value)
        {
            //Arrange
            //bool test = true;
            //Act
            Player one = new Player();
            bool answer = one.IsValidAnswer(value);
            //Assert
            Assert.True(answer);
        }
    }
}
