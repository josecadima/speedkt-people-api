
-- Create Person table

CREATE TABLE [dbo].[Person] (
    [PersonID]	UNIQUEIDENTIFIER NOT NULL,
    [FirstName]	NVARCHAR (50) NOT NULL,
    [LastName]	NVARCHAR (50)   NOT NULL,
    [NickName]	NVARCHAR (50)    NULL,
	[AvatarID]	UNIQUEIDENTIFIER NULL,	
    CONSTRAINT [PK_Person] PRIMARY KEY CLUSTERED ([PersonID] ASC)
);
