CREATE TABLE [dbo].[Item] (
    [Item_Id]   INT            IDENTITY (1, 1) NOT NULL,
    [Item_Name] NVARCHAR (MAX) NULL,
    [HSN_Code]  NVARCHAR (50)  NULL,
    CONSTRAINT [PK_Item] PRIMARY KEY CLUSTERED ([Item_Id] ASC)
);

