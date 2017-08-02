CREATE TABLE [dbo].[B_TAX_AMOUNT] (
    [Tax_Amout_Id] INT             IDENTITY (1, 1) NOT NULL,
    [Tax_Amout]    DECIMAL (10, 4) NULL,
    [Tax_Name]     NVARCHAR (50)   NULL,
    CONSTRAINT [PK_B_TAX_AMOUNT] PRIMARY KEY CLUSTERED ([Tax_Amout_Id] ASC)
);

