USE DB_Bug_Tracking_Application; -- Use your database name


CREATE TABLE tbl_Project (
    ProjectID INT PRIMARY KEY IDENTITY,
    ProjectTitle NVARCHAR(100) NOT NULL,
    ProjectDescription NVARCHAR(MAX),
    ProjectUrl NVARCHAR(200),
    StartDate DATE,
    EndDate DATE
);

DROP TABLE tbl_Project;

CREATE TABLE tbl_Project (
    ProjectID INT PRIMARY KEY IDENTITY,
    ProjectTitle NVARCHAR(100) NOT NULL,
    ProjectDescription NVARCHAR(MAX),
    ProjectUrl NVARCHAR(200),
    StartDate NVARCHAR(20),
    EndDate NVARCHAR(20)
);

INSERT INTO tbl_Project (ProjectTitle, ProjectDescription, ProjectUrl, StartDate, EndDate)
VALUES ('Sample Project', 'This is a sample project description.', 'https://sampleproject.com', '2024-06-18', '2024-07-18');

SELECT * FROM tbl_Project;
