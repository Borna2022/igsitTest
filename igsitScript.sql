USE [master]
GO
/****** Object:  Database [igsitDBTest]    Script Date: 9/27/2024 7:01:19 PM ******/
CREATE DATABASE [igsitDBTest]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'igsitDBTest', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\igsitDBTest.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'igsitDBTest_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\igsitDBTest_log.ldf' , SIZE = 2048KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [igsitDBTest] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [igsitDBTest].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [igsitDBTest] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [igsitDBTest] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [igsitDBTest] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [igsitDBTest] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [igsitDBTest] SET ARITHABORT OFF 
GO
ALTER DATABASE [igsitDBTest] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [igsitDBTest] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [igsitDBTest] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [igsitDBTest] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [igsitDBTest] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [igsitDBTest] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [igsitDBTest] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [igsitDBTest] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [igsitDBTest] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [igsitDBTest] SET  DISABLE_BROKER 
GO
ALTER DATABASE [igsitDBTest] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [igsitDBTest] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [igsitDBTest] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [igsitDBTest] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [igsitDBTest] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [igsitDBTest] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [igsitDBTest] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [igsitDBTest] SET RECOVERY FULL 
GO
ALTER DATABASE [igsitDBTest] SET  MULTI_USER 
GO
ALTER DATABASE [igsitDBTest] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [igsitDBTest] SET DB_CHAINING OFF 
GO
ALTER DATABASE [igsitDBTest] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [igsitDBTest] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [igsitDBTest] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [igsitDBTest] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'igsitDBTest', N'ON'
GO
ALTER DATABASE [igsitDBTest] SET QUERY_STORE = ON
GO
ALTER DATABASE [igsitDBTest] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [igsitDBTest]
GO
/****** Object:  Table [dbo].[T_Login]    Script Date: 9/27/2024 7:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Login](
	[ID_Login] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_T_Login] PRIMARY KEY CLUSTERED 
(
	[ID_Login] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Penalty]    Script Date: 9/27/2024 7:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Penalty](
	[fpnl_ID] [int] IDENTITY(1,1) NOT NULL,
	[fpnl_PenaltyCode] [nvarchar](50) NOT NULL,
	[fpnl_PenaltyCost] [int] NOT NULL,
	[fpnl_PenaltyDescription] [nvarchar](200) NOT NULL,
 CONSTRAINT [PK_T_Penalty] PRIMARY KEY CLUSTERED 
(
	[fpnl_PenaltyCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [UQ_PenaltyCode] UNIQUE NONCLUSTERED 
(
	[fpnl_PenaltyCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_PenaltyRegister]    Script Date: 9/27/2024 7:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_PenaltyRegister](
	[fprg_ID] [int] IDENTITY(1,1) NOT NULL,
	[fprg_personCode] [nvarchar](50) NOT NULL,
	[fprg_PenaltyCode] [nvarchar](50) NOT NULL,
	[fprg_PenaltyDate] [nvarchar](50) NULL,
 CONSTRAINT [PK__T_Penalt__1092054CBC1C83A9] PRIMARY KEY CLUSTERED 
(
	[fprg_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[T_Persons]    Script Date: 9/27/2024 7:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[T_Persons](
	[fprs_ID] [int] IDENTITY(1,1) NOT NULL,
	[fprs_personCode] [nvarchar](50) NOT NULL,
	[fprs_Name] [nvarchar](50) NULL,
	[fprs_LastName] [nvarchar](50) NULL,
	[fprs_VinCode] [nvarchar](50) NULL,
 CONSTRAINT [PK_T_Persons] PRIMARY KEY CLUSTERED 
(
	[fprs_personCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_PenaltyCode]    Script Date: 9/27/2024 7:01:20 PM ******/
CREATE NONCLUSTERED INDEX [idx_PenaltyCode] ON [dbo].[T_PenaltyRegister]
(
	[fprg_PenaltyCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [idx_PersonCode]    Script Date: 9/27/2024 7:01:20 PM ******/
CREATE NONCLUSTERED INDEX [idx_PersonCode] ON [dbo].[T_PenaltyRegister]
(
	[fprg_personCode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
GO
ALTER TABLE [dbo].[T_PenaltyRegister]  WITH CHECK ADD  CONSTRAINT [FK_T_PenaltyRegister_T_Penalty] FOREIGN KEY([fprg_PenaltyCode])
REFERENCES [dbo].[T_Penalty] ([fpnl_PenaltyCode])
GO
ALTER TABLE [dbo].[T_PenaltyRegister] CHECK CONSTRAINT [FK_T_PenaltyRegister_T_Penalty]
GO
ALTER TABLE [dbo].[T_PenaltyRegister]  WITH CHECK ADD  CONSTRAINT [FK_T_PenaltyRegister_T_Persons] FOREIGN KEY([fprg_personCode])
REFERENCES [dbo].[T_Persons] ([fprs_personCode])
GO
ALTER TABLE [dbo].[T_PenaltyRegister] CHECK CONSTRAINT [FK_T_PenaltyRegister_T_Persons]
GO
/****** Object:  StoredProcedure [dbo].[GetPenaltyDetails]    Script Date: 9/27/2024 7:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetPenaltyDetails]
AS
BEGIN
    SELECT 
        T_Persons.fprs_personCode AS 'کد',
        T_Persons.fprs_Name AS 'نام',
        T_Persons.fprs_LastName AS 'نام خانوادگی',
        T_Penalty.fpnl_PenaltyCost AS 'مبلغ جریمه',
        T_PenaltyRegister.fprg_PenaltyDate AS 'تاریخ جریمه'
    FROM 
        T_Persons
    INNER JOIN 
        T_PenaltyRegister ON T_Persons.fprs_personCode = T_PenaltyRegister.fprg_personCode
    INNER JOIN 
        T_Penalty ON T_PenaltyRegister.fprg_PenaltyCode = T_Penalty.fpnl_PenaltyCode
END
GO
/****** Object:  StoredProcedure [dbo].[GetTableColumns]    Script Date: 9/27/2024 7:01:20 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetTableColumns]
AS
BEGIN
    SELECT 
        t.name AS TableName,
        c.name AS ColumnName
    FROM 
        sys.tables AS t
    INNER JOIN 
        sys.columns AS c
        ON t.object_id = c.object_id
    ORDER BY 
        t.name, c.column_id;
END;
GO
USE [master]
GO
ALTER DATABASE [igsitDBTest] SET  READ_WRITE 
GO
