//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SCode.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    public partial class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Customer_Id { get; set; }

        [Required(ErrorMessage ="Please enter first name")]
        public string Customer_FirstName { get; set; }


        [Required(ErrorMessage = "Please enter last name")]
        public string Customer_LastName { get; set; }


        [Required(ErrorMessage = "Please enter  address")]
        public string Customer_Address { get; set; }



        [Required(ErrorMessage = "Please enter mobile_number")]
        [RegularExpression("[0-9]{10}",ErrorMessage = "Invalid Mobile Number")]
        public string Customer_Mobile { get; set; }


        [Required(ErrorMessage = "Please enter email")]
        [EmailAddress(ErrorMessage ="Invalid email address")]
        public string Customer_Email { get; set; }


        [Required(ErrorMessage = "Please enter BirthDate")]
        public Nullable<System.DateTime> Customer_Birthdate { get; set; }


        [Required(ErrorMessage = "Please enter password")]
        public string Customer_Password { get; set; }


        [Required(ErrorMessage = "Please enter date")]
        public Nullable<System.DateTime> Created_On { get; set; }
    }
}
