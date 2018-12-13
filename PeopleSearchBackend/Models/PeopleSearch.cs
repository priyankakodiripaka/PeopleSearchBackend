using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
namespace PeopleSearchBackend.Models
{
    public class PeopleSearch
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Age { get; set; }
        [Required]
        public string Interests { get; set; }
        [Required]
        public string PictureUrl { get; set; }
    }
}