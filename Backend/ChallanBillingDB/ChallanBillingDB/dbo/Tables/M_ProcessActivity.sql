CREATE TABLE [dbo].[M_ProcessActivity] (
    [Process_Id]          BIGINT         NOT NULL,
    [Request_Id]          BIGINT         NULL,
    [Tool_Id]             INT            NULL,
    [Request_Type_Id]     INT            NOT NULL,
    [Action_By]           NVARCHAR (100) NOT NULL,
    [Action_Time]         DATETIME       NOT NULL,
    [Request]             NVARCHAR (MAX) NULL,
    [Response]            NVARCHAR (MAX) NULL,
    [Status_Id]           INT            NULL,
    [CreatedBy]           NVARCHAR (100) NULL,
    [CreatedUTCDate]      DATETIME       NULL,
    [LastModifiedBy]      NVARCHAR (100) NULL,
    [LastModifiedUTCDate] DATETIME       NULL,
    [IsActive]            BIT            NOT NULL,
    [SysStartTime]        DATETIME2 (7)  NOT NULL,
    [SysEndTime]          DATETIME2 (7)  NOT NULL
);

