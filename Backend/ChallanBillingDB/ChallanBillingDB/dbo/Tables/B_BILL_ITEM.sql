CREATE TABLE [dbo].[B_BILL_ITEM] (
    [Bill_Item_Id]             INT             IDENTITY (1, 1) NOT NULL,
    [Bill_Id]                  INT             NULL,
    [Purchase_Order_Detail_Id] INT             NULL,
    [Item_Name]                NVARCHAR (150)  NULL,
    [Quantity]                 FLOAT (53)      NULL,
    [Form]                     DECIMAL (10, 4) NULL,
    [Rate]                     DECIMAL (10, 4) NULL,
    [Color]                    INT             NULL,
    [Parent_Id]                INT             NULL,
    [Item_Id]                  INT             NULL,
    CONSTRAINT [PK_B_BILL_ITEM] PRIMARY KEY CLUSTERED ([Bill_Item_Id] ASC),
    CONSTRAINT [FK_B_BILL_ITEM_B_BILL] FOREIGN KEY ([Bill_Id]) REFERENCES [dbo].[B_BILL] ([Bill_Id]),
    CONSTRAINT [FK_B_BILL_ITEM_M_PURCHASES_ORDER_DETAIL] FOREIGN KEY ([Purchase_Order_Detail_Id]) REFERENCES [dbo].[M_PURCHASES_ORDER_DETAIL] ([Purchase_Order_Detail_Id])
);

