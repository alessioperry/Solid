using NUnit.Framework;

namespace LiskowSubstitution.Test
{
    [TestFixture]
    class RectangleSquareViolating
    {
        [Test]
        public void ViolatingLiskovSubstitution()
        {
            var square = new SquareViolating();
            square.SetHeight(40);
            TheViolation(square);

            Assert.AreNotEqual(square.GetHeight(), square.GetWidth());
        }

        [Test]
        public void ViolatingLiskovSubstitutionCaseTwo()
        {
            var square = new SquareViolating();
            square.SetHeight(40);
            TheViolation(square);

            Assert.AreNotEqual(square.GetHeight(), square.GetWidth());
        }

        private static void TheViolation(RettangleViolating rectangle)
        {
            rectangle.SetHeight(34);
        }
    }
}
