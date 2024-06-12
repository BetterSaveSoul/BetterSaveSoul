CREATE TABLE [dbo].[PetHealthStatus]
(
	PetHealthStatusID SMALLINT PRIMARY KEY,
    HealthStatus NVARCHAR(255) NOT NULL,
	AHealthStatus NVARCHAR(255) NOT NULL
)
