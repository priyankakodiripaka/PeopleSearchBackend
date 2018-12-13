using System;
using System.Collections.Generic;
using System.Web.Http.Results;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PeopleSearchBackend.Controllers;
using PeopleSearchBackend.Models;

namespace PeopleSearchBackend.Tests
{
    [TestClass]
    public class UnitTestPeopleSearch
    {
        private ValuesController valController;
        public UnitTestPeopleSearch()
        {
            valController = new ValuesController();
        }
        [TestMethod]
        public void GetAll()
        {
            // Arrange
            var actionResult = valController.Get();
            var contentResult = actionResult as OkNegotiatedContentResult<List<PeopleSearch>>;
            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(7, contentResult.Content.Count);
        }

        [TestMethod]
        public void GetDetails()
        {
            // Arrange
            var actionResult = valController.Get("lara");
            var contentResult = actionResult as OkNegotiatedContentResult<List<PeopleSearch>>;
            // Assert
            Assert.IsNotNull(contentResult);
            Assert.IsNotNull(contentResult.Content);
            Assert.AreEqual(1, contentResult.Content.Count);
        }
    }
}
