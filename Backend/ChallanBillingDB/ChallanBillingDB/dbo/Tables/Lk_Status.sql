CREATE TABLE [dbo].[Lk_Status] (
    [Status_Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Status_Name] NVARCHAR (50) NULL,
    [IsActive]    BIT           NOT NULL,
    CONSTRAINT [PK_Lk_Status] PRIMARY KEY CLUSTERED ([Status_Id] ASC)
);

