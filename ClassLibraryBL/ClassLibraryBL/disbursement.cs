//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClassLibraryBL
{
    using System;
    using System.Runtime.Serialization;
    using System.Collections.Generic;
    
    [DataContract(IsReference = true)]
    [KnownType(typeof(department))]
    [KnownType(typeof(disbursement_item))]
    
    public partial class disbursement
    {
        public disbursement()
        {
            this.disbursement_item = new HashSet<disbursement_item>();
        }
    
    	[DataMember]
        public int disbursementId { get; set; }
    	[DataMember]
        public string departmentId { get; set; }
    	[DataMember]
        public System.DateTime collectDate { get; set; }
    	[DataMember]
        public string status { get; set; }
    
    	[DataMember]
        public virtual department department { get; set; }
    	[DataMember]
        public virtual ICollection<disbursement_item> disbursement_item { get; set; }
    }
}
