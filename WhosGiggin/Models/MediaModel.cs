using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;

namespace WhosGiggin.Models
{
    public class MediaModel : IIdentifiableObject
    {
        [Key]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public string ThumbnailUrl { get; set; }
        public string PrimaryUrl { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        
    }
}