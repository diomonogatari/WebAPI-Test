// <copyright file="ICodeBlueRepo.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeBlue.Data
{
    using CodeBlue.Models;

    /// <summary>
    /// The code blue repository base.
    /// </summary>
    public interface ICodeBlueRepo
    {
        /// <summary>
        /// Gets the customer by name.
        /// </summary>
        /// <param name="firstname">The firstname of the Customer.</param>
        /// <param name="surname">The surname of the Customer.</param>
        /// <returns>A Customer.</returns>
        Customer GetCustomerByName(string firstname, string surname);
    }
}