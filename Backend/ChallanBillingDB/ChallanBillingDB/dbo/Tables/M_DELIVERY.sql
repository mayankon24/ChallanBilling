CREATE TABLE [dbo].[M_DELIVERY] (
    [Delivery_Id]        INT           IDENTITY (1, 1) NOT NULL,
    [Company_id]         INT           NULL,
    [Purchases_Order_Id] INT           NULL,
    [Delivery_No]        NVARCHAR (50) NULL,
    [Delivery_Date]      DATETIME      NULL,
    [Delivery_No_Code]   INT           NULL,
    [Future1]            NCHAR (10)    NULL,
    [future2]            NCHAR (10)    NULL,
    [book_no]            INT           NULL,
    CONSTRAINT [PK_M_DELIVERY] PRIMARY KEY CLUSTERED ([Delivery_Id] ASC),
    CONSTRAINT [FK_M_DELIVERY_M_COMPANY] FOREIGN KEY ([Company_id]) REFERENCES [dbo].[M_COMPANY] ([Company_id]),
    CONSTRAINT [FK_M_DELIVERY_M_PURCHASES_ORDER] FOREIGN KEY ([Purchases_Order_Id]) REFERENCES [dbo].[M_PURCHASES_ORDER] ([Purchases_Order_Id])
);

