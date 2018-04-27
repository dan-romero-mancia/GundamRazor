using System.Collections.Generic;

namespace GundamRazor.Models {
    public class ModelKit {
        public enum GradeEnum {
            HG, HGUC, RG, MG, RE, PG
        }

        public int ModelKitID { get; set; }
        public GradeEnum Grade { get; set; }

        // Foreign Key
        public MobileSuit MobileSuit { get; set; }
        public ICollection<WishlistItem> WishlistItems { get; set; }
        public ICollection<ModelWebpage> ModelWebpages { get; set; }
    }
}