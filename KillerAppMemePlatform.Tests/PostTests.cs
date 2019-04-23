using KillerAppMemePlatform.DAL.Interfaces;
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
            PostStruct postStruct = new PostStruct(1, "", "Title", 1, 0, 1);

            Post testPost = new Post(postStruct);

            // Act
            PostCollection postCollection = new PostCollection();
            postCollection.Add(postStruct);

            List<Post> post = postCollection.GetAll();

            post.Reverse();

            Post lastAdded = post[0];

            // Assert
            Assert.AreEqual(testPost.PostId, lastAdded.PostId);

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


            // Act


            // Assert

        }

        [TestMethod]
        public void TitleTest()
        {
            // Arrange


            // Act


            // Assert

        }
    }
}
