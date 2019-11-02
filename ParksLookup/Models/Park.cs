using System.Collections.Generic;
namespace ParksLookup.Models
{
    public class Park
    {
        public Park()
        {
            this.NativeSpecies = new HashSet<NativeSpeciesPark>();
        }
        public int ParkId { get; set; }
        public string ParkName { get; set; }  
        public string ParkType { get; set; }
        public string ParkLocation { get; set; }
        public string ParkSize { get; set; }
        public string ParkFounded { get; set; }
        public ICollection<NativeSpeciesPark> NativeSpecies { get; }
    }
}