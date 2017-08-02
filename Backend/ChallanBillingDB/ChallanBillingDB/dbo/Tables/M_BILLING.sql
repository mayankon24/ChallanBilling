CREATE TABLE [dbo].[M_BILLING] (
    [Bill_Id]            INT           IDENTITY (1, 1) NOT NULL,
    [Purchases_Order_Id] INT           NOT NULL,
    [Date]               DATETIME      NULL,
    [Bill_No]            NVARCHAR (20) NULL,
    CONSTRAINT [PK_M_BILLING] PRIMARY KEY CLUSTERED ([Bill_Id] ASC),
    CONSTRAINT [FK_M_BILLING_M_PURCHASES_ORDER] FOREIGN KEY ([Purchases_Order_Id]) REFERENCES [dbo].[M_PURCHASES_ORDER] ([Purchases_Order_Id])
);

