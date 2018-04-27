using System.Collections.Generic;

namespace GundamRazor.Models {
    public class GundamUser {
        public int GundamUserID { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Username { get; set; }

        public ICollection<WishlistItem> WishlistItems { get; set; }
    }
}