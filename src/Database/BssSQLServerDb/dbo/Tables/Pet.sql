CREATE TABLE [dbo].[Pet]
(
	PetID BIGINT PRIMARY KEY,
    Name NVARCHAR(100),
    SpeciesID INT FOREIGN KEY REFERENCES Species(SpeciesID) NOT NULL,
    BreedID INT,
    DateOfBirth DATE NOT NULL,
    Gender SMALLINT FOREIGN KEY REFERENCES Gender(GenderID),
    Color NVARCHAR(50),
    Size NVARCHAR(10),
    HealthStatus  SMALLINT FOREIGN KEY REFERENCES PetHealthStatus(PetHealthStatusID) NOT NULL,
    Vaccinated BIT NOT NULL,
    NeuteredStatus BIT NOT NULL,
    Description NVARCHAR(255),
    OwnerProfileID INT FOREIGN KEY REFERENCES UserProfile(UserID),
    FOREIGN KEY (BreedID, SpeciesID) REFERENCES Breed(BreedID, SpeciesID)
)
