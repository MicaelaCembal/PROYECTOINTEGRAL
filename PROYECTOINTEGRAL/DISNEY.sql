USE [DISNEY]
GO
/****** Object:  Table [dbo].[Pelicula]    Script Date: 19/10/2022 12:09:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Pelicula](
	[IdPelicula] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](1000) NULL,
	[FechaCreacion] [datetime] NULL,
	[Duracion] [float] NULL,
	[CantPeliculas] [int] NULL,
	[Imagen1] [varchar](50) NULL,
	[Imagen2] [varchar](50) NULL,
 CONSTRAINT [PK_Peliculas] PRIMARY KEY CLUSTERED 
(
	[IdPelicula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Personaje]    Script Date: 19/10/2022 12:09:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Personaje](
	[IdPersonaje] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](1000) NULL,
	[Vestimenta] [varchar](1000) NULL,
	[Imagen1] [varchar](50) NULL,
	[Imagen2] [varchar](50) NULL,
	[IdPelicula] [int] NULL,
	[IdSerie] [int] NULL,
 CONSTRAINT [PK_Personajes] PRIMARY KEY CLUSTERED 
(
	[IdPersonaje] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Serie]    Script Date: 19/10/2022 12:09:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Serie](
	[IdSerie] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [varchar](50) NULL,
	[Descripcion] [varchar](1000) NULL,
	[FechaCreacion] [datetime] NULL,
	[CantCapitulos] [int] NULL,
	[Imagen1] [varchar](50) NULL,
	[Imagen2] [varchar](50) NULL,
 CONSTRAINT [PK_Serie] PRIMARY KEY CLUSTERED 
(
	[IdSerie] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Pelicula] ON 

INSERT [dbo].[Pelicula] ([IdPelicula], [Nombre], [Descripcion], [FechaCreacion], [Duracion], [CantPeliculas], [Imagen1], [Imagen2]) VALUES (2, N'Toy Story', N'La franquicia se basa en el concepto antropomórfico de que todos los juguetes, sin conocimiento de los seres humanos, están secretamente vivos, y las películas se centran en un diverso grupo de juguetes que incluyen un vaquero clásico, el Sheriff Woody y el moderno astronauta Buzz Lightyear. ', CAST(N'1995-11-22T00:00:00.000' AS DateTime), 80, 4, N'TOYSTORY1.JPG', N'TOYSTORY2.JPG')
INSERT [dbo].[Pelicula] ([IdPelicula], [Nombre], [Descripcion], [FechaCreacion], [Duracion], [CantPeliculas], [Imagen1], [Imagen2]) VALUES (3, N'Buscando A Nemo', N'Marlin es un pez payaso que sobreprotege a su hijo Nemo, debido a una tragedia que les costó la vida a su esposa y a sus crías. El primer día de colegio, Nemo decide demostrar su valentía, pero cae en las redes de un submarinista que se lo lleva a una pecera en la consulta de un dentista en Sidney. Marlin sale en su búsqueda junto a Dory, un pez amnésico.', CAST(N'2003-05-30T00:00:00.000' AS DateTime), 100, 1, N'BUSCNDO1.JPG', N'BUSCANDO2.JPG')
INSERT [dbo].[Pelicula] ([IdPelicula], [Nombre], [Descripcion], [FechaCreacion], [Duracion], [CantPeliculas], [Imagen1], [Imagen2]) VALUES (4, N'Aladdin', N'Aladdín es un joven pobre que, junto con su mono Abú, se dedica a robar y engañar a la gente de Agrabah para poder sobrevivir. Él y Abú viven en una guarida, una casa abandonada y medio derruida en el bazar de la ciudad donde tienen una amplia vista al palacio. Cuando conoce a la princesa Jasmín se enamora de ella a primera vista, aunque desconoce que es la hija del Sultán. Mientras Aladdín desea vivir rodeado de lujos, Jasmín desea tener una vida sencilla.', CAST(N'1992-11-25T00:00:00.000' AS DateTime), 90, 3, N'ALADDINPELI1.JPG', N'ALADDINPELI2.JPG')
INSERT [dbo].[Pelicula] ([IdPelicula], [Nombre], [Descripcion], [FechaCreacion], [Duracion], [CantPeliculas], [Imagen1], [Imagen2]) VALUES (5, N'intensamente', N'Trata sobre Riley, una niña de 11 años muy alegre que de un día para otro debe mudarse de ciudad por el trabajo de su padre. La mayor parte de la historia en realidad se desarrolla dentro de su mente, donde conviven cinco emociones —Alegría, Tristeza, Temor, Desagrado y Furia— que se encargan de dirigir los comportamientos de su vida cotidiana.', CAST(N'2015-06-19T00:00:00.000' AS DateTime), 95, 1, N'INTENSAMENTE1.JPG', N'INTENSAMENTE2.JPG')
SET IDENTITY_INSERT [dbo].[Pelicula] OFF
GO
SET IDENTITY_INSERT [dbo].[Serie] ON 

INSERT [dbo].[Serie] ([IdSerie], [Nombre], [Descripcion], [FechaCreacion], [CantCapitulos], [Imagen1], [Imagen2]) VALUES (1, N'Phineas y Ferb', N'La serie sigue las vivencias de Phineas Flynn y su hermanastro británico Ferb Fletcher durante las vacaciones de verano.1? Cada día, los chicos se embarcan en un proyecto nuevo más allá de las capacidades normales de unos niños, lo que molesta a su hermana Candace Flynn, quien trata de revelarle tales proyectos a sus padres.', CAST(N'2007-09-28T00:00:00.000' AS DateTime), 140, N'PHINEASYFERBSERIE1.PNG', N'PHINEASYFERBSERIE2.PNG')
INSERT [dbo].[Serie] ([IdSerie], [Nombre], [Descripcion], [FechaCreacion], [CantCapitulos], [Imagen1], [Imagen2]) VALUES (2, N'Mickey Mouse', N'Mickey Mouse es una serie de comedia animada que gira en torno al dibujo animado de mismo nombre. Mickey se enfrenta a nuevas y disparatadas aventuras en diferentes escenarios como París, Venecia, Tokio o Nueva York.', CAST(N'1928-11-18T00:00:00.000' AS DateTime), 96, N'MICKEYMOUSESERIE1.PNG', N'MICKEYMOUSESERIE2.PNG')
INSERT [dbo].[Serie] ([IdSerie], [Nombre], [Descripcion], [FechaCreacion], [CantCapitulos], [Imagen1], [Imagen2]) VALUES (3, N'Liv y Maddie', N'Liv y Maddie (título original: Liv and Maddie)nota 1? es una serie de televisión estadounidense creada por John Beck y Ron Hart, y producida en forma conjunta por Beck & Hart Productions, Oops Doughnuts Productions e It Is a Laugh Productions para Disney Channel. La serie comenzó su producción en abril y se emitió por primera vez el 19 de julio de 2013.2?', CAST(N'2013-07-19T00:00:00.000' AS DateTime), 80, N'LIVYMADDIESERIE1.PNG', N'LIVYMADDIESERIE2.PNG')
INSERT [dbo].[Serie] ([IdSerie], [Nombre], [Descripcion], [FechaCreacion], [CantCapitulos], [Imagen1], [Imagen2]) VALUES (4, N'Jessie', N'Jessie es una serie de televisión estadounidense de comedia de temática infantil que se estrenó en Disney Channel el 30 de septiembre de 2011 y se emitió hasta el 16 de octubre de 2015.1?2? La serie fue creada y producida por Pamela Eells OConnell y protagonizada por Debby Ryan, Peyton List, Cameron Boyce, Karan Brar, Skai Jackson y Kevin Chamberlin.3?4?5?', CAST(N'2011-09-30T00:00:00.000' AS DateTime), 98, N'JESSIESERIE1.PNG', N'JESSIESERIE2.PNG')
SET IDENTITY_INSERT [dbo].[Serie] OFF
GO
ALTER TABLE [dbo].[Personaje]  WITH CHECK ADD  CONSTRAINT [FK_Personaje_Pelicula] FOREIGN KEY([IdPelicula])
REFERENCES [dbo].[Pelicula] ([IdPelicula])
GO
ALTER TABLE [dbo].[Personaje] CHECK CONSTRAINT [FK_Personaje_Pelicula]
GO
ALTER TABLE [dbo].[Personaje]  WITH CHECK ADD  CONSTRAINT [FK_Personaje_Serie] FOREIGN KEY([IdSerie])
REFERENCES [dbo].[Serie] ([IdSerie])
GO
ALTER TABLE [dbo].[Personaje] CHECK CONSTRAINT [FK_Personaje_Serie]
GO
