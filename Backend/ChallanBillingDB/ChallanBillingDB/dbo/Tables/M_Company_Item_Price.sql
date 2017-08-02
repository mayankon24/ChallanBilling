CREATE TABLE [dbo].[M_Company_Item_Price] (
    [Company_Item_Id] INT             IDENTITY (1, 1) NOT NULL,
    [Company_Id]      INT             NULL,
    [Item_Id]         INT             NULL,
    [Item_Price]      DECIMAL (10, 4) NULL,
    CONSTRAINT [PK_M_Company_Item_Price] PRIMARY KEY CLUSTERED ([Company_Item_Id] ASC)
);

