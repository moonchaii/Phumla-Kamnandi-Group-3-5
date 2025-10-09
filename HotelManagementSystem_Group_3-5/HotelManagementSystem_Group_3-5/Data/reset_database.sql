
ALTER TABLE Booking NOCHECK CONSTRAINT ALL;
ALTER TABLE Guest NOCHECK CONSTRAINT ALL;
ALTER TABLE Room NOCHECK CONSTRAINT ALL;
ALTER TABLE SeasonalRate NOCHECK CONSTRAINT ALL;


DELETE FROM Booking;
DELETE FROM Guest;
DELETE FROM Room;
DELETE FROM SeasonalRate;

DBCC CHECKIDENT ('Booking', RESEED, 0);
DBCC CHECKIDENT ('Guest', RESEED, 0);
DBCC CHECKIDENT ('Room', RESEED, 0);
DBCC CHECKIDENT ('SeasonalRate', RESEED, 0);

ALTER TABLE Booking CHECK CONSTRAINT ALL;
ALTER TABLE Guest CHECK CONSTRAINT ALL;
ALTER TABLE Room CHECK CONSTRAINT ALL;
ALTER TABLE SeasonalRate CHECK CONSTRAINT ALL;


-- Guests
INSERT INTO Guest (IdNo, Name, Email, Phone, Address)
VALUES
(0123589741,'John Smith','jsmith@hotmail.co.za','0458798542','7 Main Rd, Rondebosch, 7700'),
(0598753245,'Nkosinathi Mthembu','nmthembu@gmail.co.za','0659872458','14 Lungelo Drive, Mtimkhulu, Durban, 4001'),
(9788956321,'Amy Fowler','afowler@kmail.com','0548958788','7 Sunshine Lane, Lotus River, 7980'),
(0254789542,'Sheldon Cooper','scooper@gmail.com','0202548795','8 William Road, Camton, 4510'),
(3652687512,'Leonard Hofstadter','leonard@lmail.com','5454896972','19 Ronddale Street, Rondebosch, 7700'),
(0257984625,'Rajesh Koothrappali','rajkooth@hotmail.com','85956987423','10 Rose Wale, Grassy Park, 7941'),
(7954865215,'Howard Wolowitz','howwol@tmail.com','25459875698','4 Sunnyville Road, Goodwood, 7845'),
(5587446987,'Penny Hofstadter','pennyhof@gmail.com','1235659897','21 Laney Lane, Toronto, Canada, 8741'),
(0025416987,'Bernie Wolowitz','bernwol@yahoo.com','012547896','10 Bischops Road, Terryville, 7852'),
(0225698802,'Will Wheaton','wheatonwill@gmail.com','3265987845','9 Riverstone Road, Claremont, 9087');

-- Rooms
INSERT INTO Room (RoomType)
VALUES ('Single'), ('Single'), ('Single'), ('Single'), ('Single');

-- Seasonal Rates
INSERT INTO SeasonalRate (SeasonName, StartDate, EndDate, Rate)
VALUES
('Low', '2025-12-01','2025-12-07',550),
('Mid', '2025-12-08','2025-12-15',750),
('High','2025-12-16','2025-12-31',995);

-- Bookings
-- 24th – three rooms available
INSERT INTO Booking (RoomID, GuestID, SeasonID, BookingStatus, CheckIn, CheckOut, Payment, Deposit)
VALUES
(1,5,3,'Confirmed','2025-12-24','2025-12-25',995.00,99.50),
(2,3,3,'Confirmed','2025-12-24','2025-12-25',995.00,99.50);

-- fully booked 25–26
INSERT INTO Booking (RoomID, GuestID, SeasonID, BookingStatus, CheckIn, CheckOut, Payment, Deposit)
VALUES
(1,1,3,'Confirmed','2025-12-25','2025-12-26',995.00,99.50),
(2,8,3,'Confirmed','2025-12-25','2025-12-27',995.00,99.50),
(3,7,3,'Confirmed','2025-12-25','2025-12-27',995.00,99.50),
(4,5,3,'Confirmed','2025-12-25','2025-12-27',995.00,99.50),
(5,9,3,'Confirmed','2025-12-25','2025-12-27',995.00,99.50);

-- one room available 27–28
INSERT INTO Booking (RoomID, GuestID, SeasonID, BookingStatus, CheckIn, CheckOut, Payment, Deposit)
VALUES
(1,7,3,'Confirmed','2025-12-27','2025-12-29',995.00,99.50),
(2,3,3,'Confirmed','2025-12-27','2025-12-29',995.00,99.50),
(3,4,3,'Confirmed','2025-12-27','2025-12-29',995.00,99.50),
(5,6,3,'Confirmed','2025-12-27','2025-12-29',995.00,99.50);

-- 🧾 Verify
SELECT 
    (SELECT COUNT(*) FROM Guest) AS Guests,
    (SELECT COUNT(*) FROM Room) AS Rooms,
    (SELECT COUNT(*) FROM SeasonalRate) AS Seasons,
    (SELECT COUNT(*) FROM Booking) AS Bookings;
