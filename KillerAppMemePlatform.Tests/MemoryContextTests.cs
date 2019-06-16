using KillerAppMemePlatform.DAL;
using KillerAppMemePlatform.DAL.Interfaces;
using KillerAppMemePlatform1.Factory;
using KillerAppMemePlatform1.Logic.Interfaces;
using KilllerAppMemePlatform1.BLL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KillerAppMemePlatform.Tests
{
    [TestClass]
    public class MemoryContextTests
    {
        private IPostRepository postMemoryDAL = TestFactory.CreateMemoryPostDAL();

        private IPostCollectionRepository postCollectionMemoryDAL = TestFactory.CreateMemoryPostCollectionDAL();

        [TestMethod]
        public void AddPostTest()
        {
            // Arrange
            PostMemoryContext postMemoryContext = new PostMemoryContext();
            PostStruct postStruct = new PostStruct();

            // Act
            postCollectionMemoryDAL.Add(postStruct);

            int expected = 1;
            int actual = postMemoryContext.GetPostStructList.Count;


            // Assert
            Assert.AreEqual(expected, actual);
            
        }

        [TestMethod]
        public void AddPostTest2()
        {
            // Arrange
            PostModel postModel = new PostModel(23, "/UploadedFiles/7.jpg", "Title");

            IPost testPost = new Post(postModel);

            // Act
            PostCollection postCollection = new PostCollection(postCollectionMemoryDAL);
            postCollection.Add(postModel);

            List<IPost> posts = postCollection.GetAllPosts();

            posts.Reverse();

            IPost lastAdded = posts[0];

            // Assert
            Assert.IsTrue(posts.Contains(testPost));
            Assert.AreEqual(lastAdded.PostId, testPost.PostId);
        }

        [TestMethod]
        public void Add(PostStruct postStruct)
        {
            
        }
    }
}
