CREATE TABLE [dbo].[Lk_Role] (
    [Role_Id]             INT            IDENTITY (1, 1) NOT NULL,
    [SecurityGroup_Id]    NVARCHAR (50)  NULL,
    [SecurityGroup_Name]  NVARCHAR (50)  NULL,
    [Role_Name]           NVARCHAR (50)  NULL,
    [CreatedBy]           NVARCHAR (100) NULL,
    [CreatedUTCDate]      DATETIME       NULL,
    [LastModifiedBy]      NVARCHAR (100) NULL,
    [LastModifiedUTCDate] DATETIME       NULL,
    [IsActive]            BIT            NOT NULL,
    CONSTRAINT [PK_Lk_Role] PRIMARY KEY CLUSTERED ([Role_Id] ASC)
);

