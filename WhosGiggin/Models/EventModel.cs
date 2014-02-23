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
    public class EventModel
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Display(Name = "Title")]
        [DataType(DataType.Text)]
        public string Title { get; set; }
        [Display(Name = "Starts")]
        [DataType(DataType.DateTime)]
        public DateTime StartDate { get; set; }
        [Display(Name = "Finishes")]
        [DataType(DataType.DateTime)]
        public DateTime FinishDate { get; set; }
        [DataType(DataType.Custom)]
        public VenueModel Venue { get; set; }
        [DataType(DataType.Text)]
        public string Restrictions { get; set; }
        [Display(Name = "Website")]
        [DataType(DataType.Url)]
        public string WebsiteUrl { get; set; }
        [Display(Name = "Listed By")]
        [DataType(DataType.Text)]
        public string  ListedBy { get; set; }
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [Display(Name = "Main Image")]
        [DataType(DataType.ImageUrl)]
        public string PrimaryImageUrl { get; set; }
    }
}