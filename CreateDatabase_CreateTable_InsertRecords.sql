CREATE DATABASE employee;
GO

USE employee;

GO

CREATE TABLE [dbo].[IndividualDemographics](
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
	[Sex] [nvarchar](10) NOT NULL,
	[Address] [nvarchar](100) NOT NULL
) ON [PRIMARY];

INSERT INTO DBO.IndividualDemographics 
VALUES ('A_James','Bond','M','1000 James Road, Bond, FL 33454'),
	   ('B_James','Bond','M','1000 James Road, Bond, FL 33454'),
	   ('C_James','Bond','M','1000 James Road, Bond, FL 33454'),
	   ('D_James','Bond','M','1000 James Road, Bond, FL 33454'),
	   ('E_James','Bond','M','1000 James Road, Bond, FL 33454'),
	   ('F_James','Bond','M','1000 James Road, Bond, FL 33454'),
	   ('G_James','Bond','M','1000 James Road, Bond, FL 33454'),
	   ('H_James','Bond','M','1000 James Road, Bond, FL 33454')