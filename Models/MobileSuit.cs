using System;
using System.Collections.Generic;

namespace GundamRazor.Models {
    public class MobileSuit {
        public int MobileSuitID { get; set; }
        public string SuitName { get; set; }
        public string SuitNumber { get; set; }
        public string Series { get; set; }
        public string Universe { get; set; }

        public ICollection<ModelKit> ModelKits { get; set; }
    }
}