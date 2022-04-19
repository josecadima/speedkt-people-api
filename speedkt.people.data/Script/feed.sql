
-- Create Person table

CREATE TABLE [dbo].[Person] (
    [PersonId]	UNIQUEIDENTIFIER NOT NULL,
    [FirstName]	NVARCHAR (50) NOT NULL,
    [LastName]	NVARCHAR (50)   NOT NULL,
    [NickName]	NVARCHAR (50)    NULL,
	[AvatarId]	UNIQUEIDENTIFIER NULL,	
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonId] ASC)
);
