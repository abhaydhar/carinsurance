//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CarInsurance_WebApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class car_main
    {
        public int car_key { get; set; }
        public int insuree_key { get; set; }
        public int car_year { get; set; }
        public string car_make { get; set; }
        public string car_model { get; set; }
    
        public virtual insuree_main insuree_main { get; set; }
    }
}
