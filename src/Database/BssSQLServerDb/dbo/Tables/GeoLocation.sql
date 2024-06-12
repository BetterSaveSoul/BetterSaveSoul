CREATE TABLE [dbo].[GeoLocation]
(
	LocationID INT FOREIGN KEY REFERENCES Location(LocationID),
    Latitude DECIMAL(9,6),
    Longitude DECIMAL(9,6),
    PRIMARY KEY (LocationID)
)
