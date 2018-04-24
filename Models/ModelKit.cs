using System.Collections.Generic;

namespace GundamRazor.Models {
    public enum Grade {
        HG, HGUC, RG, MG, RE, PG
    }

    public class ModelKit {
        public int ModelKitID { get; set; }
        public Grade Grade { get; set; }

        // Foreign Key
        public MobileSuit MobileSuit { get; set; }
        public ICollection<GundamUser> GundamUsers { get; set; }
        public ICollection<ModelWebpage> ModelWebpages { get; set; }
    }
}