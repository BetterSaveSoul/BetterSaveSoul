CREATE TABLE [dbo].[UserProfile]
(
    UserID INT PRIMARY KEY,
    FirstName NVARCHAR(100) NOT NULL,
    LastName NVARCHAR(100) NOT NULL,
    DateOfBirth DATE NOT NULL,
    LocationID INT FOREIGN KEY REFERENCES Location(LocationID) NOT NULL,
    ProfilePicture NVARCHAR(MAX),
    Bio NVARCHAR(255),
    DateJoined DATETIME NOT NULL,
    IsActive BIT NOT NULL
)
