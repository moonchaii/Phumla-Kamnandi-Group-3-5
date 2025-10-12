IF OBJECT_ID('FK_Booking_Guest', 'F') IS NOT NULL
    ALTER TABLE Booking DROP CONSTRAINT FK_Booking_Guest;

IF OBJECT_ID('FK_Booking_Room', 'F') IS NOT NULL
    ALTER TABLE Booking DROP CONSTRAINT FK_Booking_Room;

-- Drop tables in dependency order
IF OBJECT_ID('Booking', 'U') IS NOT NULL DROP TABLE Booking;
IF OBJECT_ID('SeasonalRate', 'U') IS NOT NULL DROP TABLE SeasonalRate;
IF OBJECT_ID('Room', 'U') IS NOT NULL DROP TABLE Room;
IF OBJECT_ID('Guest', 'U') IS NOT NULL DROP TABLE Guest;

CREATE TABLE Guest
(
    GuestID     NVARCHAR(15)  NOT NULL PRIMARY KEY,  -- e.g. 'GST29103'
    ID          VARCHAR(10),
    Name        VARCHAR(50),
    Email       VARCHAR(100),
    Phone       VARCHAR(20),
    Address     VARCHAR(100)
);

CREATE TABLE Room
(
    RoomID      NVARCHAR(15) NOT NULL PRIMARY KEY,
    RoomNumber  INT,
    RoomType    NVARCHAR(50),
);

CREATE TABLE SeasonalRate
(
    SeasonID    INT PRIMARY KEY IDENTITY(1,1),
    SeasonName  VARCHAR(255),
    StartDate   DATE,
    EndDate     DATE,
    Rate        DECIMAL(10,2)
);

CREATE TABLE Booking
(
    ReferenceNumber  NVARCHAR(15)   NOT NULL PRIMARY KEY,  -- e.g. 'REF12345'
    GuestID          NVARCHAR(15)   NOT NULL,              -- FK to Guest.GuestID
    RoomID           NVARCHAR(15)   NOT NULL,              -- FK to Room.RoomID
    RoomNumber       INT            NOT NULL,
    TotalAmount      MONEY          NOT NULL,
    DepositAmount    MONEY          NOT NULL,
    DepositPaid      BIT            NOT NULL DEFAULT 0,
    ArrivalDate      DATETIME       NOT NULL,
    DepartureDate    DATETIME       NOT NULL,
    DateCreated      DATETIME       NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Booking_Guest FOREIGN KEY (GuestID) REFERENCES Guest(GuestID),
    CONSTRAINT FK_Booking_Room  FOREIGN KEY (RoomID)  REFERENCES Room(RoomID)
);