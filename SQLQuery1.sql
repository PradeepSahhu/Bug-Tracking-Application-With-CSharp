USE DB_Bug_Tracking_Application; -- Use your database name

CREATE TABLE tbl_USER (
    UserID INT PRIMARY KEY IDENTITY(1,1),
    Username NVARCHAR(100) NOT NULL,
    Password NVARCHAR(100) NOT NULL,
    UserType NVARCHAR(50) NOT NULL

);
INSERT INTO tbl_USER (Username, Password, UserType)
VALUES ('admin', 'adminpassword', 'Admin'),
       ('user1', 'user1password', 'User');
INSERT INTO tbl_USER VALUES('Sahu','Sahu','Admin');

SELECT * FROM tbl_USER;
