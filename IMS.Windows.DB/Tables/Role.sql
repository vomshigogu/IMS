CREATE TABLE [dbo].[Role]
(
	[Id]             INT             NOT NULL    PRIMARY KEY Identity(1,1),
	[Name]			 VARCHAR(50)         NULL,
	[Code]           VARCHAR(50)         NULL,
	[CreatedBy]      INT                 NULL,
	[CreatedOn]      DATETIME            NULL,
	[ModifiedBy]     INT                 NULL,
	[ModifiedOn]     DATETIME            NULL,
	[IsActive]       BIT                 NULL
)
