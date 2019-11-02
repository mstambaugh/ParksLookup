using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System;
namespace ParksLookup.Models
{
    public class Park
    {
        public Park()
        {
            this.NativeSpecies = new HashSet<NativeSpecies>();
        }
        public int ParkId { get; set; }

        public string ParkName { get; set; }  
        public string ParkType { get; set; }
        public string ParkLocation { get; set; }
        public string ParkSize { get; set; }
        public string ParkFounded { get; set; }
        public virtual ICollection<NativeSpecies> NativeSpecies { get; set; }
        
    }
}