CREATE TABLE [dbo].[Information] (
    [Id] INT IDENTITY (1, 1) NOT NULL,
    [Site_Location] VARCHAR (50) NULL,
    [Date_Created]            VARCHAR (50) NULL,
    [Completed_By]    VARCHAR (50) NULL,
    [Supervisor]      VARCHAR (50) NULL,
    [Inspector]       VARCHAR (50) NULL,
    [Job_Description] VARCHAR (50) NULL,
    [Type_of_Job]            VARCHAR (50) NULL,
    [Work_Area]       VARCHAR (50) NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
);

