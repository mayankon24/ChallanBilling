CREATE TABLE [dbo].[M_Process] (
    [Process_Id]          BIGINT                                      IDENTITY (1, 1) NOT NULL,
    [Request_Id]          BIGINT                                      NULL,
    [Tool_Id]             INT                                         NULL,
    [Request_Type_Id]     INT                                         NOT NULL,
    [Action_By]           NVARCHAR (100)                              NOT NULL,
    [Action_Time]         DATETIME                                    NOT NULL,
    [Request]             NVARCHAR (MAX)                              NULL,
    [Response]            NVARCHAR (MAX)                              NULL,
    [Status_Id]           INT                                         NULL,
    [CreatedBy]           NVARCHAR (100)                              NULL,
    [CreatedUTCDate]      DATETIME                                    NULL,
    [LastModifiedBy]      NVARCHAR (100)                              NULL,
    [LastModifiedUTCDate] DATETIME                                    NULL,
    [IsActive]            BIT                                         NOT NULL,
    [SysStartTime]        DATETIME2 (7) GENERATED ALWAYS AS ROW START NOT NULL,
    [SysEndTime]          DATETIME2 (7) GENERATED ALWAYS AS ROW END   NOT NULL,
    PRIMARY KEY CLUSTERED ([Process_Id] ASC),
    CONSTRAINT [FK_M_Process_Lk_Request_Type] FOREIGN KEY ([Request_Type_Id]) REFERENCES [dbo].[Lk_Request_Type] ([Request_Type_Id]),
    CONSTRAINT [FK_M_Process_Lk_Status] FOREIGN KEY ([Status_Id]) REFERENCES [dbo].[Lk_Status] ([Status_Id]),
    CONSTRAINT [FK_M_Process_Lk_Tool] FOREIGN KEY ([Tool_Id]) REFERENCES [dbo].[Lk_Tool] ([Tool_Id]),
    CONSTRAINT [FK_M_Process_M_Request] FOREIGN KEY ([Request_Id]) REFERENCES [dbo].[M_Request] ([Request_Id]),
    CONSTRAINT [UQ_RequestId_ToolId] UNIQUE NONCLUSTERED ([Request_Id] ASC, [Tool_Id] ASC),
    PERIOD FOR SYSTEM_TIME ([SysStartTime], [SysEndTime])
)
WITH (SYSTEM_VERSIONING = ON (HISTORY_TABLE=[dbo].[M_ProcessActivity], DATA_CONSISTENCY_CHECK=ON));

