//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KahveMVC.Models.EntityFramework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Web.Mvc;

    public partial class magaza
    {
        public int id { get; set; }

        [Required]
        [Display(Name = "�st Ba�l�k")]
        public string ustBaslik { get; set; }

        [Required]
        [Display(Name = "Ana Ba�l�k")]
        public string anaBaslik { get; set; }

        [AllowHtml]
        [Required]
        [Display(Name = "Adres")]
        public string adres { get; set; }

        [Required]
        [Display(Name = "Telefon")]
        public string telefon { get; set; }
    }
}
