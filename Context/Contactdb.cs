//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Contacts.Context
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class Contactdb
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Enter First Name")]
        public string Fname { get; set; }
        [Required(ErrorMessage = "Enter Last Name")]
        public string Lname { get; set; }
        [Required(ErrorMessage = "Enter Message")]
        public string Message { get; set; }
        [Required(ErrorMessage = "Enter Email Address")]
        [EmailAddress]
        public string email { get; set; }
        [Required(ErrorMessage = "Enter Phone no")]
        [MinLength(11, ErrorMessage = "Invalid Phone no ")]
        public string phoneno { get; set; }
    }
}
