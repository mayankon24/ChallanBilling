CREATE TABLE [dbo].[M_DELIVERY_DETAIL] (
    [Delivery_Detail_Id]       INT        IDENTITY (1, 1) NOT NULL,
    [Delivery_Id]              INT        NULL,
    [Purchase_Order_Detail_Id] INT        NULL,
    [Deliver_Quantity]         FLOAT (53) NULL,
    CONSTRAINT [PK_M_DELIVERY_DETAIL] PRIMARY KEY CLUSTERED ([Delivery_Detail_Id] ASC),
    CONSTRAINT [FK_M_DELIVERY_DETAIL_M_DELIVERY] FOREIGN KEY ([Delivery_Id]) REFERENCES [dbo].[M_DELIVERY] ([Delivery_Id]),
    CONSTRAINT [FK_M_DELIVERY_DETAIL_M_PURCHASES_ORDER_DETAIL] FOREIGN KEY ([Purchase_Order_Detail_Id]) REFERENCES [dbo].[M_PURCHASES_ORDER_DETAIL] ([Purchase_Order_Detail_Id])
);

