using Xunit;
using System;

namespace Gradebook.Tests
{
    public class Booktest
    {
        /*
        Fact means that when this file is run, 
        the functions which are decorated
        with Fact will be run.
        */
        [Fact]
        public void BookCalculatesStats()
        {
            //arrange
            var book = new Book(" ");
            book.AddGrade(89.1);
            book.AddGrade(90.5);
            book.AddGrade(77.3);

            //act
            var statistic = book.getStatistics();
            double average = statistic.average;
            double highest = statistic.high;
            double lowest = statistic.low;

            //assert
            Assert.Equal(average, 85.6, 1);
            Assert.Equal(highest, 90.5, 1);
            Assert.Equal(lowest, 77.3, 1);

        }

    }
}