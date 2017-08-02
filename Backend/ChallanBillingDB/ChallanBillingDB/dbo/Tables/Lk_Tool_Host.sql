CREATE TABLE [dbo].[Lk_Tool_Host] (
    [Host_Id]             INT            IDENTITY (1, 1) NOT NULL,
    [Host_Name]           NVARCHAR (50)  NULL,
    [Tool_Id]             INT            NULL,
    [CreatedBy]           NVARCHAR (100) NULL,
    [CreatedUTCDate]      DATETIME       NULL,
    [LastModifiedBy]      NVARCHAR (100) NULL,
    [LastModifiedUTCDate] DATETIME       NULL,
    [IsActive]            BIT            NOT NULL,
    CONSTRAINT [PK_Lk_PRTG_Host] PRIMARY KEY CLUSTERED ([Host_Id] ASC)
);

