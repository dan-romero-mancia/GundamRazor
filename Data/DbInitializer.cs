using GundamRazor.Models;
using System;
using System.Linq;

namespace GundamRazor.Data {
    public static class DbInitializer {
        public static void Initialize(GundamContext context) {
            if (!context.MobileSuits.Any()) {
                var suits = new MobileSuit[] {
                    new MobileSuit{MobileSuitID=1, SuitName="Gundam", SuitNumber="RX-78-2", Series="Mobile Suit Gundam", Universe="UC"},
                    new MobileSuit{MobileSuitID=2, SuitName="Char's Zaku II", SuitNumber="MS-06S", Series="Mobile Suit Gundam", Universe="UC"},
                    new MobileSuit{MobileSuitID=3, SuitName="Turn A Gundam", SuitNumber="WD-M01", Series="Turn A Gundam", Universe="CC"}
                };

                foreach (MobileSuit ms in suits) {
                    context.Add(ms);
                }

                context.SaveChanges();
            }

            if (!context.Websites.Any()) {
                var websites = new Website[] {
                    new Website{WebsiteID=1, WebsiteName="Amazon", Url="https://www.amazon.com"},
                    new Website{WebsiteID=2, WebsiteName="HobbySearch", Url="https://www.1999.co.jp/eng/gundam/"},
                    new Website{WebsiteID=3, WebsiteName="HobbyLink", Url="https://hlj.com/"}
                };

                foreach (Website w in websites) {
                    context.Add(w);
                }

                context.SaveChanges();
            }

            if (!context.ModelKits.Any()) {
                var modelKits = new ModelKit[] {
                    new ModelKit{ModelKitID=1, Grade=ModelKit.GradeEnum.HGUC, MobileSuit=context.MobileSuits.Find(1)},
                    new ModelKit{ModelKitID=2, Grade=ModelKit.GradeEnum.MG, MobileSuit=context.MobileSuits.Find(1)},
                    new ModelKit{ModelKitID=3, Grade=ModelKit.GradeEnum.HG, MobileSuit=context.MobileSuits.Find(2)},
                    new ModelKit{ModelKitID=4, Grade=ModelKit.GradeEnum.MG, MobileSuit=context.MobileSuits.Find(3)}
                };

                foreach (ModelKit mk in modelKits) {
                    context.Add(mk);
                }

                context.SaveChanges();
            }

            if (!context.GundamUsers.Any()) {
                var gundamUsers = new GundamUser[] {
                    new GundamUser{GundamUserID=1, Email="CoolDude@example.com", Password="password", Username="CoolDude"},
                    new GundamUser{GundamUserID=2, Email="charaznable@zeon.net", Password="password", Username="Char"}
                };

                foreach (GundamUser gu in gundamUsers) {
                    context.Add(gu);
                }

                context.SaveChanges();
            }

            if (!context.ModelWebpages.Any()) {
                var ModelWebpages = new ModelWebpage[] {
                    new ModelWebpage{ModelWebpageID=1, Url="https://www.amazon.ca/Bandai-Hobby-Gundam-RX-78-2-Version/dp/B00CRSXK4Q/", Price=80.59, Website=context.Websites.Find(1), ModelKit=context.ModelKits.Find(2)},
                    new ModelWebpage{ModelWebpageID=2, Url="https://www.amazon.ca/Bandai-Hobby-RX-78-2-Gundam-Revive/dp/B00WW4F8YA", Price=24.12, Website=context.Websites.Find(1), ModelKit=context.ModelKits.Find(1)},
                    new ModelWebpage{ModelWebpageID=3, Url="https://www.amazon.ca/MS-06S-Char-Mobile-Gundam-ORIGIN/dp/B00T41F4P2", Price=23.92, Website=context.Websites.Find(1), ModelKit=context.ModelKits.Find(3)},
                    new ModelWebpage{ModelWebpageID=4, Url="https://www.amazon.ca/Gundam-WD-M01-Turn-100-Scale/dp/B000RHKZLU", Price=54.57, Website=context.Websites.Find(1), ModelKit=context.ModelKits.Find(4)}
                };
            }
        }
    }
}