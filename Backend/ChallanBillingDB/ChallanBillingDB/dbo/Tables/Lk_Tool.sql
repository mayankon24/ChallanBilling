CREATE TABLE [dbo].[Lk_Tool] (
    [Tool_Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Tool_Name] NVARCHAR (50) NULL,
    [IsActive]  BIT           NOT NULL,
    CONSTRAINT [PK_Lk_Tool] PRIMARY KEY CLUSTERED ([Tool_Id] ASC)
);

