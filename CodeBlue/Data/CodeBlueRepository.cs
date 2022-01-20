// <copyright file="CodeBlueRepository.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeBlue.Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using AutoMapper;
    using CodeBlue.Dtos;
    using CodeBlue.Models;

    /// <summary>
    /// The CodeBlueDB repository layer.
    /// </summary>
    public class CodeBlueRepository : ICodeBlueRepo
    {
        private readonly CodeBlueContext context;
        private readonly IMapper mapper;

        /// <summary>
        /// Initializes a new instance of the <see cref="CodeBlueRepository"/> class.
        /// </summary>
        /// <param name="ctx">The db context.</param>
        /// /// <param name="map">The mapper interface.</param>
        public CodeBlueRepository(CodeBlueContext ctx, IMapper map)
        {
            this.context = ctx;
            this.mapper = map;
        }

        /// <inheritdoc/>
        public async Task<IEnumerable<CustomerReadDto>> GetAllCustomersAsync()
        {
            var map = this.mapper.Map<IEnumerable<CustomerReadDto>>(this.context.Customers.ToList());
            return await Task.FromResult(map);
        }

        /// <inheritdoc/>
        public async Task<CustomerReadDto> GetCustomerByIdAsync(int id)
        {
            var map = this.mapper.Map<CustomerReadDto>(this.context.Customers.FirstOrDefault(x => x.Id == id));

            return await Task.FromResult(map);
        }

        /// <inheritdoc/>
        public async Task CreateCustomerAsync(CustomerCreateDto createDto)
        {
            var newCustomer = this.mapper.Map<Customer>(createDto);

            if (createDto == null)
            {
                throw new ArgumentNullException(nameof(createDto));
            }

            this.context.Customers.Add(newCustomer);

            await this.context.SaveChangesAsync();
        }

        /// <inheritdoc/>
        public async Task<Customer> UpdateCustomerAsync(int id, CustomerUpdateDto customerUpdateDto)
        {
            var currentCustomer = this.context.Customers.FirstOrDefault(p => p.Id == id);
            if (currentCustomer == null)
            {
                throw new Exception("UpdateCustomerAsyn: CustomerId not found");
            }

            var map = this.mapper.Map(customerUpdateDto, currentCustomer);

            await this.context.SaveChangesAsync();

            return await Task.FromResult(map);
        }

        /// <inheritdoc/>
        public async Task DeleteCustomerAsync(int id)
        {
            var deleteCustomer = this.context.Customers.Find(id);
            if (deleteCustomer == null)
            {
                throw new ArgumentNullException(nameof(deleteCustomer));
            }

            this.context.Customers.Remove(deleteCustomer);

            var result = await this.context.SaveChangesAsync();

            await Task.FromResult(result);
        }
    }
}
