using NUnit.Framework;

namespace Arrays.Test
{
    public class ArrayClassTests
    { 
        [TestCase(new int[] { 3, 2, 1 }, new int[] { 1 })]
        [TestCase(new int[] { 1, 2, 3 }, new int[] { 1 })]
        [TestCase(new int[] { 2, 3, 4, 5, 6, 7, 8, 9, 1 }, new int[] { 1 })]
        [TestCase(new int[] { }, new int[] { })]
        [TestCase(new int[] { 0 }, new int[] { 0 })]
        [TestCase(new int[] { 0, 0, 0, 0 }, new int[] { 0 })]
        public void FindMinTest(int[] array, int expected)
        {
            int actual = ArrayClass.FindMin(array);
            Assert.AreEqual(expected, actual);
        }
    }
}