namespace GundamRazor.Models {
    public class ModelWebpage {
        public int ModelWebpageID { get; set; }
        public string Url { get; set; }
        public double Price { get; set; }

        public ModelKit ModelKit { get; set; }
        public Website Website { get; set; }
    }
}