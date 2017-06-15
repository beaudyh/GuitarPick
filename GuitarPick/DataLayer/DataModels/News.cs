using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuitarPick.DataLayer.DataModels
{
    public class News
    {
        public int ID { get; set; }
        [Required(ErrorMessage = "A title is needed")]
        public string Title { get; set; }
        [Required(ErrorMessage = "Please explain what the story is about")]
        public string Body { get; set; }
        [Required(ErrorMessage = "We want to know who wrote this story")]
        public string Author { get; set; }
        [Required(ErrorMessage = "We need to know when the story was publish")]
        [DisplayName("Date Posted")]
        public DateTime DatePosted { get; set; }
    }
}