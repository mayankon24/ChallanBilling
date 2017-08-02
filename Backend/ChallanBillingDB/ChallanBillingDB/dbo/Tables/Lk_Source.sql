CREATE TABLE [dbo].[Lk_Source] (
    [Source_Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Source_Name] NVARCHAR (50) NULL,
    [IsActive]    BIT           NOT NULL,
    CONSTRAINT [PK_Lk_Source] PRIMARY KEY CLUSTERED ([Source_Id] ASC)
);

