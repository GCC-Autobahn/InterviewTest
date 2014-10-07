using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ConsoleApplication2
{
    public class Question3
    {
        //In implementing this method, I assumed that the list of numbers that you passed in is in ascending order. This is bad!
        //Write a failing unit test to confirm that, if the numbers are not in order, this method does not return the largest number in the list.
        //Don't fix the method! That's for other people to worry about...
        public float GetLargestNumberInList(IList<int> numbers)
        {
            return numbers.Last();
        }
    }

    [TestFixture]
    public class Question3Tests
    {
        [Test]
        public void ShouldReturnBiggestNumberEvenIfListOfNumbersIsNotOrdered()
        {
            //Implement me!!
        }
    }
}
