using System.Collections.Generic;

namespace ParksLookup.Models
{
    public class NativeSpecies
    {
        public NativeSpecies()
        {
            this.Park = new HashSet<NativeSpeciesPark>();
        }
        public int NativeSpeciesId { get; set; }
        public string Kingdom { get; set; }
        public string Class { get; set; }
        public string Species { get; set; }
        public string CommonName { get; set; }
        public string SpeciesDescription { get; set; }
        public string ConservationStatus { get; set; }
        public ICollection<NativeSpeciesPark> Park { get; }
    }

}