CREATE TABLE [dbo].[TbContatos]
(
	[Id]       INT            IDENTITY (1, 1) NOT NULL,
    [nome]     NCHAR (50)     NOT NULL,
    [email]    NCHAR (50)     NOT NULL,
    [telefone] VARBINARY (13) NOT NULL,
    [empresa]  NCHAR (50)     NULL,
    [cargo]    NCHAR (50)     NULL,
    PRIMARY KEY CLUSTERED ([Id] ASC)
)
