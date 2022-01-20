// <copyright file="CustomersController.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeBlue.Controllers
{
    using System.Collections.Generic;
    using AutoMapper;
    using CodeBlue.Data;
    using CodeBlue.Dtos;
    using CodeBlue.Models;
    using Microsoft.AspNetCore.Mvc;

    /// <summary>
    /// The customer controller.
    /// </summary>
    [Route("api/customers")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICodeBlueRepo repoCodeBlue;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersController"/> class.
        /// </summary>
        /// <param name="repository">The repository.</param>
        /// <param name="mapper">The mapper.</param>
        public CustomersController(ICodeBlueRepo repository, IMapper mapper)
        {
            this.repoCodeBlue = repository;
            this.mapper = mapper;
        }

        /// <summary>
        /// GET api/customers.
        /// </summary>
        /// <returns>An ActionResult.</returns>
        [HttpGet]
        public ActionResult<IEnumerable<Customer>> GetAllCustomers()
        {
            var customersList = this.repoCodeBlue.GetAllCustomers();

            return this.Ok(this.mapper.Map<IEnumerable<CustomerReadDto>>(customersList));
        }

        /// <summary>
        /// GET api/customers/id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>An ActionResult.</returns>
        [HttpGet("{id}", Name = "GetCustomerById")]
        public ActionResult<Customer> GetCustomerById(int id)
        {
            var customerById = this.repoCodeBlue.GetCustomerById(id);
            if (customerById != null)
            {
                return this.Ok(this.mapper.Map<CustomerReadDto>(customerById));
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
            var customerModel = this.mapper.Map<Customer>(customerCreateDto);
            this.repoCodeBlue.CreateCustomer(customerModel);
            this.repoCodeBlue.SaveChanges();

            var customerModelDto = this.mapper.Map<CustomerReadDto>(customerModel);

            return this.CreatedAtRoute(nameof(this.GetCustomerById), new { Id = customerModelDto.Id }, customerModelDto);
        }

        /// <summary>
        /// Updates a customer.
        /// PUT api/customer/{id}.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="customerUpdateDto">The customer update dto.</param>
        /// <returns>An ActionResult.</returns>
        [HttpPut("{id}")]
        public ActionResult UpdateCustomer(int id, CustomerUpdateDto customerUpdateDto)
        {
            var customerModel = this.repoCodeBlue.GetCustomerById(id);
            if (customerModel == null)
            {
                return this.NotFound();
            }

            this.mapper.Map(customerUpdateDto, customerModel);

            this.repoCodeBlue.UpdateCustomer(customerModel);

            this.repoCodeBlue.SaveChanges();

            return this.NoContent();
        }

        /// <summary>
        /// Deletes a customer.
        /// DELETE api/customer/{id}.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>An ActionResult.</returns>
        [HttpDelete("{id}")]
        public ActionResult DeleteCustomer(int id)
        {
            var customerModel = this.repoCodeBlue.GetCustomerById(id);
            if (customerModel == null)
            {
                return this.NotFound();
            }

            this.repoCodeBlue.DeleteCustomer(customerModel);
            this.repoCodeBlue.SaveChanges();

            return this.NoContent();
        }
    }
}