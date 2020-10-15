using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void BaseStackTest()
        {
            sizedStack<int> sizedStack = new sizedStack<int>();
            Assert.AreEqual(true, sizedStack.Push(3));
            Assert.AreEqual(true, sizedStack.Push(5));
            Assert.AreEqual(true, sizedStack.Push(7));
            Assert.AreEqual(7, sizedStack.Pop());
            Assert.AreEqual(true, sizedStack.Push(8));
            Assert.AreEqual(8, sizedStack.Pop());
            Assert.AreEqual(5, sizedStack.Pop());
            Assert.AreEqual(true, sizedStack.Push(1));
            Assert.AreEqual(1, sizedStack.Pop());
            Assert.AreEqual(3, sizedStack.Pop());
        }
        [TestMethod]
        public void BaseQueueTest()
        {
            sizedQueue<int> sizedStack = new sizedQueue<int>();
            Assert.AreEqual(true, sizedStack.Push(1));
            Assert.AreEqual(1, sizedStack.Pop());
            Assert.AreEqual(true, sizedStack.Push(8));
            Assert.AreEqual(true, sizedStack.Push(7));
            Assert.AreEqual(true, sizedStack.Push(5));
            Assert.AreEqual(true, sizedStack.Push(1));
            Assert.AreEqual(true, sizedStack.Push(1));
            Assert.AreEqual(8, sizedStack.Pop());
            Assert.AreEqual(7, sizedStack.Pop());
            Assert.AreEqual(5, sizedStack.Pop());
            Assert.AreEqual(1, sizedStack.Pop());
            Assert.AreEqual(true, sizedStack.Push(3));
            Assert.AreEqual(true, sizedStack.Push(4));
        }
        [TestMethod]
        public void MyTest1()
        {
            sizedQueue<int> sizedStack = new sizedQueue<int>(1);
            Assert.AreEqual(true, sizedStack.Push(8));
            Assert.AreEqual(false, sizedStack.Push(7));
            Assert.AreEqual(8, sizedStack.Pop());
            try { sizedStack.Pop(); }
            catch (Exception e) { Assert.AreEqual("Очередь пуста", e.Message); }
        }

        [TestMethod]
        public void MyTest2()
        {
            sizedStack<int> sizedStack = new sizedStack<int>(1);
            Assert.AreEqual(true, sizedStack.Push(8));
            Assert.AreEqual(false, sizedStack.Push(7));
            Assert.AreEqual(8, sizedStack.Pop());
            try { sizedStack.Pop(); }
            catch (Exception e) { Assert.AreEqual("Стек пуст", e.Message); }
        }

        [TestMethod]
        public void MyTest3()
        {
            int[] test = new int[] { 1 };
            sizedStack<int> sizedStack = new sizedStack<int>(test, true);
            Assert.AreEqual(true, sizedStack.Push(8));
            Assert.AreNotEqual(test[0], sizedStack.Pop());
        }

        [TestMethod]
        public void MyTest4()
        {
            int[] test = new int[] { 1 };
            sizedStack<int> sizedStack = new sizedStack<int>(test, false);
            Assert.AreEqual(true, sizedStack.Push(8));
            Assert.AreEqual(test[0], sizedStack.Pop());
        }
    }
}
