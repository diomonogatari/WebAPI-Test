// <copyright file="CustomerCreateDto.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace CodeBlue.Dtos
{
    using System.ComponentModel.DataAnnotations;

    /// <summary>
    /// The composition of a Create for the Customer dto.
    /// </summary>
    public class CustomerCreateDto
    {
        /// <summary>
        /// Gets or sets the first name.
        /// </summary>
        [Required]
        [MaxLength(128)]
        public string Firstname { get; set; }

        /// <summary>
        /// Gets or sets the surname.
        /// </summary>
        [Required]
        [MaxLength(128)]
        public string Surname { get; set; }

        /// <summary>
        /// Gets or sets the email address.
        /// </summary>
        [Required]
        [MaxLength(256)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        [Required]
        [MaxLength(1024)]
        public string Password { get; set; }
    }
}
