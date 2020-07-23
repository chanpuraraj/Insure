//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace checkintegration.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class AccidentInfo
    {
        [Display(Name = "Accident ID:")]
        public int AccidentId { get; set; }

        [Display(Name = "Customer ID:")]
        public int CustId { get; set; }

        [Required]
        [Display(Name = "Latitude:")]
        public double Latitude { get; set; }

        [Required]
        [Display(Name = "Longitude:")]
        public double Longitude { get; set; }

        [Required]
        [Display(Name = "Description:")]
        public string Description { get; set; }

        [Display(Name = "Surveyor ID:")]
        public int SurveyorId { get; set; }

        [Display(Name = "Status")]
        public int Status { get; set; }
    }
}
