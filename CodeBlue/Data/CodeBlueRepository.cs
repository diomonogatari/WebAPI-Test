// <copyright file="CodeBlueRepository.cs" company="PlaceholderCompany">
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
    /// The CodeBlueDB repository layer.
    /// </summary>
    public class CodeBlueRepository : ICodeBlueRepo
    {
        private readonly CodeBlueContext context;

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBlueRepository"/> class.
        /// </summary>
        /// <param name="ctx">The ctx.</param>
        public CodeBlueRepository(CodeBlueContext ctx)
        {
            this.context = ctx;
        }

        /// <inheritdoc/>
        public void CreateCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            this.context.Customers.Add(customer);
        }

        /// <inheritdoc/>
        public IEnumerable<Customer> GetAllCustomers()
        {
            return this.context.Customers.ToList();
        }

        /// <inheritdoc/>
        public Customer GetCustomerById(int id)
        {
            return this.context.Customers.FirstOrDefault(x => x.Id == id);
        }

        /// <inheritdoc/>
        public void UpdateCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }

        /// <inheritdoc/>
        public void DeleteCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }

            this.context.Customers.Remove(customer);
        }

        /// <inheritdoc/>
        public bool SaveChanges()
        {
            return this.context.SaveChanges() >= 0;
        }
    }
}
