
namespace GundamRazor.Models {
    public class WishlistItem {
        public int ModelKitID { get; set; }
        public ModelKit ModelKit { get; set; }
        public int GundamUserID { get; set; }
        public GundamUser GundamUser { get; set; }
    }
}
