CREATE TABLE [dbo].[Feature_Role_Permission] (
    [Role_Id]             INT            NOT NULL,
    [Feature_Id]          INT            NOT NULL,
    [CreatedUTCDate]      DATETIME       NULL,
    [LastModifiedBy]      NVARCHAR (100) NULL,
    [LastModifiedUTCDate] DATETIME       NULL,
    [IsActive]            BIT            NULL,
    CONSTRAINT [PK_Feature_Role_Permission] PRIMARY KEY CLUSTERED ([Feature_Id] ASC, [Role_Id] ASC),
    CONSTRAINT [FK_Feature_Role_Permission_LK_Feature] FOREIGN KEY ([Feature_Id]) REFERENCES [dbo].[LK_Feature] ([Feature_Id]),
    CONSTRAINT [FK_Feature_Role_Permission_Lk_Role] FOREIGN KEY ([Role_Id]) REFERENCES [dbo].[Lk_Role] ([Role_Id])
);

