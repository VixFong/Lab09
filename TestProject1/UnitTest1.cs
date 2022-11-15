using StudentServiceLib;
namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CheckSroceInRange()
        {
            Student s = new Student();
            s.Score = 9;
            Assert.AreEqual(9, s.Score);
        }

        [TestMethod]
        public void CheckScoreOutOfRange10()
        {
            Student s = new Student();
            s.Score = 11;
            Assert.AreEqual(11, s.Score);
        }
        [TestMethod]
        public void CheckSroceOutOfRange0()
        {
            Student s = new Student();
            s.Score = -3;
            Assert.AreEqual(-3, s.Score);
        }

        [TestMethod]
        public void SroceA_When9()
        {
            Student s = new Student();
            s.Score = 9;
            char letter = s.getLetterScore();
            Assert.AreEqual('A', letter);
        }
        [TestMethod]
        public void SroceB_When7()
        {
            Student s = new Student();
            s.Score = 7;
            char letter = s.getLetterScore();
            Assert.AreEqual('B', letter);
        }
        [TestMethod]
        public void SroceC_When5()
        {
            Student s = new Student();
            s.Score = 5;
            char letter = s.getLetterScore();
            Assert.AreEqual('C', letter);
        }
        [TestMethod]
        public void SroceD_When3point5()
        {
            Student s = new Student();
            s.Score = 3.5;
            char letter = s.getLetterScore();
            Assert.AreEqual('D', letter);
        }

    }
}