// <copyright file="ICodeBlueRepo.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeBlue.Data
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using CodeBlue.Dtos;
    using CodeBlue.Models;

    /// <summary>
    /// The code blue repository base.
    /// </summary>
    public interface ICodeBlueRepo
    {
        /// <summary>
        /// Gets all the customers from the api.
        /// </summary>
        /// <returns>A list of Customers.</returns>
        Task<IEnumerable<CustomerReadDto>> GetAllCustomersAsync();

        /// <summary>
        /// Gets the customer by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>A Task.</returns>
        Task<CustomerReadDto> GetCustomerByIdAsync(int id);

        /// <summary>
        /// Creates a customer.
        /// </summary>
        /// <param name="createDto">The customer.</param>
        /// /// <returns>A Task.</returns>
        Task CreateCustomerAsync(CustomerCreateDto createDto);

        /// <summary>
        /// Updates the customer.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <param name="customerUpdateDto">The customer.</param>
        /// /// <returns>A Task.</returns>
        Task<Customer> UpdateCustomerAsync(int id, CustomerUpdateDto customerUpdateDto);

        /// <summary>
        /// Deletes a customer by id.
        /// </summary>
        /// <param name="id">The customer.</param>
        /// <returns>A Task.</returns>
        Task DeleteCustomerAsync(int id);
    }
}