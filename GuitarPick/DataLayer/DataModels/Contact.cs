using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GuitarPick.DataLayer.DataModels
{
    public class Contact
    {
        public int ContactID { get; set; }
        [Required(ErrorMessage ="We need an email so we can respond back")] 
        public string Email { get; set; }
        [Required(ErrorMessage ="We love hearing from people so we ask for your name so we can address you back")]
        public string Name { get; set; }
        [Required(ErrorMessage ="Tell us what is on your mind. We want to help with your issue(s)")]
        public string Message { get; set; }
    }
}