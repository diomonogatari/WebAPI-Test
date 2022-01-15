// <copyright file="MockCodeBlueRepo.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeBlue.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using CodeBlue.Models;

    /// <summary>
    /// The mock code blue repo.
    /// </summary>
    public class MockCodeBlueRepo : ICodeBlueRepo
    {
        /// <inheritdoc/>
        public Customer GetCustomerByName(string firstname, string surname)
        {
            throw new NotImplementedException();
        }
    }
}
