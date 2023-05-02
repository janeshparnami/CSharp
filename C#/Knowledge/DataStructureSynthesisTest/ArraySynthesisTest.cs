namespace DataStructureSynthesisTest
{
    using DataStructuresSynthesis;
    [TestClass]
    public class ArraySynthesisTest
    {
        [TestMethod]
        public void ArrayDiffTest()
        {
            CollectionAssert.AreEqual(new int[] { }, ArraySynthesis.ArrayDiff(new int[] { }, new int[] { }));
            CollectionAssert.AreEqual(new int[] {2,3}, ArraySynthesis.ArrayDiff(new int[] {1,2,3 }, new int[] {1 }));
            CollectionAssert.AreEqual(new int[] { 1, 3 }, ArraySynthesis.ArrayDiff(new int[] { 1, 2,2,2,2, 3 }, new int[] { 2 }));
            CollectionAssert.AreEqual(new int[] { 1, 2, 2, 2, 2, 3 }, ArraySynthesis.ArrayDiff(new int[] { 1, 2, 2, 2, 2, 3 }, new int[] { 4 }));
            CollectionAssert.AreEqual(new int[] { 1, 2, 2, 2, 2, 3 }, ArraySynthesis.ArrayDiff(new int[] { 1, 2, 2, 2, 2, 3 }, new int[] { }));
            CollectionAssert.AreEqual(new int[] { }, ArraySynthesis.ArrayDiff(new int[] { }, new int[] {1,2,3 }));
            CollectionAssert.AreEqual(Array.Empty<int>(), ArraySynthesis.ArrayDiff(new int[] { }, new int[] { 1, 2, 3 }));


        }
    }
}