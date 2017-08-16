CREATE TABLE [dbo].[B_BILL] (
    [Bill_Id]                INT             IDENTITY (1, 1) NOT NULL,
    [Company_id]             INT             NULL,
    [Bill_No]                NVARCHAR (50)   NULL,
    [Bill_Type_Id]           INT             NULL,
    [Bill_Date]              DATETIME        NULL,
    [Tax_Percentage]         DECIMAL (5, 4)  NULL,
    [Is_Tax_Inclusive]       INT             NULL,
    [BillNo_Code]            INT             NULL,
    [Cartage]                DECIMAL (10, 4) NULL,
    [Discount]               DECIMAL (10, 4) NULL,
    [Tax_Name]               NVARCHAR (50)   NULL,
    [Central_Tax_percentage] DECIMAL (5, 2)  DEFAULT ((0)) NULL,
    [Central_Tax_Name]       NVARCHAR (50)   DEFAULT ('') NULL,
    CONSTRAINT [PK_B_BILL] PRIMARY KEY CLUSTERED ([Bill_Id] ASC),
    CONSTRAINT [FK_B_BILL_M_COMPANY] FOREIGN KEY ([Company_id]) REFERENCES [dbo].[M_COMPANY] ([Company_id])
);



