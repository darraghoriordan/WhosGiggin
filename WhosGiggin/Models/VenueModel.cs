using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WhosGiggin.Models
{
    [Table("Venues")]
    public class VenueModel : IIdentifiableObject
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [Display(Name = "Region")]
        [DataType(DataType.Text)]
        public string Region { get; set; }

        [Display(Name = "Address")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        [Display(Name = "Postcode")]
        [DataType(DataType.PostalCode)]
        public string Postcode { get; set; }

        [Display(Name = "Phone Number")]
        [DataType(DataType.Text)]
        public string ContactPhone { get; set; }

        [Display(Name = "Website")]
        [DataType(DataType.Url)]
        public string WebsiteUrl { get; set; }
       
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Display(Name = "Main Image")]
        [DataType(DataType.ImageUrl)]
        public string PrimaryImageUrl { get; set; }
    }
}