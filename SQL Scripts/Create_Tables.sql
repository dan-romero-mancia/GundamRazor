

CREATE TABLE MobileSuits (
    MobileSuitID int,
    SuitName varchar(100),
    SuitNumber varchar(30),
    Series varchar(50),
    Universe varchar(10),
    PRIMARY KEY (MobileSuitID)
);

CREATE TABLE Websites(
    WebsiteID int,
    Url varchar(200),
    WebsiteName varchar(50),
    PRIMARY KEY (WebsiteID)
);

CREATE TABLE GundamUsers (
    GundamUserID int,
    Email varchar(100),
    Password varchar(50),
    Username varchar(25),
    PRIMARY KEY (GundamUserID)
);

CREATE TABLE ModelKits (
    ModelKitID int,
    Grade int,
    MobileSuitID int,
    PRIMARY KEY (ModelKitID),
    FOREIGN KEY (MobileSuitID) REFERENCES MobileSuits(MobileSuitID)
);

CREATE TABLE WishlistItems (
    GundamUserID int,
    ModelKitID int,
    CONSTRAINT PK_Wishlistitems PRIMARY KEY (GundamUserID, ModelKitID),
    FOREIGN KEY (GundamUserID) REFERENCES GundamUsers(GundamUserID),
    FOREIGN KEY (ModelKitID) REFERENCES ModelKits(ModelKitID)
);

CREATE TABLE ModelWebpages (
    ModelWebpageID int,
    Url varchar(200),
    Price float(6, 2),
    WebsiteID int,
    ModelKitID int,
    FOREIGN KEY (ModelKitID) REFERENCES ModelKits(ModelKitID),
    FOREIGN KEY (WebsiteID) REFERENCES Websites(WebsiteID)
);