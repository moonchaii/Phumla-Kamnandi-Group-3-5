-- Drop tables (in dependency order)
DROP TABLE IF EXISTS Payment;
DROP TABLE IF EXISTS Booking;
DROP TABLE IF EXISTS Guest;
DROP TABLE IF EXISTS Room;
DROP TABLE IF EXISTS SeasonalRate;

CREATE TABLE Guest
(
    GuestID     BIGINT       NOT NULL PRIMARY KEY,
    ID          VARCHAR(10),
    Name        VARCHAR(20),
    Email       VARCHAR(50),
    Phone       VARCHAR(20),
    Address     VARCHAR(50)
);

CREATE TABLE Room
(
    RoomID      NVARCHAR(15) NOT NULL PRIMARY KEY,
    RoomType    NVARCHAR(50),
    RoomStatus  NVARCHAR(50) DEFAULT 'Available'
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
    BookingID    NVARCHAR(15)   NOT NULL PRIMARY KEY,
    GuestID          BIGINT         NOT NULL,
    RoomID           NVARCHAR(15)   NOT NULL,
    RoomNumber       INT            NOT NULL,
    TotalAmount      MONEY          NOT NULL,
    DepositAmount    MONEY          NOT NULL,
    DepositPaid      BIT            NOT NULL DEFAULT 0,
    ReferenceNumber  NVARCHAR(50)   NULL,
    ArrivalDate      DATETIME       NOT NULL,
    DepartureDate    DATETIME       NOT NULL,
    DateCreated      DATETIME       NOT NULL DEFAULT GETDATE(),
    CONSTRAINT FK_Reservation_Guest FOREIGN KEY (GuestID) REFERENCES Guest(GuestID),
    CONSTRAINT FK_Reservation_Room  FOREIGN KEY (RoomID)  REFERENCES Room(RoomID)
);

CREATE TABLE Payment
(
    PaymentID    INT PRIMARY KEY IDENTITY(1,1),
    ReservationID NVARCHAR(15),
    AmountPaid   DECIMAL(10,2),
    DatePaid     DATE,
    DepositPaid  VARCHAR(50),
    FOREIGN KEY (ReservationID) REFERENCES Booking(BookingID)
);
