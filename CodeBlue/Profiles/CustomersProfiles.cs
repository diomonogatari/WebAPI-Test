// <copyright file="CustomersProfiles.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeBlue.Profiles
{
    using AutoMapper;
    using CodeBlue.Dtos;
    using CodeBlue.Models;

    /// <summary>
    /// The customers profiles.
    /// </summary>
    public class CustomersProfiles : Profile
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomersProfiles"/> class.
        ///  Source -> Target.
        /// </summary>
        public CustomersProfiles()
        {
            this.CreateMap<Customer, CustomerReadDto>();
            this.CreateMap<CustomerCreateDto, Customer>();
            this.CreateMap<CustomerUpdateDto, Customer>();
            this.CreateMap<Customer, CustomerUpdateDto>();
        }
    }
}
