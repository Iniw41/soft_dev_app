USE Iniw_Chat_DB;
Go

CREATE TABLE Users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(50) NOT NULL,
    password_hash VARCHAR(255) NOT NULL,  -- never store plain passwords!
    email VARCHAR(100) NOT NULL,
    age INT NULL
);


CREATE TABLE Chats (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    SenderUsername VARCHAR(50) NOT NULL,
    ReceiverUsername VARCHAR(50) NOT NULL,
    MessageText NVARCHAR(MAX) NOT NULL,
    SentTime DATETIME NOT NULL
);USE Iniw_Chat_DB;
GO



