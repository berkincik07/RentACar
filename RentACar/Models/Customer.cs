//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RentACar.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Customer()
        {
            this.Rental = new HashSet<Rental>();
        }
    
        public string customerId { get; set; }
        public string customerName { get; set; }
        public System.DateTime customerBirthDate { get; set; }
        public string customerMail { get; set; }
        public string customerPhoto { get; set; }
        public string customerPassword { get; set; }
        public int Admin { get; set; }

        public string customerUsername { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rental> Rental { get; set; }
    }
}
