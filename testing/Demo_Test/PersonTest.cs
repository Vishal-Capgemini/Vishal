using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Demo_Test
{
    class PersonTest
    {
        Person person;
        [SetUp]
        public void init()
        {
            person = new Person();
        }
        
        private void TestExceptionLambda()
        {
            person.Fname = "Jack";
            person.Mname = "Sparrow";
            Assert.Throws<MissingFieldException>(() => person.GetFullName());
        }
        private void TestName()
        {
            person.Fname = "Jack";
            person.Mname = "Sparrow";
            string res = person.GetFullName();
           
        }
        [Test]
        public void TestException()
        {
            Assert.Throws<MissingFieldException>(TestName);
        }
        [Test]
        public void TestFullName()
        {
            person.Fname = "Jack";
            person.Mname = "Sparrow";
            person.Lname = "tam";
            Assert.AreEqual("Jack Sparrow tam", person.GetFullName());

        }
    }
}
