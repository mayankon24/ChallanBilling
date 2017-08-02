CREATE TABLE [dbo].[B_BILL_DETAIL] (
    [Bill_Detail_Id]     INT        IDENTITY (1, 1) NOT NULL,
    [Bill_Item_Id]       INT        NULL,
    [Delivery_Detail_Id] INT        NULL,
    [Quantity]           FLOAT (53) NULL,
    CONSTRAINT [PK_B_BILL_DETAIL] PRIMARY KEY CLUSTERED ([Bill_Detail_Id] ASC),
    CONSTRAINT [FK_B_BILL_DETAIL_B_BILL_ITEM] FOREIGN KEY ([Bill_Item_Id]) REFERENCES [dbo].[B_BILL_ITEM] ([Bill_Item_Id]),
    CONSTRAINT [FK_B_BILL_DETAIL_M_DELIVERY_DETAIL] FOREIGN KEY ([Delivery_Detail_Id]) REFERENCES [dbo].[M_DELIVERY_DETAIL] ([Delivery_Detail_Id])
);

