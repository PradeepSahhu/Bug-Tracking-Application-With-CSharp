USE DB_Bug_Tracking_Application; -- Use your database name

-- Drop the table if it already exists (optional, to avoid conflicts during repeated testing)
IF OBJECT_ID('tbl_User', 'U') IS NOT NULL
    DROP TABLE tbl_User;

-- Create the tbl_User table
CREATE TABLE tbl_User (
    UserId INT IDENTITY(1,1) PRIMARY KEY, 
    FullName NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL UNIQUE,
    Username NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(255) NOT NULL, 
    Gender NVARCHAR(10) NOT NULL,
    Contact NVARCHAR(15) NOT NULL,
    Address NVARCHAR(255) NOT NULL,
    UserType NVARCHAR(50) NOT NULL
);

SELECT * FROM tbl_User;


INSERT INTO tbl_User (FullName, Email, Username, Password, Gender, Contact, Address, UserType)
VALUES ('Pradeep Sahu', 'official.pradeepsahu@gmail.com','pradeepsahu', 'Pradeep', 'Male', '1234567890', 'D1 New Delhi', 'Admin');

INSERT INTO tbl_User (FullName, Email, Username, Password, Gender, Contact, Address, UserType)
VALUES ('Sahu', 'official.pradeep@gmail.com','sahupradeep', 'Sahu', 'Male', '1234567890', 'D1 New Delhi', 'Admin');
