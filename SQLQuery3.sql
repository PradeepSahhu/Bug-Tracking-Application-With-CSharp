
USE DB_Bug_Tracking_Application; -- Use your database name

CREATE TABLE tbl_Bug (
    BugID INT PRIMARY KEY IDENTITY(1,1),
    ProjectTitle NVARCHAR(100),
    BugTitle NVARCHAR(100),
    BugDescription NVARCHAR(MAX),
    Severity NVARCHAR(50),
    Status NVARCHAR(50),
    ReportDate NVARCHAR(20),
    SubmitCode NVARCHAR(MAX),
    ImagePath NVARCHAR(200),
    AssignTo INT -- Assuming AssignTo is referencing USERID from tbl_User
);

DROP TABLE tbl_Bug;

INSERT INTO tbl_Bug (ProjectTitle, BugTitle, BugDescription, Severity, Status, ReportDate, SubmitCode, ImagePath, AssignTo)
VALUES ('Sample Project', 'Sample Bug Title', 'Sample Bug Description', 'High', 'Open', '2024-06-18', 'ABC123', '/images/sample.jpg', 2);

DELETE FROM tbl_Bug WHERE BugID = 1;
SELECT * FROM tbl_Bug;