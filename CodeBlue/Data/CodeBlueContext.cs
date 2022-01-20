// <copyright file="CodeBlueContext.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeBlue.Data
{
    using CodeBlue.Models;
    using Microsoft.EntityFrameworkCore;

    /// <summary>
    /// The base context of the api.
    /// </summary>
    public class CodeBlueContext : DbContext
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBlueContext"/> class.
        /// </summary>
        /// <param name="opt">The opt.</param>
        public CodeBlueContext(DbContextOptions<CodeBlueContext> opt)
            : base(opt)
        {
        }

        /// <summary>
        /// Gets or sets the customers.
        /// </summary>
        public DbSet<Customer> Customers { get; set; }
    }
}