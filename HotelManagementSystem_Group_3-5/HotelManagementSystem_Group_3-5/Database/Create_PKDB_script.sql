-- drop just in case there are syncing issues here

USE PK_VV;
GO
DROP TABLE IF EXISTS Payment;
DROP TABLE IF EXISTS Booking;
DROP TABLE IF EXISTS Guest;
DROP TABLE IF EXISTS Room;
DROP TABLE IF EXISTS SeasonalRate;

create table Room
(
	RoomID int primary key identity(1,1),
	RoomType varchar(50),
	RoomStatus varchar(50) default 'Available'
);

create table Guest
(
	GuestID int primary key identity(1,1),
	IdNo varchar(255),
	Name varchar(255),
	Email varchar(255),
	Phone varchar(255),
	Address varchar(255)
)

create table SeasonalRate
(
	SeasonID int primary key identity(1,1),
	SeasonName varchar(255),
	StartDate date,
	EndDate date,
	Rate decimal(10,2)
);
create table Booking
(
	BookingID int primary key identity(1,1),
	RoomID int,
	GuestID int,
	SeasonID int,
	BookingStatus varchar(50),
	CheckIn date,
	CheckOut date,
	Payment decimal(10,2),
	Deposit decimal (10,2),
	foreign key (RoomID) references Room(RoomID),
	foreign key (GuestID) references Guest(GuestID),
	foreign key (SeasonID) references SeasonalRate(SeasonID)

);
create table Payment
(
	PaymentID int primary key identity(1,1),
	BookingID int,
	AmountPaid decimal(10,2),
	DatePaid date,
	DepositPaid varchar(50)
	foreign key (BookingID) references Booking(BookingID)
);
