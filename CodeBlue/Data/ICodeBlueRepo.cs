// <copyright file="ICodeBlueRepo.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeBlue.Data
{
    using System.Collections.Generic;
    using CodeBlue.Models;

    /// <summary>
    /// The code blue repository base.
    /// </summary>
    public interface ICodeBlueRepo
    {
        /// <summary>
        /// Saves changes control flag.
        /// </summary>
        /// <returns>A bool.</returns>
        bool SaveChanges();

        /// <summary>
        /// Gets all the customers from the api.
        /// </summary>
        /// <returns>A list of Customers.</returns>
        IEnumerable<Customer> GetAllCustomers();

        /// <summary>
        /// Gets the customer by id.
        /// </summary>
        /// <param name="id">The id.</param>
        /// <returns>A Customer.</returns>
        Customer GetCustomerById(int id);

        /// <summary>
        /// Creates a customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        void CreateCustomer(Customer customer);

        /// <summary>
        /// Updates the customer.
        /// </summary>
        /// <param name="customer">The customer.</param>
        void UpdateCustomer(Customer customer);

        /// <summary>
        /// Deletes a customer by id.
        /// </summary>
        /// <param name="customer">The customer.</param>
        void DeleteCustomer(Customer customer);
    }
}