CREATE TABLE [dbo].[Employees] (
    [firstName]       NVARCHAR (128) NOT NULL,
    [lastName]        NVARCHAR (MAX) NULL,
    [email]           NVARCHAR (MAX) NULL,
    [phoneNumber]     NVARCHAR (MAX) NULL,
    [ApplicationId]   NVARCHAR (128) NULL,
    [employeeAddress] NVARCHAR (MAX) NULL,
    CONSTRAINT [PK_dbo.Employees] PRIMARY KEY CLUSTERED ([firstName] ASC),
    CONSTRAINT [FK_dbo.Employees_dbo.AspNetUsers_ApplicationId] FOREIGN KEY ([ApplicationId]) REFERENCES [dbo].[AspNetUsers] ([Id])
);


GO
CREATE NONCLUSTERED INDEX [IX_ApplicationId]
    ON [dbo].[Employees]([ApplicationId] ASC);

