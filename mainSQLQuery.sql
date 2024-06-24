

SELECT * FROM dbo.tbl_Bug;

SELECT * FROM dbo.tbl_Project;


SELECT * FROM dbo.tbl_User;


use "DB_Bug_Tracking_Application";


CREATE TABLE tbl_Project (
    ProjectID INT PRIMARY KEY IDENTITY,
	 ProjectTitle NVARCHAR(100) NOT NULL,
    ProjectDescription TEXT,
    StartDate VARCHAR(50),
    EndDate VARCHAR(50),
    ProjectUrl VARCHAR(255),

);


CREATE TABLE tbl_Bug (
    BugID INT PRIMARY KEY IDENTITY(1,1),
    ProjectTitle VARCHAR(255),
    BugTitle VARCHAR(255),
    BugDescription TEXT,
    Severity VARCHAR(50),
    Status VARCHAR(50),
    ReportDate VARCHAR(50),
    BugImage VARCHAR(255),
    AssignTo VARCHAR(100),
    SubmitCode VARCHAR(50),
    ImagePath VARCHAR(255)
);

SELECT * FROM tbl_Bug;
SELECT * FROM tbl_Project;



DROP TABLE tbl_Project;
DROP TABLE tbl_Bug;