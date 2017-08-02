CREATE TABLE [dbo].[Lk_Request_Type] (
    [Request_Type_Id]   INT           IDENTITY (1, 1) NOT NULL,
    [Request_Type_Name] NVARCHAR (50) NULL,
    [IsActive]          BIT           NOT NULL,
    CONSTRAINT [PK_Lk_Request_Type] PRIMARY KEY CLUSTERED ([Request_Type_Id] ASC)
);

