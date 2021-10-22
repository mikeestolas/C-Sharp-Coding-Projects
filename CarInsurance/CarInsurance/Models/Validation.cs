using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CarInsurance.Models
{
    [MetadataType(typeof(InsuranceMetaData))]

    public partial class Table
    {
        
        
        public class InsuranceMetaData
        {
            [DisplayName("First Name")]
            public string FirstName { get; set; }
            [DisplayName("Last Name")]
            public string LastName { get; set; }
            [DisplayName("Email Add")]
            public string EmailAddress { get; set; }
            [DisplayName("Date of Birth")]
            public System.DateTime DateOfBirth { get; set; }
            [DisplayName("Cay Year")]
            public int CarYear { get; set; }
            [DisplayName("Car Make")]
            public string CarMake { get; set; }
            [DisplayName("Car Model")]
            public string CarModel { get; set; }
            [DisplayName("DUI")]
            public bool DUI { get; set; }
            [DisplayName("Speeding Tickets")]
            public int SpeedingTickets { get; set; }
            [DisplayName("Coverage Type")]
            public bool CoverageTypre { get; set; }
            [DisplayName("Qoute")]
            public decimal Qoute { get; set; }
            
        }
    }
}