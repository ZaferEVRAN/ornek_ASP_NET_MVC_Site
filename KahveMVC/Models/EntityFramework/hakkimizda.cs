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
    using System.Web;
    using System.Web.Mvc;

    public partial class hakkimizda
    {
        public int id { get; set; }


        public string foto { get; set; }

        public virtual HttpPostedFileBase fotoFile { get; set; }

        [Required]
        [Display(Name="�st Ba�l�k")]
        public string ustBaslik { get; set; }

        [Required]
        [Display(Name = "Ba�l�k")]
        public string baslik { get; set; }

        [AllowHtml]
        [Required]
        [Display(Name = "��erik")]
        public string icerik { get; set; }
    }
}
