using System.Collections.Generic;

namespace GundamRazor.Models {
    public class Website {
        public int WebsiteID { get; set; }
        public string Url { get; set; }
        public string WebsiteName { get; set; }

        public ICollection<ModelWebpage> ModelWebpages { get; set; }
    }
}