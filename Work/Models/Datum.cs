//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Work.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel;
    public partial class Datum
    {
        public int Person_ID { get; set; }
         [Required(ErrorMessage = "This Feild is required")]
        public string Name { get; set; }
         [Required(ErrorMessage = "This Feild is required")]
        public string Father_Name { get; set; }
         [Required(ErrorMessage = "This Feild is required")]
        public string Gender { get; set; }
         [Required(ErrorMessage = "This Feild is required")]
        public string Identity_Number { get; set; }
         [Required(ErrorMessage = "This Feild is required")]
        public string Date_of_Birth { get; set; }
       
    }

}