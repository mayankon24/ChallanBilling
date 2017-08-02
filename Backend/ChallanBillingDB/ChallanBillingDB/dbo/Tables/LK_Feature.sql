CREATE TABLE [dbo].[LK_Feature] (
    [Feature_Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Feature_Name]        NVARCHAR (100) NULL,
    [Feature_Description] NVARCHAR (500) NULL,
    [IsActive]            BIT            NOT NULL,
    CONSTRAINT [PK_M_Feature] PRIMARY KEY CLUSTERED ([Feature_Id] ASC)
);

