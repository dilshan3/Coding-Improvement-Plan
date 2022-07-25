using DuplicateFinder;

namespace DuplicateFinderTests
{
    public class FinderTests
    {
        [Fact]
        public void TestDuplicateExist()
        {
            var finder = new Finder();
            int[] nums = { 1, 3, 4, 2, 2 };

            Assert.Equal(2, finder.GetDuplicate(nums));
        }

        [Fact]
        public void TestDuplicateNotExist()
        {
            var finder = new Finder();
            int[] nums = { 1, 2, 3, 4, 5 };

            Assert.Equal(0, finder.GetDuplicate(nums));
        }
    }
}