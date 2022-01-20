using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeBlue.Controllers;
using CodeBlue.Data;
using CodeBlue.Dtos;
using CodeBlue.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using Xunit;

namespace CodeBlue.Tests
{

    /// <summary>
    /// The tests for our Controller.
    /// </summary>
    public class CustomersControllerTests
    {
        private readonly Mock<ICodeBlueRepo> repositoryStub = new Mock<ICodeBlueRepo>();
        private readonly Random rand = new Random();

        /// Tests the GetCustomer async with unexisting customer id, returns not found.
        /// </summary>
        /// <returns>A Task.</returns>
        [Fact]
        public void GetCustomerAsync_WithUnexistingCustomerId_ReturnsNotFound()
        {
            // Arrange
            repositoryStub.Setup(repo => repo.GetCustomerByIdAsync(It.IsAny<int>()))
                .ReturnsAsync((CustomerReadDto)null);

            var controller = new CustomersController(repositoryStub.Object);

            // Act
            var result = controller.GetCustomerById(800);

            Assert.IsType<NotFoundResult>(result.Result);
        }
    }
}