﻿CREATE TABLE [dbo].[M_PURCHASES_ORDER_DETAIL] (
    [Purchase_Order_Detail_Id] INT             IDENTITY (1, 1) NOT NULL,
    [Purchases_Order_Id]       INT             NULL,
    [Item_Name]                NVARCHAR (100)  NULL,
    [Item_Quantity]            FLOAT (53)      NULL,
    [Item_Rate]                FLOAT (53)      NULL,
    [Total_Amount]             DECIMAL (10, 2) NULL,
    [future1]                  NCHAR (10)      NULL,
    [future2]                  NCHAR (10)      NULL,
    [Item_Id]                  INT             NULL,
    CONSTRAINT [PK_M_PURCHASES_ORDER_DETAIL] PRIMARY KEY CLUSTERED ([Purchase_Order_Detail_Id] ASC),
    CONSTRAINT [FK_M_PURCHASES_ORDER_DETAIL_M_PURCHASES_ORDER] FOREIGN KEY ([Purchases_Order_Id]) REFERENCES [dbo].[M_PURCHASES_ORDER] ([Purchases_Order_Id])
);

