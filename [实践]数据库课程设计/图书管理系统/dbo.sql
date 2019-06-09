/*
 Navicat Premium Data Transfer

 Source Server         : DU-PC
 Source Server Type    : SQL Server
 Source Server Version : 14001000
 Source Host           : DU-PC:1433
 Source Catalog        : Library loan management system
 Source Schema         : dbo

 Target Server Type    : SQL Server
 Target Server Version : 14001000
 File Encoding         : 65001

 Date: 16/04/2019 22:33:32
*/


-- ----------------------------
-- Table structure for Account
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Account]') AND type IN ('U'))
	DROP TABLE [dbo].[Account]
GO

CREATE TABLE [dbo].[Account] (
  [ID] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Password] char(50) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Atype] smallint  NOT NULL,
  [Borrownum] smallint  NOT NULL,
  [Cost] smallint  NOT NULL
)
GO

ALTER TABLE [dbo].[Account] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Records of [Account]
-- ----------------------------
INSERT INTO [dbo].[Account]  VALUES (N'root                ', N'123456789                                         ', N'1', N'0', N'0')
GO

INSERT INTO [dbo].[Account]  VALUES (N'sa                  ', N'123456                                            ', N'2', N'0', N'0')
GO


-- ----------------------------
-- Table structure for Administrator
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Administrator]') AND type IN ('U'))
	DROP TABLE [dbo].[Administrator]
GO

CREATE TABLE [dbo].[Administrator] (
  [Aid] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Aname] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Asex] char(2) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Aphone] char(11) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Administrator] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Book
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Book]') AND type IN ('U'))
	DROP TABLE [dbo].[Book]
GO

CREATE TABLE [dbo].[Book] (
  [Bno] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Bname] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Btype] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Bauthor] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Bpublish] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Bprice] smallint  NOT NULL,
  [Bnumber] smallint  NOT NULL
)
GO

ALTER TABLE [dbo].[Book] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Borrow
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Borrow]') AND type IN ('U'))
	DROP TABLE [dbo].[Borrow]
GO

CREATE TABLE [dbo].[Borrow] (
  [ID] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Bno] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Borrowtime] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Returntime] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Borrowstate] smallint  NOT NULL
)
GO

ALTER TABLE [dbo].[Borrow] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Student
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Student]') AND type IN ('U'))
	DROP TABLE [dbo].[Student]
GO

CREATE TABLE [dbo].[Student] (
  [Sno] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Sname] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Ssex] char(2) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Smajor] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Sclass] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Sphone] char(11) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Sdegree] smallint  NOT NULL
)
GO

ALTER TABLE [dbo].[Student] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Table structure for Teacher
-- ----------------------------
IF EXISTS (SELECT * FROM sys.all_objects WHERE object_id = OBJECT_ID(N'[dbo].[Teacher]') AND type IN ('U'))
	DROP TABLE [dbo].[Teacher]
GO

CREATE TABLE [dbo].[Teacher] (
  [Tno] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Tname] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Tsex] char(2) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Tacademy] char(20) COLLATE Chinese_PRC_CI_AS  NOT NULL,
  [Tphone] char(11) COLLATE Chinese_PRC_CI_AS  NOT NULL
)
GO

ALTER TABLE [dbo].[Teacher] SET (LOCK_ESCALATION = TABLE)
GO


-- ----------------------------
-- Checks structure for table Account
-- ----------------------------
ALTER TABLE [dbo].[Account] ADD CONSTRAINT [CK__Account__Passwor__398D8EEE] CHECK (len([Password])>=(6) AND len([Password])<=(50))
GO


-- ----------------------------
-- Primary Key structure for table Account
-- ----------------------------
ALTER TABLE [dbo].[Account] ADD CONSTRAINT [PK__Account__3214EC2795AE6991] PRIMARY KEY CLUSTERED ([ID])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Checks structure for table Administrator
-- ----------------------------
ALTER TABLE [dbo].[Administrator] ADD CONSTRAINT [CK__Administra__Asex__47DBAE45] CHECK ([Asex]='女' OR [Asex]='男')
GO

ALTER TABLE [dbo].[Administrator] ADD CONSTRAINT [CK__Administr__Aphon__48CFD27E] CHECK (len([Aphone])=(11))
GO


-- ----------------------------
-- Primary Key structure for table Administrator
-- ----------------------------
ALTER TABLE [dbo].[Administrator] ADD CONSTRAINT [PK__Administ__C6970A10D7A95918] PRIMARY KEY CLUSTERED ([Aid])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Book
-- ----------------------------
ALTER TABLE [dbo].[Book] ADD CONSTRAINT [PK__Book__C6D139AA20A99718] PRIMARY KEY CLUSTERED ([Bno])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Primary Key structure for table Borrow
-- ----------------------------
ALTER TABLE [dbo].[Borrow] ADD CONSTRAINT [PK__Borrow__8E79FFBD671452E1] PRIMARY KEY CLUSTERED ([ID], [Bno])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Checks structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [CK__Student__Ssex__403A8C7D] CHECK ([Ssex]='女' OR [Ssex]='男')
GO

ALTER TABLE [dbo].[Student] ADD CONSTRAINT [CK__Student__Sphone__412EB0B6] CHECK (len([Sphone])=(11))
GO


-- ----------------------------
-- Primary Key structure for table Student
-- ----------------------------
ALTER TABLE [dbo].[Student] ADD CONSTRAINT [PK__Student__CA1FE4644B10EF83] PRIMARY KEY CLUSTERED ([Sno])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Checks structure for table Teacher
-- ----------------------------
ALTER TABLE [dbo].[Teacher] ADD CONSTRAINT [CK__Teacher__Tsex__440B1D61] CHECK ([Tsex]='女' OR [Tsex]='男')
GO

ALTER TABLE [dbo].[Teacher] ADD CONSTRAINT [CK__Teacher__Tphone__44FF419A] CHECK (len([Tphone])=(11))
GO


-- ----------------------------
-- Primary Key structure for table Teacher
-- ----------------------------
ALTER TABLE [dbo].[Teacher] ADD CONSTRAINT [PK__Teacher__C450026D4ED73DE0] PRIMARY KEY CLUSTERED ([Tno])
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON)  
ON [PRIMARY]
GO


-- ----------------------------
-- Foreign Keys structure for table Borrow
-- ----------------------------
ALTER TABLE [dbo].[Borrow] ADD CONSTRAINT [FK__Borrow__ID__3C69FB99] FOREIGN KEY ([ID]) REFERENCES [Account] ([ID]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

ALTER TABLE [dbo].[Borrow] ADD CONSTRAINT [FK__Borrow__Bno__3D5E1FD2] FOREIGN KEY ([Bno]) REFERENCES [Book] ([Bno]) ON DELETE NO ACTION ON UPDATE NO ACTION
GO

