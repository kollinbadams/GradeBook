using System;
using Xunit;

namespace GradeBook.Tests
{
    public class GradeBookTests
    {
        [Fact]
        public void BookCalculatesAverageGrade()
        {
            //arrange
            var book = new Book("Test GradeBook");
            book.AddGrade(69);

            //act
            var statistics = book.GetStatistics();

            //assert
            Assert.Equal(69, statistics.high);
            Assert.Equal(69, statistics.low);
            Assert.Equal(69, statistics.average);
        }
    }
}
