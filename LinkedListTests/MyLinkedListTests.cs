using Microsoft.VisualStudio.TestTools.UnitTesting;
using LinkedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList.Tests
{
    [TestClass()]
    public class MyLinkedListTests
    {
        MyLinkedList<String> list;

        [TestInitialize]
        public void TestInitialize()
        {
            list = new MyLinkedList<String>();
        }

        [TestMethod()]
        public void addFirstTest()
        {
            list.addFirst("string1");
            Assert.AreEqual("string1", list.getFirst());
    
        }

        [TestMethod()]
        public void addLastTest()
        {
            list.addFirst("string1");
            list.addLast("string2");
            Assert.AreEqual("string2", list.getLast());
        }

        [TestMethod()]
        public void clearTest()
        {
            list.addFirst("string1");
            list.addFirst("string2");
            list.clear();
            Assert.AreEqual(0, list.size());
        }

        [TestMethod()]
        public void removeTest()
        {
            list.addFirst("string1");
            list.addFirst("string2");
            list.addFirst("string3");
            list.remove("string2");
            Assert.AreEqual("string1", list.getFirst());
            Assert.AreEqual("string3", list.getLast());
        }

        [TestMethod()]
        public void removeFirstTest()
        {
            list.addFirst("string1");
            list.addFirst("string2");
            list.removeFirst();
            Assert.AreEqual("string1", list.getFirst());
        }

        [TestMethod()]
        public void removeLastTest()
        {
            list.addFirst("string1");
            list.addLast("string2");
            list.removeLast();
            Assert.AreEqual("string1", list.getLast());
        }

        [TestMethod()]
        public void sizeTest()
        {
            list.addFirst("string1");
            list.addFirst("string2");
            list.addFirst("string3");
            Assert.AreEqual(3, list.size());
        }
    }
}