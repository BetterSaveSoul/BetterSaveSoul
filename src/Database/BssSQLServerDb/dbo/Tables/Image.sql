CREATE TABLE [dbo].[Image]
(
	ImageID INT PRIMARY KEY,
    ImageURL NVARCHAR(MAX) NOT NULL,
	Created [datetime2](7) NOT NULL
)
