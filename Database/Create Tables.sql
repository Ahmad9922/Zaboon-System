USE ZaboonDB
GO

-- ÃœÊ· √‰Ê«⁄ «·„” Œœ„Ì‰
CREATE TABLE UsersTypes (
    UserTypeID INT IDENTITY(1,1) PRIMARY KEY,
    Name INT NOT NULL,
    Description NVARCHAR(500) NULL
);

-- ÃœÊ· «·„” Œœ„Ì‰
CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    UserName NVARCHAR(50) NOT NULL UNIQUE,
    Password NVARCHAR(200) NOT NULL,
    Email NVARCHAR(50) NULL,
    Phone NVARCHAR(50) NULL,
    IsActive BIT NOT NULL DEFAULT 1,
    Permissions INT NULL,
    CreateDate DATETIME NOT NULL DEFAULT GETDATE(),
    UserTypeID INT NOT NULL,
    CONSTRAINT FK_Users_UserTypes FOREIGN KEY (UserTypeID) REFERENCES UsersTypes(UserTypeID)
);

-- ÃœÊ· √‰Ê«⁄ «·Œœ„« 
CREATE TABLE ServicesTypes (
    ServiceTypeID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(50) NOT NULL,
    Description NVARCHAR(500) NULL,
    IsActive BIT NOT NULL
);

-- ÃœÊ· «·Œœ„« 
CREATE TABLE Services (
    ServiceID INT IDENTITY(1,1) PRIMARY KEY,
    Description NVARCHAR(500) NULL,
    Image NVARCHAR(200) NULL,
    CreateDate DATETIME NOT NULL DEFAULT GETDATE(),
    ServiceTypeID INT NOT NULL,
    CONSTRAINT FK_Services_ServiceTypes FOREIGN KEY (ServiceTypeID) REFERENCES ServicesTypes(ServiceTypeID)
);

-- ÃœÊ· «·ÕÃÊ“« 
CREATE TABLE Reservations (
    ReservationID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL,
    ReservationDate DATETIME NOT NULL DEFAULT GETDATE(),
    ReservationStatus TINYINT NOT NULL,
    PaidFees SMALLMONEY NULL,
    ServiceID INT NOT NULL,
    CONSTRAINT FK_Reservations_Users FOREIGN KEY (UserID) REFERENCES Users(UserID),
    CONSTRAINT FK_Reservations_Services FOREIGN KEY (ServiceID) REFERENCES Services(ServiceID)
);

-- ÃœÊ· «· ﬁÌÌ„« 
CREATE TABLE Feedback (
    FeedbackID INT IDENTITY(1,1) PRIMARY KEY,
    ReservationID INT NOT NULL,
    Rating TINYINT CHECK (Rating BETWEEN 1 AND 5),
    Comment NVARCHAR(1000) NULL,
    FeedbackDate DATETIME NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Feedback_Reservations FOREIGN KEY (ReservationID) REFERENCES Reservations(ReservationID)
);
