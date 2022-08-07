using Xunit;
using System;

namespace Gradebook.Tests
{
    
    public delegate string WriteLogDelegate(string logMessage);
    
    public class TypeTests
    {
        int count = 0;
        [Fact]
        public void WriteLogDelegateCanPointMethod()
        {
            WriteLogDelegate log = ReturnMessage;
            log += ReturnMessage;
            log += incrementCount;
            var result = log("Hello");
            Assert.Equal("Hello", result);
        }

        string incrementCount(string message)
        {
            count ++;
            return message;
        }

        string ReturnMessage(string message)
        {   
            return message;
        }

        [Fact]
        public void Test1()
        {
            int x = GetInt();
            SetInt(ref x);

            Assert.Equal(42, x);
        }

        private void SetInt(ref int x)
        {
            x = 42;
        }

        private int GetInt()
        {
            return 3;
        }

        [Fact]
        public void CSharpCanPassByReference()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(ref book1, "New Name");
            
            Assert.Equal("New Name", book1.Name);
        }

        private void GetBookSetName(ref Book book, string name)
        {
            book = new Book(name);
        }



        [Fact]
        public void CSharpIsPassByValue()
        {
            var book1 = GetBook("Book 1");
            GetBookSetName(book1, "New Name");

            Assert.Equal("Book 1", book1.Name);
        }

        private void GetBookSetName(Book book, string name)
        {
            book = new Book(name);
        }
       
        /*
        [Fact]
        public void CanSetNameFromReference()
        {
            Book book1 = GetBook("Book 1");
            SetName(book1, "New Name");
            Assert.Equal("New Name", book1.Name);

        }

        private void SetName(Book book, string name)
        {
            book.Name = name;
        }
        */

        [Fact]
        public void GetBookReturnsDifferentObjects()
        {
            var book1 = GetBook("Book 1");
            var book2 = GetBook("Book 2");

            Assert.Equal("Book 1", book1.Name);
            Assert.Equal("Book 2", book2.Name);

        }

        [Fact]
        public void TwoVariablesCanReferenceSameObject()
        {
            var book1 = GetBook("Book 1");
            var book2 = book1;

            /*
            Verifies that both objects refer to the
            same instance. 
            */
            Assert.Same(book1, book2);
            Assert.True(Object.ReferenceEquals(book1, book2));

        }

        Book GetBook(string name)
        {
            return  new Book(name);
        }

    }
}