using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CRUDMVCDEMOAUTO.Models
{
    public class Customer
    {
      
            [Key]
            [Display(Name = "Aadhar Number")]
            [Required(ErrorMessage = "Aadhar Id Cannot Be Null")]

            public int Aadharid { get; set; }
            [Display(Name = " Voter Id")]
            [Required(ErrorMessage = "Voter Id Cannot Be Null")]
            public int Voterid { get; set; }

            [Display(Name = "Customer Name")]
            [Required(ErrorMessage = "Customer Name Cannot Be Null")]
            [StringLength(10, MinimumLength = 5, ErrorMessage = "The Customer Name shoul be Minimum 5 character Long & MAX 10 Charatrer Long")]
            public string CName { get; set; }
            [Required(ErrorMessage = "Please select Gender ")]
            public string Gender { get; set; }
            [Required(ErrorMessage = "Age is Mandatory")]
            public int Age { get; set; }
            [Required(ErrorMessage = "Please Select City")]
            public string City { get; set; }

            public string Qualification { get; set; }
      
    }
}