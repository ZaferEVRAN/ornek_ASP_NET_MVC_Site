﻿//------------------------------------------------------------------------------
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

    public partial class anasayfa
    {
        public int id { get; set; }
        public string foto { get; set; }

        public virtual HttpPostedFileBase fotoFile { get; set; }


        [Required]
        [Display(Name = "Üst Başlık")]
        public string ustBaslik { get; set; }

        [AllowHtml]
        [Required]
        [Display(Name = "Üst İçerik")]
        public string ustIcerik { get; set; }

        [Required]
        [Display(Name = "Link")]
        public string link { get; set; }

        [Required]
        [Display(Name = "Alt Başlık")]
        public string altBaslik { get; set; }

        [AllowHtml]
        [Required]
        [Display(Name = "Alt İçerik")]
        public string altIcerik { get; set; }
    }
}
