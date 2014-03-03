using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WhosGiggin.Models
{
    [Table("Events")]
    public class EventModel: IIdentifiableObject
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(300)]
        [MinLength(3)]
        [Required]
        [Display(Name = "Title")]
        [DataType(DataType.Text)]
        public string Title { get; set; }

       [Required]
        [Display(Name = "Starts")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }

        [Required]
        [Display(Name = "Finishes")]
        [DataType(DataType.DateTime)]
        public DateTime FinishDate { get; set; }
              
    
        public virtual VenueModel Venue { get; set; }

        [Required]
        public int VenueId { get; set; }
        
        [MaxLength(500)]
        [DataType(DataType.Text)]
        public string Restrictions { get; set; }

        [Url]
        [Display(Name = "Website")]
        [DataType(DataType.Url)]
        public string WebsiteUrl { get; set; }

        [MaxLength(300)]
        [Display(Name = "Listed By")]
        [DataType(DataType.Text)]
        public string  ListedBy { get; set; }

        [MaxLength(1000)]
        [MinLength(50)]
        [Required]
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Url]
        [Display(Name = "Main Image")]
        [DataType(DataType.ImageUrl)]
        public string PrimaryImageUrl { get; set; }
    }
}