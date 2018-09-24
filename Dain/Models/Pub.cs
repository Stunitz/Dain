﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Dain.Models
{
    /// <summary>
    /// The data model of the pub type users that will access the system
    /// </summary>
    public class Pub : User
    {
        public Pub() { }

        public Pub(User user) : base(user) { }

        public Pub(User user, Pub pub) : base(user)
        {
            Name = pub.Name;
            Address = pub.Address;
            City = pub.City;
            State = pub.State;
            FoundationDate = pub.FoundationDate;
            PhotoUrl = pub.PhotoUrl;
            UserType = nameof(Pub);
        }

        /// <summary>
        /// The name of the <see cref="Pub"/>
        /// </summary>
        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// The address that the <see cref="Pub"/> is located
        /// </summary>
        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        /// <summary>
        /// The city where the <see cref="Pub"/> is located
        /// </summary>
        [Required]
        [Display(Name = "City")]
        public string City { get; set; }

        /// <summary>
        /// The state that the <see cref="Pub"/> is located
        /// </summary>
        [Display(Name = "State")]
        public string State { get; set; }

        /// <summary>
        /// The date of foundation of the <see cref="Pub"/>
        /// </summary>
        [Required]
        [Display(Name = "Foundation Date")]
        [DataType(DataType.DateTime)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime FoundationDate { get; set; }

        /// <summary>
        /// The rating of the <see cref="Pub"/> that persons have given
        /// </summary>
        public double Rating { get; set; }

        /// <summary>
        /// The path of the directory of the photos of the <see cref="Pub"/>
        /// </summary>
        public byte[] PhotoUrl { get; set; }
        public string PhotoType { get; set; }


        public double Lat { get; set; }

        public double Lng { get; set; }

        public string PhotoBase64()
        {
            if (PhotoUrl != null) return string.Format($"data:{PhotoType};base64,{Convert.ToBase64String(PhotoUrl)}");
            return null;

        }

    }
}