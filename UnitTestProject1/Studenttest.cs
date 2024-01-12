using ClassLibrary1;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using NUnit.Framework;
using System;
using Assert = Microsoft.VisualStudio.TestTools.UnitTesting.Assert;

namespace UnitTestProject1
{
    [TestClass]
    public class Studenttest
    {
        [TestFixture]
        public class SchoolDataTests
        {
            [Test]
            public void TestTeacherFullName()
            {
                // Arrange
                var teacher = new Teacher { Id = 1, Name = "Vishwas Kulkarni" };

                // Act
                var result = teacher.GetFullName();

                // Assert
                Assert.AreEqual("Teacher: Vishwas Kulkarni", result);
            }

            [Test]
            public void TestStudentEnrollment()
            {
                // Arrange
                var student = new Student { Id = 1, Name = "Aniket" };

                // Act
                var result = student.Enroll("Science");

                // Assert
                Assert.IsTrue(result);
            }

            [Test]
            public void TestSubjectGrade()
            {
                // Arrange
                var mockStudent = new Mock<IStudent>();
                mockStudent.Setup(s => s.GetGrade("Science")).Returns("A");

                var subject = new Subject("Science", mockStudent.Object);

                // Act
                var result = subject.GetGrade();

                // Assert
                Assert.AreEqual("A", result);
            }
        }
    }
}
