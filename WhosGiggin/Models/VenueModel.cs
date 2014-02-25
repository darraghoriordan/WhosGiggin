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

        [MaxLength(200)]
        [MinLength(3)]
        [Required(AllowEmptyStrings=false)]
        [Display(Name = "Name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [MaxLength(200)]
        [MinLength(2)]
        [Display(Name = "City")]
        [DataType(DataType.Text)]
        public string City { get; set; }

        [MaxLength(200)]
        [MinLength(2)]
        [Display(Name = "Region")]
        [DataType(DataType.Text)]
        public string Region { get; set; }

        [MaxLength(200)]
        [MinLength(2)]
        [Display(Name = "Address")]
        [DataType(DataType.Text)]
        public string Address { get; set; }

        
        [Display(Name = "Postcode")]
        [DataType(DataType.PostalCode)]
        public string Postcode { get; set; }

        [Phone]
        [Required]
        [Display(Name = "Phone Number")]
        [DataType(DataType.Text)]
        public string ContactPhone { get; set; }

        [Url]
        [Display(Name = "Website")]
        [DataType(DataType.Url)]
        public string WebsiteUrl { get; set; }

        [Required]
        [MaxLength(1000)]
        [MinLength(3)]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [MaxLength(300)]
        [Display(Name = "Listed By")]
        [DataType(DataType.Text)]
        public string ListedBy { get; set; }

        [Url]
        [Required]
        [Display(Name = "Main Image")]
        [DataType(DataType.ImageUrl)]
        public string PrimaryImageUrl { get; set; }
    }
}