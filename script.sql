USE [Mbarber]
GO
/****** Object:  Table [dbo].[Agendamentos]    Script Date: 10/04/2018 22:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Agendamentos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[DataHora] [datetime] NOT NULL,
	[ClienteId] [int] NOT NULL,
 CONSTRAINT [PK_Agendamentos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Avaliacoes]    Script Date: 10/04/2018 22:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Avaliacoes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nota] [varchar](5) NOT NULL,
	[Descricao] [varchar](max) NULL,
	[ServicoId] [int] NOT NULL,
 CONSTRAINT [PK_Avaliacoes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 10/04/2018 22:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cpf] [varchar](14) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Sobrenome] [varchar](100) NOT NULL,
	[Telefone] [varchar](50) NOT NULL,
	[EnderecoId] [int] NOT NULL,
	[LoginId] [uniqueidentifier] NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Empresas]    Script Date: 10/04/2018 22:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empresas](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cnpj] [varchar](50) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[NomeReduzido] [varchar](50) NOT NULL,
	[EnderecoId] [int] NOT NULL,
 CONSTRAINT [PK_Empresas] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Enderecos]    Script Date: 10/04/2018 22:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Enderecos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Cep] [varchar](10) NOT NULL,
	[Logradouro] [varchar](150) NOT NULL,
	[Numero] [varchar](20) NOT NULL,
	[Complemento] [varchar](150) NULL,
	[Bairro] [varchar](50) NOT NULL,
	[Cidade] [varchar](50) NOT NULL,
	[Estado] [varchar](50) NOT NULL,
 CONSTRAINT [PK_Enderecos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Logins]    Script Date: 10/04/2018 22:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Logins](
	[Id] [uniqueidentifier] NOT NULL,
	[Email] [varchar](50) NOT NULL,
	[Senha] [varchar](100) NOT NULL,
	[DataInclusao] [datetime] NOT NULL,
 CONSTRAINT [PK_Logins] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Servicos]    Script Date: 10/04/2018 22:26:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Servicos](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[AgendamentoId] [int] NOT NULL,
	[EmpresaId] [int] NOT NULL,
	[Valor] [smallmoney] NOT NULL,
 CONSTRAINT [PK_Servicos] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Logins] ([Id], [Email], [Senha], [DataInclusao]) VALUES (N'e76d163c-e1b2-464f-aa78-719d4e438cb6', N'email@email.com', N'0c-83-f5-7c-78-6a-0b-4a-39-ef-ab-23-73-1c-7e-bc', CAST(N'2018-01-01T00:00:00.000' AS DateTime))
ALTER TABLE [dbo].[Agendamentos]  WITH CHECK ADD  CONSTRAINT [FK_Agendamentos_Clientes] FOREIGN KEY([ClienteId])
REFERENCES [dbo].[Clientes] ([Id])
GO
ALTER TABLE [dbo].[Agendamentos] CHECK CONSTRAINT [FK_Agendamentos_Clientes]
GO
ALTER TABLE [dbo].[Avaliacoes]  WITH CHECK ADD  CONSTRAINT [FK_Avaliacoes_Servicos] FOREIGN KEY([ServicoId])
REFERENCES [dbo].[Servicos] ([Id])
GO
ALTER TABLE [dbo].[Avaliacoes] CHECK CONSTRAINT [FK_Avaliacoes_Servicos]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Enderecos] FOREIGN KEY([EnderecoId])
REFERENCES [dbo].[Enderecos] ([Id])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Enderecos]
GO
ALTER TABLE [dbo].[Clientes]  WITH CHECK ADD  CONSTRAINT [FK_Clientes_Logins] FOREIGN KEY([LoginId])
REFERENCES [dbo].[Logins] ([Id])
GO
ALTER TABLE [dbo].[Clientes] CHECK CONSTRAINT [FK_Clientes_Logins]
GO
ALTER TABLE [dbo].[Empresas]  WITH CHECK ADD  CONSTRAINT [FK_Empresas_Enderecos] FOREIGN KEY([EnderecoId])
REFERENCES [dbo].[Enderecos] ([Id])
GO
ALTER TABLE [dbo].[Empresas] CHECK CONSTRAINT [FK_Empresas_Enderecos]
GO
ALTER TABLE [dbo].[Servicos]  WITH CHECK ADD  CONSTRAINT [FK_Servicos_Agendamentos] FOREIGN KEY([AgendamentoId])
REFERENCES [dbo].[Agendamentos] ([Id])
GO
ALTER TABLE [dbo].[Servicos] CHECK CONSTRAINT [FK_Servicos_Agendamentos]
GO
ALTER TABLE [dbo].[Servicos]  WITH CHECK ADD  CONSTRAINT [FK_Servicos_Empresas] FOREIGN KEY([EmpresaId])
REFERENCES [dbo].[Empresas] ([Id])
GO
ALTER TABLE [dbo].[Servicos] CHECK CONSTRAINT [FK_Servicos_Empresas]
GO
