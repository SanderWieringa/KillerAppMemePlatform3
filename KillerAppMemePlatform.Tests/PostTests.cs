using KillerAppMemePlatform.DAL.Interfaces;
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
    public class PostTests
    {
        private IPostRepository postMemoryDAL = TestFactory.CreateMemoryPostDAL();

        private IPostCollectionRepository postCollectionMemoryDAL = TestFactory.CreateMemoryPostCollectionDAL();

        [TestMethod]
        public void AddPostTest1()
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
        public void AddPostTests()
        {
            PostModel postModel = new PostModel(1, "FilePath", "Title");
            PostCollection postCollection = new PostCollection(postCollectionMemoryDAL);

            
            
            postCollection.Add(postModel);
            Post actualPost = new Post(postModel);

            Assert.AreEqual(postModel.PostId , actualPost.PostId);
            Assert.AreEqual(postModel.Title, actualPost.Title);
            Assert.AreEqual(postModel.FilePath, actualPost.FilePath);
        }

        [TestMethod]
        public void RepostTest()
        {
            // Arrange


            // Act


            // Assert

        }

        [TestMethod]
        public void NoTitleTest()
        {
            PostModel postModel = new PostModel(1, "FilePath", "");
            PostCollection postCollection = new PostCollection(postCollectionMemoryDAL);

            postCollection.Add(postModel);
            Post actualPost = new Post(postModel);

            Assert.AreEqual(postModel.PostId, actualPost.PostId);
            Assert.AreEqual(postModel.Title, actualPost.Title);
            Assert.AreEqual(postModel.FilePath, actualPost.FilePath);
        }

        [TestMethod]
        public void TitleTest()
        {
            // Arrange
            PostModel postModel = new PostModel(); PostCollection postCollection = new PostCollection(postCollectionMemoryDAL);


            // Act
            postCollection.Add(postModel);

            // Assert

        }
    }
}
