// <copyright file="CustomersController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeBlue.Controllers
{
    using System;
    using System.Collections.Generic;
    using CodeBlue.Data;
    using CodeBlue.Dtos;
    using CodeBlue.Models;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Extensions.Logging;

    /// <summary>
    /// The customer controller.
    /// </summary>
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICodeBlueRepo repoCodeBlue;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersController"/> class.
        /// </summary>
        /// <param name="repository">The repository instance.</param>
        /// <param name="log">The logger instance.</param>
        public CustomersController(ICodeBlueRepo repository)
        {
            this.repoCodeBlue = repository;
        }

        /// <summary>
        /// GET api/customers.
        /// </summary>
        /// <returns>An ActionResult.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            var result = this.repoCodeBlue.GetAllCustomersAsync();

            return this.Ok(result);
        }

        /// <summary>
        /// GET api/customers/id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>An ActionResult.</returns>
        [HttpGet("{id}", Name = "GetCustomerById")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var result = this.repoCodeBlue.GetCustomerByIdAsync(id);
            if (result.Result != null)
            {
                return this.Ok(result);
            }

            return this.NotFound();
        }

        /// <summary>
        /// Creates a customer.
        /// POST api/customers.
        /// </summary>
        /// <param name="customerCreateDto">The customer create dto.</param>
        /// <returns>An ActionResult.</returns>
        [HttpPost]
        public ActionResult<CustomerReadDto> CreateCustomer(CustomerCreateDto customerCreateDto)
        {
            var result = this.repoCodeBlue.CreateCustomerAsync(customerCreateDto);

            return this.Ok(result);
        }

        /// <summary>
        /// Updates a customer.
        /// PUT api/customers/{id}.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="customerUpdateDto">The customer update dto.</param>
        /// <returns>An ActionResult.</returns>
        [HttpPut("{id}")]
        public ActionResult UpdateCustomer(int id, CustomerUpdateDto customerUpdateDto)
        {
            try
            {
                var result = this.repoCodeBlue.UpdateCustomerAsync(id, customerUpdateDto);
            }
            catch (Exception e)
            {
                return this.NotFound(e.Message);
            }

            return this.NoContent();
        }

        /// <summary>
        /// Deletes a customer.
        /// DELETE api/customers/{id}.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>An ActionResult.</returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            this.repoCodeBlue.DeleteCustomerAsync(id);

            return this.NoContent();
        }
    }
}