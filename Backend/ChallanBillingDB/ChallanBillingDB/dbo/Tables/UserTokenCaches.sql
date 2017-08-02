CREATE TABLE [dbo].[UserTokenCaches] (
    [UserTokenCacheId] INT             IDENTITY (1, 1) NOT NULL,
    [webUserUniqueId]  NVARCHAR (MAX)  NULL,
    [cacheBits]        VARBINARY (MAX) NULL,
    [LastWrite]        DATETIME        NOT NULL,
    CONSTRAINT [PK_dbo.UserTokenCaches] PRIMARY KEY CLUSTERED ([UserTokenCacheId] ASC)
);

