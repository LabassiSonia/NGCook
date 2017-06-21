using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NGCooking.Models
{
    public class Comments
    {
        [ForeignKey("User")]
        [Key]
        public int UserId { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public int Mark { get; set; }


        //Navigation property
        public virtual Community User { get; set; }

    }
}