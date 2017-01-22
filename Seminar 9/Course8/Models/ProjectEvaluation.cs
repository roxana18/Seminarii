using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Course8.Models
{
    [Bind(Exclude = "Country")]
    public class ProjectEvaluation
    {
    
        public string Name
        { 
            get; set;
        }
        public string City
        {
            get; set;
        }
        public string Country
        {
            get; set;
        }
        [Range(1,10)]
        [Required]
        public double Rating
        {
            get; set;
        }

        public int Id
        {
            get; set;
        }
        [StringLength(100)]
        public string Description
        {
            get; set;
        }
    }
}