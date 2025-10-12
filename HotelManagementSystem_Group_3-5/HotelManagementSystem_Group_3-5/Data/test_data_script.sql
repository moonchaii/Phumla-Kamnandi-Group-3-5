-- Insert Guests (GuestID manually generated as 'GSTxxxxx')
INSERT INTO Guest (GuestID, ID, Name, Email, Phone, Address)
VALUES
('GST55070','0123589741','John Smith','jsmith@hotmail.co.za','0458798542','7 Main Rd, Rondebosch, 7700'),
('GST65914','0598753245','Nkosinathi Mthembu','nmthembu@gmail.co.za','0659872458','14 Lungelo Drive, Mtimkhulu, Durban, 4001'),
('GST25368','9788956321','Amy Fowler','afowler@kmail.com','0548958788','7 Sunshine Lane, Lotus River, 7980'),
('GST44614','0254789542','Sheldon Cooper','scooper@gmail.com','0202548795','8 William Road, Camton, 4510'),
('GST42563','3652687512','Leonard Hofstadter','leonard@lmail.com','5454896972','19 Ronddale Street, Rondebosch, 7700'),
('GST31954','0257984625','Rajesh Koothrappali','rajkooth@hotmail.com','85956987423','10 Rose Wale, Grassy Park, 7941'),
('GST58041','7954865215','Howard Wolowitz','howwol@tmail.com','25459875698','4 Sunnyville Road, Goodwood, 7845'),
('GST25252','5587446987','Penny Hofstadter','pennyhof@gmail.com','1235659897','21 Laney Lane, Toronto, Canada, 8741'),
('GST80084','0025416987','Bernie Wolowitz','bernwol@yahoo.com','0125478960','10 Bischops Road, Terryville, 7852'),
('GST56092','0225698802','Will Wheaton','wheatonwill@gmail.com','3265987845','9 Riverstone Road, Claremont, 9087');
GO


-- Insert Rooms
INSERT INTO Room (RoomID, RoomNumber, RoomType)
VALUES
('RM001', 1, 'Single'),
('RM002', 2, 'Single'),
('RM003', 3, 'Single'),
('RM004', 4, 'Single'),
('RM005', 5, 'Single');
GO


-- Insert Seasonal Rates
INSERT INTO SeasonalRate (SeasonName, StartDate, EndDate, Rate)
VALUES 
('Low', '2025-12-01','2025-12-07',550),
('Mid', '2025-12-08','2025-12-15',750),
('High', '2025-12-16','2025-12-31',995);
GO


-- Insert Bookings (ReferenceNumber = primary key)
-- 1-7th - early bookings
INSERT INTO Booking (ReferenceNumber, GuestID, RoomID, RoomNumber, TotalAmount, DepositAmount, DepositPaid, ArrivalDate, DepartureDate)
VALUES
('REF71635','GST56092','RM001',1,550.00,55.00,1,'2025-12-02','2025-12-03'),
('REF95843','GST44614','RM002',2,1650.00,165.00,1,'2025-12-04','2025-12-07');
GO

-- 8-15th - mid-season bookings
INSERT INTO Booking (ReferenceNumber, GuestID, RoomID, RoomNumber, TotalAmount, DepositAmount, DepositPaid, ArrivalDate, DepartureDate)
VALUES
('REF18373','GST42563','RM001',1,750.00,75.00,1,'2025-12-09','2025-12-10'),
('REF92837','GST80084','RM002',2,1500.00,150.00,1,'2025-12-10','2025-12-12');
GO

-- 24th - three rooms available
INSERT INTO Booking (ReferenceNumber, GuestID, RoomID, RoomNumber, TotalAmount, DepositAmount, DepositPaid, ArrivalDate, DepartureDate)
VALUES
('REF26868','GST25368','RM001',1,995.00,99.50,1,'2025-12-24','2025-12-25'),
('REF45610','GST44614','RM002',3,995.00,99.50,1,'2025-12-24','2025-12-25');
GO


-- Fully booked 25th–26th
INSERT INTO Booking (ReferenceNumber, GuestID, RoomID, RoomNumber, TotalAmount, DepositAmount, DepositPaid, ArrivalDate, DepartureDate)
VALUES
('REF18727','GST56092','RM001',1,995.00,99.50,1,'2025-12-25','2025-12-26'),
('REF64625','GST80084','RM002',2,995.00,99.50,1,'2025-12-25','2025-12-26'),
('REF87346','GST55070','RM003',3,995.00,99.50,1,'2025-12-25','2025-12-26'),
('REF03958','GST42563','RM004',4,1990.00,199.00,1,'2025-12-25','2025-12-27'),
('REF23746','GST58041','RM005',5,1990.00,199.00,1,'2025-12-25','2025-12-27');
GO


-- Partially booked 27th–28th
INSERT INTO Booking (ReferenceNumber, GuestID, RoomID, RoomNumber, TotalAmount, DepositAmount, DepositPaid, ArrivalDate, DepartureDate)
VALUES
('REF12544','GST31954','RM001',1,995.00,99.50,1,'2025-12-27','2025-12-28'),
('REF74826','GST25368','RM002',2,1990.00,199.00,1,'2025-12-27','2025-12-29'),
('REF83647','GST25252','RM003',3,1990.00,199.00,1,'2025-12-27','2025-12-29'),
('REF83664','GST55070','RM005',5,1990.00,199.00,1,'2025-12-27','2025-12-29'),
('REF38261','GST80084','RM001',1,995.00,99.50,1,'2025-12-28','2025-12-29');
GO


