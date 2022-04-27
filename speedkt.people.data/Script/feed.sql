
-- Create Person table

CREATE TABLE [dbo].[Person] (
    [PersonId]	UNIQUEIDENTIFIER NOT NULL,
    [FirstName]	NVARCHAR (50) NOT NULL,
    [LastName]	NVARCHAR (50)   NOT NULL,
    [NickName]	NVARCHAR (50)    NULL,
	[AvatarId]	UNIQUEIDENTIFIER NULL,	
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonId] ASC)
);

CREATE TABLE [dbo].[Account] (
    [AccountId] UNIQUEIDENTIFIER NOT NULL,
    [PersonId]	UNIQUEIDENTIFIER NOT NULL,
    [Auth0Id]   NVARCHAR (255) NOT NULL,
    CONSTRAINT [PK_Account] PRIMARY KEY CLUSTERED ([AccountId] ASC)
);

ALTER TABLE [dbo].[Account] 
ADD CONSTRAINT FK_Account_Person FOREIGN KEY (PersonId) REFERENCES [dbo].[Person](PersonId);

ALTER TABLE [dbo].[Account] 
ADD CONSTRAINT UC_Auth0Id UNIQUE(Auth0Id);
