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
        [TestMethod]
        public void AddPostTest()
        {
            // Arrange
            PostModel postModel = new PostModel(23, "/UploadedFiles/7.jpg", "Title");

            Post testPost = new Post(postModel);

            // Act
            PostCollection postCollection = new PostCollection();
            postCollection.Add(postModel);

            List<IPost> post = postCollection.GetAllPosts();

            //post.Reverse();

            IPost lastAdded = post[0];

            // Assert
            Assert.AreEqual(lastAdded.PostId, testPost.PostId);

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
            // Arrange
            PostStruct postStruct = new PostStruct(23, "/UploadedFiles/7.jpg", "");
            PostCollection postCollection = new PostCollection();


            // Act
            postCollection.Add(postStruct);

            // Assert

        }

        [TestMethod]
        public void TitleTest()
        {
            // Arrange
            PostStruct postStruct = new PostStruct(23, "/UploadedFiles/7.jpg", "Title");
            PostCollection postCollection = new PostCollection();


            // Act
            postCollection.Add(postStruct);

            // Assert

        }
    }
}
