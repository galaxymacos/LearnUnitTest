using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using NUnit.Framework;

namespace TestNinja.UnitTest
{
    [TestFixture]
    public class StackTests
    {
        private Stack<string> stack;
        [SetUp]
        public void SetUp()
        {
            stack = new Stack<string>();
        }
        
        [Test]
        public void Push_WhenPushNull_ThrowArgumentNullException()
        {
            stack = new Stack<string>();
            Assert.That(()=>stack.Push(null),Throws.ArgumentNullException);
        }

        [Test]
        public void Push_WhenCalled_AddObjectToList()
        {
            string obj = "test message";
            stack.Push(obj);
            Assert.That(stack.Peek(),Is.EqualTo(obj));
        }

        [Test]
        public void Pop_NoElementInStack_ThrowInvalidOperationException()
        {
            Assert.That(()=>stack.Pop(),Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Pop_WhenCalled_PopTheLastElement()
        {
            stack.Push("1");
            stack.Push("2");
            var result = stack.Pop();
            Assert.That(result,Is.EqualTo("2"));
            Assert.That(stack.Count == 1);
        }

        [Test]
        public void Peek_NoElementInStack_ThrowInvalidOperationException()
        {
            Assert.That(()=>stack.Peek(),Throws.Exception.TypeOf<InvalidOperationException>());
        }

        [Test]
        public void Peek_WhenCalled_ReturnTheLastElementWithoutRemovingIt()
        {
            stack.Push("1");
            stack.Push("2");
            var result = stack.Peek();
            Assert.That(result,Is.EqualTo("2"));
            Assert.That(stack.Count,Is.EqualTo(2));
        }
    }
}