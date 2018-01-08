CREATE TABLE [dbo].[User] (
    [Id]          INT       IDENTITY (1, 1) NOT NULL,
    [Lastname]        CHAR (30) NULL,
    [Firstname]      CHAR (30) NULL,
    [Password]    CHAR (30) NULL,
    [Email]       CHAR (50) NULL,
    [HighSchool]  CHAR (30) NULL,
    [Institution] CHAR (30) NULL,
    [Domain]      CHAR (30) NULL,
    [Filiere]     CHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);