using System;
using Xunit;

namespace LoggingKata.Test
{
    public class TacoParserTests
    {
        [Fact]
        public void ShouldDoSomething()
        {
            // TODO: Complete Something, if anything

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = tacoParser.Parse("34.073638, -84.677017, Taco Bell Acwort...");

            //Assert
            Assert.NotNull(actual);

        }

        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", -84.677017)]
        [InlineData("34.087508,-84.575512,Taco Bell Acworth", -84.575512)]
        [InlineData("33.671982,-85.826674,Taco Bell Annisto", -85.826674)]
        [InlineData("33.858498,-84.60189,Taco Bell Austel", -84.60189)]
        public void ShouldParseLongitude(string line, double expected)
        {
            // TODO: Complete - "line" represents input data we will Parse to
            //       extract the Longitude.  Your .csv file will have many of these lines,
            //       each representing a TacoBell location

            //Arrange
            var tacoParser = new TacoParser();

            //Act
            var actual = (tacoParser.Parse(line));

            //Assert
            Assert.Equal(expected, actual.Location.Longitude);
        }


        //TODO: Create a test ShouldParseLatitude
        [Theory]
        [InlineData("34.073638, -84.677017, Taco Bell Acwort...", 34.073638)]
        [InlineData("34.087508,-84.575512,Taco Bell Acworth", 34.087508)]
        [InlineData("33.671982,-85.826674,Taco Bell Annisto", 33.671982)]
        [InlineData("30.903723,-84.556037,Taco Bell Bainbridg", 30.903723)]

        public void ShouldParseLatitude(string line, double expected)
        { 
            var tacoParser = new TacoParser();

            var actual = tacoParser.Parse(line);

            Assert.Equal(expected, actual.Location.Latitude);
        }
    }
}
