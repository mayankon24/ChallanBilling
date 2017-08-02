CREATE TABLE [dbo].[B_BillItem_Narration] (
    [BillItem_Narration_Id] INT             IDENTITY (1, 1) NOT NULL,
    [Bill_Item_Id]          INT             NULL,
    [Narration]             NVARCHAR (1000) NULL,
    CONSTRAINT [PK_B_BillItem_Narration] PRIMARY KEY CLUSTERED ([BillItem_Narration_Id] ASC),
    CONSTRAINT [FK_B_BillItem_Narration_B_BILL_ITEM] FOREIGN KEY ([Bill_Item_Id]) REFERENCES [dbo].[B_BILL_ITEM] ([Bill_Item_Id])
);

