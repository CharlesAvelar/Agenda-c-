

CREATE TABLE [dbo].[Agenda](
   [id] [int] IDENTITY(1,1) NOT NULL,
   [nome] [nvarchar](50) NULL,
   [endereco] [nvarchar](50) NULL,
   [cidade] [nvarchar](50) NULL,
   [estado] [nvarchar](50) NULL,
   [pais] [nvarchar](50) NULL,
   [telefone] [nvarchar](50) NULL,
   [email] [nvarchar](100) NULL,
CONSTRAINT [PK_Agenda] PRIMARY KEY CLUSTERED 
(
[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO