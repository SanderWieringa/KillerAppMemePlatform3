using KillerAppMemePlatform.DAL;
using KillerAppMemePlatform.DAL.Interfaces;
using KillerAppMemePlatform1.Factory;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.Tests
{
    public class MemoryContextTests
    {
        private IPostRepository postMemoryDAL = TestFactory.CreateMemoryPostDAL();

        private IPostCollectionRepository postCollectionMemoryDAL = TestFactory.CreateMemoryPostCollectionDAL();

        [TestMethod]
        public void AddPostTest()
        {
            // Arrange
            PostStruct postStruct = new PostStruct();

            // Act
            postCollectionMemoryDAL.Add(postStruct);


            // Assert


        }

        [TestMethod]
        public void Add(PostStruct postStruct)
        {
            
        }
    }
}
