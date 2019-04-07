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
            PostStruct postStruct = new PostStruct(1, "", "Nobody reads this", "", 0, 0);

            Post testPost = new Post(postStruct);

            // Act
            PostCollection.Add(postStruct);

            List<Post> post = PostCollection.GetAll();

            Post lastAdded = post[0];

            // Assert
            Assert.AreEqual(testPost.Post_id, lastAdded.Post_id);

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
