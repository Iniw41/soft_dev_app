USE Iniw_Chat_DB;
Go

CREATE TABLE Users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password_hash VARCHAR(255) NOT NULL,  -- never store plain passwords!
    email VARCHAR(100) NOT NULL,
    age INT NULL
);

-- 2. Insert three initial users (you don’t supply id; SQL Server will assign 1, 2, 3)
INSERT INTO Users (username, password_hash, email, age)
VALUES  ('Biniw', HASHBYTES('SHA2_256','Test_Admin'),   'carol@example.com', 22);