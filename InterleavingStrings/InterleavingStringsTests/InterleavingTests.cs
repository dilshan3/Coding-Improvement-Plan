using InterleavingStrings;

namespace InterleavingStringsTests
{
    public class InterleavingTests
    {
        [Fact]
        public void EmptyStringTest()
        {
            StringInterleaver stringInterleaver = new StringInterleaver();
            Assert.True(stringInterleaver.AreStringsInterleaving("", "", ""));
        }

        [Fact]
        public void NotInterleavingByLengthTest()
        {
            StringInterleaver stringInterleaver = new StringInterleaver();
            Assert.False(stringInterleaver.AreStringsInterleaving("aasad", "a", "asd"));
        }

        [Fact]
        public void NotInterleavingEqualLengthTest()
        {
            StringInterleaver stringInterleaver = new StringInterleaver();
            Assert.False(stringInterleaver.AreStringsInterleaving("aabcc", "dbbca", "aadbbbaccc"));
        }

        [Fact]
        public void InterleavingNoSimilarCharactersTest()
        {
            StringInterleaver stringInterleaver = new StringInterleaver();
            Assert.True(stringInterleaver.AreStringsInterleaving("abs", "fed", "abfeds"));
        }

        [Fact]
        public void InterleavingWithSimilarCharactersTest()
        {
            StringInterleaver stringInterleaver = new StringInterleaver();
            Assert.True(stringInterleaver.AreStringsInterleaving("aabcc", "dbbca", "aadbbcbcac"));
        }
    }
}