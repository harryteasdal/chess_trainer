USE [master]
GO
/****** Object:  Database [Chess_Trainer]    Script Date: 09/04/2020 09:45:47 ******/
CREATE DATABASE [Chess_Trainer]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Chess Trainer', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Chess Trainer.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Chess Trainer_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS\MSSQL\DATA\Chess Trainer_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Chess_Trainer] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Chess_Trainer].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Chess_Trainer] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Chess_Trainer] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Chess_Trainer] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Chess_Trainer] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Chess_Trainer] SET ARITHABORT OFF 
GO
ALTER DATABASE [Chess_Trainer] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Chess_Trainer] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Chess_Trainer] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Chess_Trainer] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Chess_Trainer] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Chess_Trainer] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Chess_Trainer] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Chess_Trainer] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Chess_Trainer] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Chess_Trainer] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Chess_Trainer] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Chess_Trainer] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Chess_Trainer] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Chess_Trainer] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Chess_Trainer] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Chess_Trainer] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Chess_Trainer] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Chess_Trainer] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [Chess_Trainer] SET  MULTI_USER 
GO
ALTER DATABASE [Chess_Trainer] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Chess_Trainer] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Chess_Trainer] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Chess_Trainer] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Chess_Trainer] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [Chess_Trainer] SET QUERY_STORE = OFF
GO
USE [Chess_Trainer]
GO
/****** Object:  Table [dbo].[chess_user]    Script Date: 09/04/2020 09:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[chess_user](
	[user_id] [int] IDENTITY(1,1) NOT NULL,
	[firstname] [varchar](25) NOT NULL,
	[secondname] [varchar](30) NOT NULL,
	[email] [varchar](75) NOT NULL,
	[mobile_number] [int] NULL,
	[country_id] [int] NOT NULL,
 CONSTRAINT [pk_user] PRIMARY KEY CLUSTERED 
(
	[user_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[country]    Script Date: 09/04/2020 09:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[country](
	[country_id] [int] IDENTITY(1,1) NOT NULL,
	[country] [varchar](30) NOT NULL,
 CONSTRAINT [pk_country] PRIMARY KEY CLUSTERED 
(
	[country_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[historical_rank]    Script Date: 09/04/2020 09:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[historical_rank](
	[user_id] [int] NOT NULL,
	[rank] [int] NOT NULL,
	[rank_date] [datetime] NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[outcome]    Script Date: 09/04/2020 09:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[outcome](
	[outcome_id] [int] IDENTITY(1,1) NOT NULL,
	[outcome] [int] NOT NULL,
	[prediction_id] [int] NOT NULL,
 CONSTRAINT [pk_outcome] PRIMARY KEY CLUSTERED 
(
	[outcome_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[player_rank]    Script Date: 09/04/2020 09:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[player_rank](
	[rank_id] [int] IDENTITY(1,1) NOT NULL,
	[rank_number] [int] NOT NULL,
	[user_id] [int] NOT NULL,
	[start_date] [datetime] NULL,
 CONSTRAINT [pk_rank] PRIMARY KEY CLUSTERED 
(
	[rank_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[prediction]    Script Date: 09/04/2020 09:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[prediction](
	[prediction_id] [int] IDENTITY(1,1) NOT NULL,
	[player1_id] [int] NOT NULL,
	[player2_id] [int] NOT NULL,
	[prediction] [decimal](18, 0) NOT NULL,
 CONSTRAINT [pk_prediction] PRIMARY KEY CLUSTERED 
(
	[prediction_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_prediction_linktable]    Script Date: 09/04/2020 09:45:47 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_prediction_linktable](
	[link_id] [int] IDENTITY(1,1) NOT NULL,
	[user_id] [int] NOT NULL,
	[prediction_id] [int] NOT NULL,
 CONSTRAINT [pk_user_link] PRIMARY KEY CLUSTERED 
(
	[link_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[player_rank] ADD  CONSTRAINT [DF_player_rank_start_date]  DEFAULT (getdate()) FOR [start_date]
GO
ALTER TABLE [dbo].[chess_user]  WITH CHECK ADD  CONSTRAINT [FK_chess_user_country] FOREIGN KEY([country_id])
REFERENCES [dbo].[country] ([country_id])
GO
ALTER TABLE [dbo].[chess_user] CHECK CONSTRAINT [FK_chess_user_country]
GO
ALTER TABLE [dbo].[outcome]  WITH CHECK ADD  CONSTRAINT [FK_outcome_Prediction] FOREIGN KEY([prediction_id])
REFERENCES [dbo].[prediction] ([prediction_id])
GO
ALTER TABLE [dbo].[outcome] CHECK CONSTRAINT [FK_outcome_Prediction]
GO
ALTER TABLE [dbo].[player_rank]  WITH CHECK ADD  CONSTRAINT [FK_player_rank_chess_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[chess_user] ([user_id])
GO
ALTER TABLE [dbo].[player_rank] CHECK CONSTRAINT [FK_player_rank_chess_user]
GO
ALTER TABLE [dbo].[user_prediction_linktable]  WITH CHECK ADD  CONSTRAINT [FK_user_prediction_linktable_chess_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[chess_user] ([user_id])
GO
ALTER TABLE [dbo].[user_prediction_linktable] CHECK CONSTRAINT [FK_user_prediction_linktable_chess_user]
GO
ALTER TABLE [dbo].[user_prediction_linktable]  WITH CHECK ADD  CONSTRAINT [FK_user_prediction_linktable_prediction] FOREIGN KEY([prediction_id])
REFERENCES [dbo].[prediction] ([prediction_id])
GO
ALTER TABLE [dbo].[user_prediction_linktable] CHECK CONSTRAINT [FK_user_prediction_linktable_prediction]
GO
USE [master]
GO
ALTER DATABASE [Chess_Trainer] SET  READ_WRITE 
GO
