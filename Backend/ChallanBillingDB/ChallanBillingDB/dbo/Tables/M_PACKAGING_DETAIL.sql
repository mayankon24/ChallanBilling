CREATE TABLE [dbo].[M_PACKAGING_DETAIL] (
    [Packaging_Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Delivery_Detail_Id]    INT            NULL,
    [Packaging_Description] NVARCHAR (500) NULL,
    CONSTRAINT [PK_M_PACKAGING_DETAIL] PRIMARY KEY CLUSTERED ([Packaging_Id] ASC),
    CONSTRAINT [FK_M_PACKAGING_DETAIL_M_DELIVERY_DETAIL] FOREIGN KEY ([Delivery_Detail_Id]) REFERENCES [dbo].[M_DELIVERY_DETAIL] ([Delivery_Detail_Id])
);

