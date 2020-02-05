using NUnit.Framework;
using Assignment01;

namespace Assignment01Test
{
    [TestFixture]
    class RectangleTest
    {
        [Test]
        public void Setlength_IfEqual_Istrue()
        {
            //Arrange
            Rectangle rect = new Rectangle();
            int length = 4;

            //Act
            rect.SetLength(length);
            //Assert
            Assert.AreEqual(4, rect.GetLength());


        }
        [Test]
        public void Setlength_IfGreaterThan0_IsTrue()
        {
            //Arrange
            Rectangle rect = new Rectangle();
            int length = 1;

            //Act
            rect.SetLength(length);
            //Assert
            Assert.That(rect.SetLength(length), Is.GreaterThan(0));
        }
        [Test]
        public void Getwidth_IfEqual_IsTrue()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            rect.SetWidth(6);

            //Assert
            Assert.That(rect.GetWidth, Is.EqualTo(6));
        }
        [Test]
        public void SetWidth_IfLessThanOrEqualTo0_IsTrue()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Assert
            Assert.LessOrEqual(0, rect.SetWidth(0));
        }
        [Test]
        public void GetPerimeter_IsTrue()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            rect.SetLength(6);
            rect.SetWidth(4);

            //Assert
            Assert.AreEqual(20, rect.GetPerimeter());

        }
        [Test]
        public void GetArea_IsTrue()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            rect.SetLength(6);
            rect.SetWidth(4);

            //Assert
            Assert.AreEqual(24, rect.GetArea());

        }
        [Test]
        public void Setlength_IfEqual_Isfalse()
        {
            //Arrange
            Rectangle rect = new Rectangle();
            int length = 5;

            //Act
            rect.SetLength(length);
            //Assert
            Assert.AreEqual(4, rect.GetLength());


        }
        [Test]
        public void Setlength_IfGreaterThan0_IsFalse()
        {
            //Arrange
            Rectangle rect = new Rectangle();
            int length = -1;

            //Act
            rect.SetLength(length);
            //Assert
            Assert.That(rect.SetLength(length), Is.GreaterThan(0));
        }
        [Test]
        public void Getwidth_IfEqual_IsFalse()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            rect.SetWidth(7);

            //Assert
            Assert.That(rect.GetWidth, Is.EqualTo(6));
        }
        [Test]
        public void SetWidth_IfLessThanOrEqualTo0_IsFalse()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Assert
            Assert.LessOrEqual(2, rect.SetWidth(0));
        }
        [Test]
        public void GetPerimeter_IsFalse()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            rect.SetLength(6);
            rect.SetWidth(4);

            //Assert
            Assert.AreEqual(21, rect.GetPerimeter());

        }
        [Test]
        public void GetArea_IsFalse()
        {
            //Arrange
            Rectangle rect = new Rectangle();

            //Act
            rect.SetLength(6);
            rect.SetWidth(4);

            //Assert
            Assert.AreEqual(25, rect.GetArea());

        }

    }
}
